using System.Collections.Generic;
using System.Media;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items.Armor
{

    [AutoloadEquip(EquipType.Body)]

    public class OdamireBreastplate : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odamire breastplate"); //название объекта в игре
            Tooltip.SetDefault("Your body are protected by the power of odamire! The lightness of this armor delights." +
                "+2% increased movement speed");

        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 6, silver: 5);
            item.rare = 2;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.02f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "OdamireOre", 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();





        }

    }




}