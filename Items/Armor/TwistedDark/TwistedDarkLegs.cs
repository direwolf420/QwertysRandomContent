using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QwertysRandomContent.Items.Armor.TwistedDark
{
	
	[AutoloadEquip(EquipType.Legs)]
	public class TwistedDarkLegs : ModItem
	{
		
		
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Etimsic Robes");
            Tooltip.SetDefault("Morph damage increases the longer you're morphed. Max: 30%" + "\n");

        }
		

		public override void SetDefaults()
		{
			
			item.value = 90000;
			item.rare = 3;
			
			
			item.width = 22;
			item.height = 18;
			item.defense = 1;
            item.GetGlobalItem<ShapeShifterItem>().equipedMorphDefense = 7;



        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EtimsMaterial"), 9);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CloneNewInstances
        {
            get
            {
                return true;
            }
        }

        int bonus = 0;
        string end = "%  increased morph damage (not morphed)";
        float b = 0;
        public override void UpdateEquip(Player player)
        {
            end = "% increased morph damage (not morphed)";


            if (player.GetModPlayer<ShapeShifterPlayer>().morphTime > 0)
            {
                b += .125f;
                if (b > 30)
                {
                    b = 30;
                }
                end = "% morph critical strike chance";
            }
            else if (!player.GetModPlayer<ShapeShifterPlayer>().EyeBlessing)
            {
                b -= .125f;
                if (b < 0)
                {
                    b = 0;
                }
                end = "% morph critical strike chance (not morphed)";
            }
            bonus = (int)b;
           
            player.GetModPlayer<ShapeShifterPlayer>().morphDamage += bonus*.01f;
           

        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {

            foreach (TooltipLine line in tooltips) //runs through all tooltip lines
            {
                if (line.mod == "Terraria" && line.Name == "Tooltip1") //this checks if it's the line we're interested in
                {
                    line.text = "Current Bonus: " + bonus + end;//change tooltip
                }

            }
        }
        public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
        {
			
			if (male) equipSlot = mod.GetEquipSlot("TwistedDarkLegs_Legs", EquipType.Legs);
            if (!male) equipSlot = mod.GetEquipSlot("TwistedDarkLegs_FemaleLegs", EquipType.Legs);
			
		}

      







    }
   
    

}

