using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Utilities.Session;
using System.Security.Claims; 

namespace WinFormsUI.ProgramFrm
{
    public partial class FormProgram : MaterialForm
    {
        ProgramManager programManager = new ProgramManager(new EfProgramDal());

        public FormProgram()
        {
            InitializeComponent();
            this.Load += FormProgram_Load;
        }

        private void FormProgram_Load(object sender, EventArgs e)
        {
            try
            {
                var programs = programManager.GetAll();
                dgwProgram.DataSource = programs;

                if (programs.Count == 0)
                {
                    MessageBox.Show("Veritabanında program bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormProgramDetails form = new FormProgramDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwProgram.DataSource = programManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgwProgram.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir program seçin.");
                return;
            }

            Entities.Concrete.Program selectedProgram = (Entities.Concrete.Program)dgwProgram.CurrentRow.DataBoundItem;

            FormProgramDetails form = new FormProgramDetails(selectedProgram);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwProgram.DataSource = programManager.GetAll();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgwProgram.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir program seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entities.Concrete.Program selectedProgram = (Entities.Concrete.Program)dgwProgram.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show(
                $"{selectedProgram.ProgramID} numaralı programı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                programManager.Delete(selectedProgram);
                MessageBox.Show("Program başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgwProgram.DataSource = programManager.GetAll();
            }
        }

        private bool IsAdmin()
        {
            if (string.IsNullOrEmpty(Session.JwtToken))
            {
                MessageBox.Show("Yetki doğrulama için bir token bulunamadı. Lütfen giriş yapın.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(Session.JwtToken); 
                var claims = jwtToken.Claims;

                string role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value; 
                return role == "Admin";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Token doğrulama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
