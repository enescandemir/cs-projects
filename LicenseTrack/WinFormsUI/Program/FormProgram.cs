using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Windows.Forms;
using WinFormsUI.Program;

namespace WinFormsUI.Program
{
    public partial class FormProgram : Form
    {
        ProgramManager programManager = new ProgramManager(new EfProgramDal());

        public FormProgram()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgwProgram.DataSource = programManager.GetAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormProgramDetails form = new FormProgramDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
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
                LoadData();
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
                LoadData();
            }
        }
    }
}
