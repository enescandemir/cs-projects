using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using WinFormsUI.ProgramFrm;

namespace WinFormsUI.ProgramFrm
{
    public partial class FormProgram : Form
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
                    MessageBox.Show("Veritabanında lisans bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormProgramDetails form = new FormProgramDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwProgram.DataSource = programManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
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
    }
}
