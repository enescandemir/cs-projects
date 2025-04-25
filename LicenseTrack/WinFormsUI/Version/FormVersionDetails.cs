using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Concrete.Enums;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Version.Type = (int)cmbType.SelectedValue;
            Version.Name = txtName.Text;
            Version.Number = int.Parse(txtNumber.Text);
            Version.Description = txtDescription.Text;
            Version.DependentID = cmbDependentID.SelectedValue is int selectedId && selectedId > 0 ? selectedId : (int?)null;

            if (Version.VersionID == 0)
            {
                versionManager.Add(Version);
            }
            else
            {
                versionManager.Update(Version);
            }

            MessageBox.Show("Sürüm kaydı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
