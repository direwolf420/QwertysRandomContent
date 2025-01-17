using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QwertysRandomContent.Items.HydraItems
{
	
	public class HydraSummon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hydra Food");
			Tooltip.SetDefault("Summons The Hydra");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
        }

		public override void SetDefaults()
		{
			item.width = 54;
			item.height = 46;
			item.maxStack = 20;
			item.rare = 3;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		
		public override bool CanUseItem(Player player)
		{
			
			return !NPC.AnyNPCs(mod.NPCType("Hydra"));
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Hydra"));
			//NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Head1"));
			//NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Head2"));
			//NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Head3"));
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(520, 4);
			recipe.AddIngredient(521, 4);
			
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		
	}
}