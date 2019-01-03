using Microsoft.EntityFrameworkCore;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// 后台管理人员表
        /// </summary>
        public DbSet<Manager> Managers { get; set; }
        /// <summary>
        /// 行业表
        /// </summary>
        public DbSet<Industry> Industries { get; set; }
        /// <summary>
        /// 颜色表
        /// </summary>
        public DbSet<Color> Colors { get; set; }
        /// <summary>
        /// 产品表
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// 平台表
        /// </summary>
        public DbSet<Client> Clients { get; set; }
        /// <summary>
        /// 案例表
        /// </summary>
        public DbSet<Case> Cases { get; set; }
        /// <summary>
        /// 案例图片表
        /// </summary>
        public DbSet<CaseImage> CaseImages { get; set; }
        /// <summary>
        /// 合作意向表标题表
        /// </summary>
        public DbSet<CooperationTitle> CooperationTitles { get; set; }
        /// <summary>
        /// 合作意向标题内容表
        /// </summary>
        public DbSet<CooperationContent> CooperationContents { get; set; }
        /// <summary>
        /// 合作意向表
        /// </summary>
        public DbSet<Cooper> Coopers { get; set; }
        /// <summary>
        /// 系统信息设置表
        /// </summary>
        public DbSet<SystemInfo> SystemInfo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //管理人员表
            modelBuilder.Entity<Manager>(manager =>
            {
                manager.HasKey(x => x.ID);
                manager.ToTable("Manager");
            });

            //行业表
            modelBuilder.Entity<Industry>(industry =>
            {
                industry.HasKey(x => x.ID);
                industry.ToTable("Industry");
            });

            //行业与案例的中间表
            modelBuilder.Entity<IndustryCase>(industryCase =>
            {
                industryCase.HasKey(x => new { x.IndustryID,x.CaseID});
                industryCase.HasOne(x => x.Industry).WithMany(x => x.IndustryCases).HasForeignKey(x => x.IndustryID);
                industryCase.HasOne(x => x.Case).WithMany(x => x.IndustryCases).HasForeignKey(x => x.CaseID);
                industryCase.ToTable("IndustryCase");
            });

            //颜色表
            modelBuilder.Entity<Color>(color =>
            {
                color.HasKey(x => x.ID);
                color.ToTable("Color");
            });

            //颜色与案例的中间表
            modelBuilder.Entity<ColorCase>(colorCase =>
            {
                colorCase.HasKey(x => new {x.ColorID, x.CaseID});
                colorCase.HasOne(x => x.Color).WithMany(x => x.ColorCases).HasForeignKey(x => x.ColorID);
                colorCase.HasOne(x => x.Case).WithMany(x => x.ColorCases).HasForeignKey(x => x.CaseID);
                colorCase.ToTable("ColorCase");
            });

            //产品表
            modelBuilder.Entity<Product>(product =>
            {
                product.HasKey(x => x.ID);
                product.ToTable("Product");
            });

            //产品与案例的中间表
            modelBuilder.Entity<ProductCase>(productCase =>
            {
                productCase.HasKey(x => new {x.ProductID,x.CaseID });
                productCase.HasOne(x => x.Product).WithMany(x => x.ProductCases).HasForeignKey(x => x.ProductID);
                productCase.HasOne(x => x.Case).WithMany(x => x.ProductCases).HasForeignKey(x => x.CaseID);
                productCase.ToTable("ProductCase");
            });

            //客户端表
            modelBuilder.Entity<Client>(client =>
            {
                client.HasKey(x => x.ID);
                client.ToTable("Client");
            });

            //客户端与案例的中间表
            modelBuilder.Entity<ClientCase>(clientCase =>
            {
                clientCase.HasKey(x => new {x.ClientID, x.CaseID});
                clientCase.HasOne(x => x.Client).WithMany(x => x.ClientCases).HasForeignKey(x => x.ClientID);
                clientCase.HasOne(x => x.Case).WithMany(x => x.ClientCases).HasForeignKey(x => x.CaseID);
                clientCase.ToTable("ClientCase");
            });

            //案例表
            modelBuilder.Entity<Case>(mcase =>
            {
                mcase.HasKey(x => x.ID);
                mcase.HasMany(x => x.CaseImages).WithOne().HasForeignKey(x => x.CaseID);
                mcase.ToTable("Case");
            });

            //合作意向标题表
            modelBuilder.Entity<CooperationTitle>(cooperationTitle =>
            {
                cooperationTitle.HasKey(x => x.ID);
                //cooperationTitle.Property(x => x.Name).IsRequired().HasMaxLength(20);
                cooperationTitle.ToTable("CooperTitle");
            });

            //合作意向内容表
            modelBuilder.Entity<CooperationContent>(cooperationContents =>
            {
                cooperationContents.HasKey(x => x.ID);
                cooperationContents.HasOne(x => x.CooperationTitle).WithMany(x => x.CooperationContents)
                    .HasForeignKey(x => x.CooperationTitleID);
                cooperationContents.ToTable("CooperContent");
            });

            //合作表
            modelBuilder.Entity<Cooper>(cooper =>
            {
                cooper.HasKey(x => x.ID);
                cooper.ToTable("Coopers");
            });

            //系统信息表
            modelBuilder.Entity<SystemInfo>(systemInfo=>
            {
                systemInfo.HasKey(x=>x.ID);
                systemInfo.ToTable("SystemInfo");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}