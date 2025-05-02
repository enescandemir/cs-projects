using Business.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Hashing;
using Core.Utilities.Session;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace WinFormsUI.License
{
    public partial class FormAdmin : MaterialForm
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public FormAdmin()
        {
            InitializeComponent();
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            this.Load += FormAdmin_Load;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            RefreshUserGrid();
        }
        private void buttonSetNewPassword_Click(object sender, EventArgs e)
        {
            if (dgwUser.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedUserId = Convert.ToInt32(dgwUser.SelectedRows[0].Cells["Id"].Value);
                    string newPassword = GenerateRandomPassword();
                    byte[] passwordHash, passwordSalt;
                    HashingHelper.CreatePasswordHash(newPassword, out passwordHash, out passwordSalt);
                    var user = userManager.GetById(selectedUserId);
                    if (user != null)
                    {
                        user.PasswordHash = passwordHash;
                        user.PasswordSalt = passwordSalt;

                        userManager.Update(user);
                        Clipboard.SetText(newPassword);

                        MessageBox.Show($"Yeni şifre başarıyla atanmıştır.\nYeni Şifre: {newPassword}\n(Şifre otomatik olarak panoya kopyalandı)",
                                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Şifre atanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private string GenerateRandomPassword()
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            return new string(Enumerable.Repeat(validChars, 8)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void buttonToggleAdmin_Click(object sender, EventArgs e)
        {
            if (dgwUser.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedUserId = Convert.ToInt32(dgwUser.SelectedRows[0].Cells["Id"].Value);

                    if (selectedUserId == Session.UserId)
                    {
                        MessageBox.Show("Kendi yetkilerinizi değiştiremezsiniz!", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var context = new LicenseTrackContext())
                    {
                        var userClaim = context.UserOperationClaims
                                               .FirstOrDefault(uoc => uoc.UserId == selectedUserId);

                        if (userClaim != null)
                        {
                            if (userClaim.OperationClaimId == 1)
                            {
                                userClaim.OperationClaimId = 2;
                                context.SaveChanges();
                                MessageBox.Show("Kullanıcı artık 'User' olarak ayarlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                userClaim.OperationClaimId = 1;
                                context.SaveChanges();
                                MessageBox.Show("Kullanıcı artık 'Admin' olarak ayarlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            context.UserOperationClaims.Add(new UserOperationClaims
                            {
                                UserId = selectedUserId,
                                OperationClaimId = 1
                            });
                            context.SaveChanges();
                            MessageBox.Show("Kullanıcı artık 'Admin' olarak ayarlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        RefreshUserGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgwUser.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedUserId = Convert.ToInt32(dgwUser.SelectedRows[0].Cells["Id"].Value);
                    if (selectedUserId == Session.UserId)
                    {
                        MessageBox.Show("Kendinizi silemezsiniz!", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var context = new LicenseTrackContext())
                    {
                        var userToDelete = context.Users.FirstOrDefault(u => u.Id == selectedUserId);
                        if (userToDelete != null)
                        {
                            context.Users.Remove(userToDelete);

                            var claimsToDelete = context.UserOperationClaims.Where(uoc => uoc.UserId == selectedUserId).ToList();
                            context.UserOperationClaims.RemoveRange(claimsToDelete);

                            context.SaveChanges();
                            MessageBox.Show("Kullanıcı ve tüm ilişkili veriler silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshUserGrid();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private BindingSource userBindingSource = new BindingSource();

        private void RefreshUserGrid()
        {
            using (var context = new LicenseTrackContext())
            {
                var usersWithRoles = context.Users.Select(user => new
                {
                    user.Id,
                    user.FirstName,
                    user.LastName,
                    user.Email,
                    Role = context.UserOperationClaims
                            .Where(uoc => uoc.UserId == user.Id)
                            .Select(uoc => uoc.OperationClaimId == 1 ? "Admin" : "User")
                            .FirstOrDefault()
                }).ToList();

                userBindingSource.DataSource = usersWithRoles;
                dgwUser.DataSource = userBindingSource;
                SetColumnHeaders();
            }
        }
        private void SetColumnHeaders()
        {
            if (dgwUser.Columns["Id"] != null) dgwUser.Columns["Id"].HeaderText = "Kullanıcı ID";
            if (dgwUser.Columns["FirstName"] != null) dgwUser.Columns["FirstName"].HeaderText = "Ad";
            if (dgwUser.Columns["LastName"] != null) dgwUser.Columns["LastName"].HeaderText = "Soyad";
            if (dgwUser.Columns["Email"] != null) dgwUser.Columns["Email"].HeaderText = "E-posta";
            if (dgwUser.Columns["Role"] != null) dgwUser.Columns["Role"].HeaderText = "Rol";
        }




    }
}
