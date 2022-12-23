using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginProject.Models
{
    public class AppDBContext:IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public AppDBContext(DbContextOptions options):base(options)
        {
            _options = options;
        }

        //VERİTABANI İLK DEFA OLUŞTURULURKEN CALISAN BİR VİRTUAL METOTDUR. bU METOT SAYESİNDE VERİTABANI TABLOLARO OLUSTURMADAN ARAYA GİRECEK TABLO İSİMLERİNE MÜDAHELE EDEBİLCEK  VEYA KOLONLARA  İSTEDİGİMİZ  AYARLARI GERÇEKLEŞTİRMEK İÇİN KULLANILIR.

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);  
        }
    }
}
