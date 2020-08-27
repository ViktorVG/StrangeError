//Created by KeysCG "www.youtube.com/keysrec"
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items //название мода "NameMods"
{
    public class OdamireOre : ModItem //название скрипта "NameScript"
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odamire Ore"); //название объекта в игре
            Tooltip.SetDefault("The only ore from which you can make anything."); //описание объекта в игре
        }

        public override void SetDefaults() //свойства объекта
        {
            item.width = 20; //ширина спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.height = 20; //высота спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.maxStack = 100; //максимальное количество штук в стаке
            item.value = 100050; //стоимость в медных монетах "100" - это 1 серебро
            item.rare = 2; //редкость нашего объекта
        }

        public override void AddRecipes() //свойства крафта
        {
            ModRecipe recipe = new ModRecipe(mod); //новый рецепт
            recipe.AddIngredient(ItemID.CopperOre, 1); //ингридиенты из которых крафтится объект "DirtBlock" - земля "10" - количество
            recipe.AddTile(TileID.WorkBenches); //место для крафта "WorkBenches" - верстак
            recipe.SetResult(this, 3); //что получим после крафта "this" - этот объект "1" - количество штук
            recipe.AddRecipe();
        }
    }
}