using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MVC40.Knockout_App.Models.Mapping
{
    public class EmployeeInfoMap : EntityTypeConfiguration<EmployeeInfo>
    {
        public EmployeeInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.EmpNo);

            // Properties
            this.Property(t => t.EmpName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DeptName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Designation)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmployeeInfo");
            this.Property(t => t.EmpNo).HasColumnName("EmpNo");
            this.Property(t => t.EmpName).HasColumnName("EmpName");
            this.Property(t => t.Salary).HasColumnName("Salary");
            this.Property(t => t.DeptName).HasColumnName("DeptName");
            this.Property(t => t.Designation).HasColumnName("Designation");
        }
    }
}
