using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Concrete.Enums;
using FluentValidation;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsUI.Version
{
    public partial class FormVersionDetails : MaterialForm
    {
        public Entities.Concrete.Version Version { get; set; }
        private VersionManager versionManager = new VersionManager(new EfVersionDal());

        public FormVersionDetails(Entities.Concrete.Version version = null)
        {
            InitializeComponent();
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            LoadVersionTypes();
            LoadDependentVersions();
            txtName.TextChanged += txtName_TextChanged;

            if (version != null)
            {
                Version = version;
                cmbType.SelectedValue = (int)Version.Type;
                txtName.Text = Version.Name;
                txtNumber.Text = Version.Number.ToString();
                txtDescription.Text = Version.Description;
                cmbDependentID.SelectedValue = Version.DependentID ?? 0;
            }
            else
            {
                Version = new Entities.Concrete.Version();
            }
        }

        private void LoadVersionTypes()
        {
            cmbType.DataSource = new[]
            {
                new { Key = (int)VersionType.Veritabanı, Value = "Veritabanı" },
                new { Key = (int)VersionType.Program, Value = "Program" }
            }.ToList();

            cmbType.DisplayMember = "Value";
            cmbType.ValueMember = "Key";
        }


        private void LoadDependentVersions()
        {
            var versions = versionManager.GetAll();
            versions.Insert(0, new Entities.Concrete.Version { VersionID = 0, Name = "Bağımlı değil" });

            cmbDependentID.DataSource = versions;
            cmbDependentID.DisplayMember = "Name";
            cmbDependentID.ValueMember = "VersionID";
            cmbDependentID.SelectedIndex = 0;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string input = txtName.Text.Trim();
            if (input.StartsWith("v", StringComparison.OrdinalIgnoreCase))
                input = input.Substring(1);

            var parts = input.Split('.');
            if (parts.Length == 3 &&
                int.TryParse(parts[0], out int major) &&
                int.TryParse(parts[1], out int minor) &&
                int.TryParse(parts[2], out int patch))
            {
                if (major < 0 || major > 9 || minor < 0 || minor > 99 || patch < 0 || patch > 999)
                {
                    txtNumber.Text = string.Empty;
                    return;
                }

                txtName.TextChanged -= txtName_TextChanged;
                txtName.Text = $"V{major:D2}.{minor:D2}.{patch:D2}";
                txtName.SelectionStart = txtName.Text.Length;
                txtName.TextChanged += txtName_TextChanged;

                int versionNumber = major * 100000 + minor * 1000 + patch;
                txtNumber.Text = versionNumber.ToString();
            }
            else
            {
                txtNumber.Text = string.Empty;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir sürüm türü seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Lütfen sürüm adını girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Version.Type = (int)cmbType.SelectedValue;

            string name = txtName.Text.Trim();
            if (!name.StartsWith("V", StringComparison.OrdinalIgnoreCase))
            {
                name = "V" + name;
            }
            else
            {
                name = "V" + name.Substring(1); 
            }

            Version.Name = name;

            if (int.TryParse(txtNumber.Text, out int versionNumber))
            {
                Version.Number = versionNumber;
            }
            else
            {
                MessageBox.Show("Sürüm adı 'V01.02.05' formatında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Version.Description = txtDescription.Text;
            Version.DependentID = cmbDependentID.SelectedValue is int selectedId && selectedId > 0 ? selectedId : (int?)null;

            try
            {
                if (Version.VersionID == 0)
                {
                    versionManager.Add(Version);
                    MessageBox.Show("Sürüm kaydı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    versionManager.Update(Version);
                    MessageBox.Show("Sürüm kaydı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
