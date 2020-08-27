using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items.Weapons
{
	public class InsanityKiller : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Insanity killer"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Are you ready to recognize the warrior's path?.");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 15015;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "OdamireOre", 4);
			recipe.AddIngredient(mod, "lever", 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}