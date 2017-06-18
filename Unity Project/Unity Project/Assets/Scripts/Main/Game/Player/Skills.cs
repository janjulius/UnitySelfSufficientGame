using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Main.Game.Player;
using UnityEngine;

public class Skills : MonoBehaviour
{
    private double maxExp = 200000000;

    private const int ATTACKING = 0,
        DEFENCING = 1,
        POWER = 2,
        HEALTH = 3,
        PRAYER = 4,
        RANGING = 5,
        MAGIC = 6,
        THIEVING = 7,
        CRAFTING = 8,
        FISHING = 9,
        WOODCUTTING = 10,
        FIREMAKING = 11,
        COOKING = 12,
        GARDENING = 13;

    private string[] skillName =
    {
        "Attacking", "Defencing", "Power", "Health", "Prayer", "Ranging", "Magic", "Thieving", "Crafting", "Fishing",
        "Woodcutting", "Firemaking", "Cooking", "Gardening"
    };

    private int[] level;
    private double[] xp;
    private byte[] trackSkillsIds;

    public void passLevels(Player p)
    {
        this.level = p.getSkills().level;
        this.xp = p.getSkills().xp;
    }

    public Skills()
    {
        level = new int[skillName.Length];
        xp = new double[skillName.Length];
        for (int i = 0; i < level.Length; i++)
        {
            level[i] = 1;
            xp[i] = 0;
        }
        level[3] = 10;
        xp[3] = 1184;
    }

    public int getLevel(int skill)
    {
        return level[skill];
    }

    public double getXp(int skill)
    {
        return xp[skill];
    }

    public int getCombatLevel()
    {
        int attack = getLevelForXp(0);
        int defence = getLevelForXp(1);
        int strength = getLevelForXp(2);
        int hp = getLevelForXp(3);
        int prayer = getLevelForXp(4);
        int ranged = getLevelForXp(5);
        int magic = getLevelForXp(6);
        int combatLevel = 3;
        combatLevel = (int)((defence + hp + Math.Floor((double)prayer / 2)) * 0.25) + 1;
        double melee = (attack + strength) * 0.325;
        double ranger = Math.Floor(ranged * 1.5) * 0.325;
        double mage = Math.Floor(magic * 1.5) * 0.325;
        if (melee >= ranger && melee >= mage)
        {
            combatLevel += (int)melee;
        }
        else if (ranger >= melee && ranger >= mage)
        {
            combatLevel += (int)ranger;
        }
        else if (mage >= melee && mage >= ranger)
        {
            combatLevel += (int)mage;
        }
        return combatLevel;
    }

    public int getLevelForXp(int skill)
    {
        double exp = xp[skill];
        double points = 0;
        double output = 0;
        //for (int lvl = 1; lvl <= (skill == DUNGEONEERING ? 120 : 99); lvl++)
        for(int lvl = 1; lvl <= 99; lvl++)
        {
            points += Math.Floor(lvl + 300.0
                                 * Math.Pow(2.0, lvl / 7.0));
            output = Math.Floor(points / 4);
            if ((output - 1) >= exp)
            {
                return lvl;
            }
        }
        return 99;
    }
}
