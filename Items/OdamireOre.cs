//Created by KeysCG "www.youtube.com/keysrec"
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items //�������� ���� "NameMods"
{
    public class OdamireOre : ModItem //�������� ������� "NameScript"
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odamire Ore"); //�������� ������� � ����
            Tooltip.SetDefault("The only ore from which you can make anything."); //�������� ������� � ����
        }

        public override void SetDefaults() //�������� �������
        {
            item.width = 20; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.height = 20; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.maxStack = 100; //������������ ���������� ���� � �����
            item.value = 100050; //��������� � ������ ������� "100" - ��� 1 �������
            item.rare = 2; //�������� ������ �������
        }

        public override void AddRecipes() //�������� ������
        {
            ModRecipe recipe = new ModRecipe(mod); //����� ������
            recipe.AddIngredient(ItemID.CopperOre, 1); //����������� �� ������� ��������� ������ "DirtBlock" - ����� "10" - ����������
            recipe.AddTile(TileID.WorkBenches); //����� ��� ������ "WorkBenches" - �������
            recipe.SetResult(this, 3); //��� ������� ����� ������ "this" - ���� ������ "1" - ���������� ����
            recipe.AddRecipe();
        }
    }
}