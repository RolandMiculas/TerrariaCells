using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaCells.Content.Projectiles
{
    public class ExampleRubyStaff : ModProjectile
    {
        public override string Texture => "Terraria/Images/Extra_" + ProjectileID.ShadowBeamFriendly;

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Magic;
            Projectile.width = 4;
            Projectile.height = 20;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 0;
            Projectile.scale = 1;
            Projectile.extraUpdates = 10;
            Projectile.velocity.X = 4;
            Projectile.velocity.Y = 4;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.OnFire, 60 * 4);
        }
    }
}
