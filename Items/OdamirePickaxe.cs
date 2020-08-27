//Created by KeysCG | Видеоуроки по моддингу террарии: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items //название вашего мода
{
    public class OdamirePickaxe : ModItem //название вашего скрипта
    {
    
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odamire pickaxe"); //название объекта в игре
            Tooltip.SetDefault("A pickaxe that is slighty better than the original. With it, you will be able to mine ore faster!"); //описание объекта в игре
        }

        public override void SetDefaults() //свойства объекта
        {
            item.damage = 10; // значение урона
            item.melee = true; //тип оружия "melee" - ближнего боя в руках
            item.width = 32; //ширина спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.height = 32; //высота спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.useTime = 20; //???
            item.useAnimation = 20; //???
            item.pick = 55;    //сила кирки
            item.useStyle = 1; //тип использования "1" - для размахивания
            item.knockBack = 10; //сила отбрасования "максимальное значение 20"
            item.value = 100021; //стоимость в медных монетах
            item.rare = 1; //редкость от -1 до 13
            item.UseSound = SoundID.Item1; //звук объекта
            item.autoReuse = true; //если зажата мышь то предмет работает непрерывно
            item.useTurn = true; //может ли персонаж обернуться во время работы
        }
        public override void AddRecipes()  //Крафт
        {
            ModRecipe recipe = new ModRecipe(mod); //запуск рецепта
            recipe.AddIngredient(mod, "lever", 2); //материал из которого будет крафтиться и количество
            recipe.AddIngredient(mod, "OdamireOre", 4);
            recipe.AddTile(TileID.Anvils);   //на чём будет крафтиться
            recipe.SetResult(this); //что мы получим в итоге 
            recipe.AddRecipe(); //завершение крафта
        }
    }
}