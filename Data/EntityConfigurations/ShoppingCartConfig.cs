using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfigurations
{
    public class ShoppingCartConfig : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(cart => cart.Id);
            builder.HasMany(cart => cart.CartItems)
                   .WithOne(item => item.ShoppingCart)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey(item => item.ShoppingCartId);
        }
    }
}
