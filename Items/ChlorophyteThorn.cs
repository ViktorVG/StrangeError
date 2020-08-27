//Created by KeysCG "www.youtube.com/keysrec"
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items //�������� ���� "NameMods"
{
    public class ChlorophyteThorn : ModItem //�������� ������� "NameScript"
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte thorn"); //�������� ������� � ����
            Tooltip.SetDefault("Warrior, are you ready to get a fast and powerful weapon?"); //�������� ������� � ����
        }

        public override void SetDefaults() //�������� �������
        {
            item.width = 20; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.height = 20; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.maxStack = 100; //������������ ���������� ���� � �����
            item.value = 50; //��������� � ������ ������� "100" - ��� 1 �������
            item.rare = 7; //�������� ������ �������
        }

        public override void AddRecipes() //�������� ������
        {
            ModRecipe recipe = new ModRecipe(mod); //����� ������
            recipe.AddIngredient(ItemID.ChlorophyteOre, 3); //����������� �� ������� ��������� ������ "DirtBlock" - ����� "10" - ����������
            recipe.AddTile(TileID.Anvils); //����� ��� ������ "WorkBenches" - �������
            recipe.SetResult(this, 3); //��� ������� ����� ������ "this" - ���� ������ "1" - ���������� ����
            recipe.AddRecipe();
        }
    }
}