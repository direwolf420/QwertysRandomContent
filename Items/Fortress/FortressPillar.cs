using Terraria.ID;
using Terraria.ModLoader;

namespace QwertysRandomContent.Items.Fortress
{
	public class FortressPillar : ModItem
	{
       
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fortress Pillar");
			Tooltip.SetDefault("");
		}
		
		public override void SetDefaults()
		{

			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			
			item.rare = 3;
			item.createTile = mod.TileType("FortressPillar");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FortressBrick"));
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }


    }
}
