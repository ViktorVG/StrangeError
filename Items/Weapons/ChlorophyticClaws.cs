using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items.Weapons
{
	public class ChlorophyticClaws : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Chlorophytic claws"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Needed to kill demons and fix the garden.");
		}

		public override void SetDefaults() 
		{
			item.damage = 92;
			
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 10;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 20031;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ChlorophyteThorn", 3);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}