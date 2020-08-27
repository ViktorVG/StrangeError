//Created by KeysCG | ���������� �� �������� ��������: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items //�������� ������ ����
{
    public class OdamirePickaxe : ModItem //�������� ������ �������
    {
    
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odamire pickaxe"); //�������� ������� � ����
            Tooltip.SetDefault("A pickaxe that is slighty better than the original. With it, you will be able to mine ore faster!"); //�������� ������� � ����
        }

        public override void SetDefaults() //�������� �������
        {
            item.damage = 10; // �������� �����
            item.melee = true; //��� ������ "melee" - �������� ��� � �����
            item.width = 32; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.height = 32; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.useTime = 20; //???
            item.useAnimation = 20; //???
            item.pick = 55;    //���� �����
            item.useStyle = 1; //��� ������������� "1" - ��� ������������
            item.knockBack = 10; //���� ������������ "������������ �������� 20"
            item.value = 100021; //��������� � ������ �������
            item.rare = 1; //�������� �� -1 �� 13
            item.UseSound = SoundID.Item1; //���� �������
            item.autoReuse = true; //���� ������ ���� �� ������� �������� ����������
            item.useTurn = true; //����� �� �������� ���������� �� ����� ������
        }
        public override void AddRecipes()  //�����
        {
            ModRecipe recipe = new ModRecipe(mod); //������ �������
            recipe.AddIngredient(mod, "lever", 2); //�������� �� �������� ����� ���������� � ����������
            recipe.AddIngredient(mod, "OdamireOre", 4);
            recipe.AddTile(TileID.Anvils);   //�� ��� ����� ����������
            recipe.SetResult(this); //��� �� ������� � ����� 
            recipe.AddRecipe(); //���������� ������
        }
    }
}