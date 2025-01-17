using Terraria.ModLoader;

namespace QwertysRandomContent.Items.HydraItems
{
	public class HydraTrophy : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 50000;
			item.createTile = mod.TileType("HydraTrophy");
			item.placeStyle = 0;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hydra Trophy");
			Tooltip.SetDefault("");
		}

	}
}
