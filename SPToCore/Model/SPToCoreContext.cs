using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SPToCore.Test;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SPToCore.Model
{
    public partial class SPToCoreContext : EMGERPContext
    {
        private DbSet<Material_GET> Matherial_GET { get; set; }

        public SPToCoreContext()
        {
        }

        public SPToCoreContext(DbContextOptions<EMGERPContext> options)
            : base(options)
        {
        }

       /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  
        {  
            if (!optionsBuilder.IsConfigured)  
            {
                optionsBuilder.UseSqlServer("Data Source=DN1;Initial Catalog=EMGERP;Persist Security Info=True;User ID=EMGERP_User;Password=emgerp;Connection Timeout=360");
            }  
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // [Asma Khalid]: Regster store procedure custom object.  
            modelBuilder.Query<Material_GET>().HasNoKey();

            //Thanks Valecass!!!
            base.OnModelCreating(modelBuilder);
        }

        #region 

        /// <summary>  
        /// Get Material detail by idMaterial.  
        /// </summary>  
        /// <param name="idMaterial">idMaterial parameter</param>  
        /// <returns>Returns - Material detail by idMaterial</returns>  
        public async Task<List<Material_GET>> Material_GETAsync(int idUser, int idMaterial)
        {
            // Initialization.  
            List<Material_GET> lst = new List<Material_GET>();

            try
            {
                // Settings.  
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing.  
                string sqlQuery = $@"EXEC [dbo].[Material_GET] 
                                                @idUser,
                                                @idMaterial
                                                ";

                lst = await this.Matherial_GET.FromSqlRaw(sqlQuery, p_idUser, p_idMaterial).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Info.  
            return lst;
        }

        #endregion
    }
}
