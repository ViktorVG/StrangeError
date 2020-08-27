//Created by KeysCG "www.youtube.com/keysrec"
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items //название мода "NameMods"
{
    public class lever : ModItem //название скрипта "NameScript"
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lever"); //название объекта в игре
            Tooltip.SetDefault("This grip will help you make a powerful tool."); //описание объекта в игре
        }

        public override void SetDefaults() //свойства объекта
        {
            item.width = 20; //ширина спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.height = 20; //высота спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.maxStack = 100; //максимальное количество штук в стаке
            item.value = 50; //стоимость в медных монетах "100" - это 1 серебро
            item.rare = 0; //редкость нашего объекта
        }

        public override void AddRecipes() //свойства крафта
        {
            ModRecipe recipe = new ModRecipe(mod); //новый рецепт
            recipe.AddIngredient(ItemID.Wood, 1); //ингридиенты из которых крафтится объект "DirtBlock" - земля "10" - количество
            recipe.AddTile(TileID.WorkBenches); //место для крафта "WorkBenches" - верстак
            recipe.SetResult(this, 3); //что получим после крафта "this" - этот объект "1" - количество штук
            recipe.AddRecipe();
        }
    }
}