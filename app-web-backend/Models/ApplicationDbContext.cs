using Microsoft.EntityFrameworkCore;

namespace app_web_backend.Models {
    public class ApplicationDbContext : DbContext { // Classe de contexto do Entity Framework Core
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {

        }
        // models (objetos) que serão mapeados para o banco de dados
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
