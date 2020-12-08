// Decompiled with JetBrains decompiler
// Type: DRaC_Business.Penthouse
// Assembly: DRaC_Business, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 46ED2638-FF60-4062-85B3-F169AC3C0185
// Assembly location: C:\Users\Ekinoxx\Desktop\DRaC_Business.dll

using GTA;
using GTA.Math;
using GTA.Native;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DRaC_Business
{
  internal class Penthouse : Script
  {
    public List<Vector3> WordrobePositions;
    public List<Vector3> SHowerPositions;
    public UIMenu All;
    public UIMenu WoredrobeMainMenu;
    public UIMenu WoredrobeMenu;
    public int CompMax;
    public int DrawableMax;
    public bool InShower;
    public bool sitting;
    private ScriptSettings Config;
    public WeaponTint Liv;
    public int ID_O;
    public string ID_C;
    public int Comp;
    public Model OldCharacter;
    public string HostName;
    public BlipColor Blip_Colour;
    public string Uicolour;
    public Color MarkerColor;
    public string MarkerColorString;
    public int Casino_level;
    private ScriptSettings ScriptConfig;
    public bool IsScriptEnabled;
    public List<Vector3> SeatPos;
    public List<float> SeatRot;
    private Keys Key1;
    private UIMenu weaponsMenu;
    public Vector3 GunLockerMarker;
    public int GunLockerBought;
    private UIMenu MK2Pumpshotgun;
    private UIMenu MK2SNSPistol;
    private UIMenu MK2Revolver;
    private UIMenu Mk2SpecialCarbine;
    private UIMenu MK2Bullpup;
    private UIMenu MK2MarksmanRifle;
    private UIMenu MK2Pistol;
    private UIMenu MK2SMG;
    private UIMenu MK2LMG;
    private UIMenu MK2Carbine;
    private UIMenu MK2AssaultRifle;
    private UIMenu MK2Sniper;
    private MenuPool modMenuPool;
    private UIMenu mainMenu;
    public int Tintscount;
    private Keys Key3;
    private UIMenu MmainMenu;
    public int MoneyVaultBought;
    public float MoneyStored;
    public float Commission;
    public UIMenu MoneyMenu;
    public Vector3 MoneyStorageMarker;
    public int currentbank;
    public bool read;
    public Blip Range;
    public Blip Range2;
    public Prop GunBase;
    public List<Prop> GunComp;
    public int Positions;

    public void ReReadIni() => this.LoadIniFile("scripts//DC&R//Casino.ini");

    public Penthouse()
    {
      base.\u002Ector();
      this.CheckForScriptEnabled("scripts//DisableBusinesses.ini");
      if (!this.IsScriptEnabled)
        return;
      this.add_Tick(new EventHandler(this.OnTick));
      this.set_Interval(1);
      this.Setup();
    }

    public string GetHostName() => "~" + this.Uicolour + "~ " + this.HostName + "~w~ ";

    private void CheckForScriptEnabled(string iniName)
    {
      try
      {
        this.ScriptConfig = ScriptSettings.Load(iniName);
        this.IsScriptEnabled = (bool) this.ScriptConfig.GetValue<bool>("Diamond Resort & Casino DLC", "Diamond Resort & Casino", (M0) (this.IsScriptEnabled ? 1 : 0));
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: Config.ini Failed To Load.");
      }
    }

    public void Setup()
    {
      this.SeatPos.Add(new Vector3(960.0099f, 42.7899f, 114.8f));
      this.SeatRot.Add(-36f);
      this.SeatPos.Add(new Vector3(961.0356f, 48.80322f, 114.8f));
      this.SeatRot.Add(-125f);
      this.SeatPos.Add(new Vector3(964.3204f, 51.48433f, 114.8f));
      this.SeatRot.Add(136f);
      this.SeatPos.Add(new Vector3(968.1276f, 70.33726f, 114.8f));
      this.SeatRot.Add(-32f);
      this.SeatPos.Add(new Vector3(965.5015f, 73.36767f, 114.8f));
      this.SeatRot.Add(-123f);
      this.SeatPos.Add(new Vector3(973.2695f, 82.62019f, 114.8f));
      this.SeatRot.Add(147f);
      this.SeatPos.Add(new Vector3(947.4011f, 23.77968f, 114.8f));
      this.SeatRot.Add(-38f);
      this.SeatPos.Add(new Vector3(950.9106f, 18.32446f, 114.8f));
      this.SeatRot.Add(32f);
      this.SeatPos.Add(new Vector3(953.0781f, 19.32988f, 114.8f));
      this.SeatRot.Add(-3f);
      this.SeatPos.Add(new Vector3(955.3398f, 18.84087f, 114.8f));
      this.SeatRot.Add(-20f);
      this.SeatPos.Add(new Vector3(940.7246f, 1.32643f, 114.8f));
      this.SeatRot.Add(68f);
      this.SeatPos.Add(new Vector3(942.3015f, 1.3715f, 114.8f));
      this.SeatRot.Add(-113f);
      this.SeatPos.Add(new Vector3(943.754f, -1.332707f, 114.8f));
      this.SeatRot.Add(-12f);
      this.SeatPos.Add(new Vector3(947.7684f, -0.6601002f, 114.8f));
      this.SeatRot.Add(29f);
      this.LoadIniFile("scripts//DC&R//Casino.ini");
      this.WordrobePositions.Add(new Vector3(975.0374f, 64.997f, 115f));
      this.WordrobePositions.Add(new Vector3(977.4243f, 78.65495f, 115f));
      this.WordrobePositions.Add(new Vector3(959.9096f, 23.66869f, 115f));
      this.WordrobePositions.Add(new Vector3(984.4489f, 60.29456f, 115f));
      this.SHowerPositions.Add(new Vector3(979.4085f, 72.11459f, 115f));
      this.SHowerPositions.Add(new Vector3(981.0888f, 71.34532f, 115f));
      this.GunLockerMarker = new Vector3(972.0834f, 40.92828f, 115f);
      this.modMenuPool = new MenuPool();
      this.All = new UIMenu("Select an Option", "Select an Option");
      this.modMenuPool.Add(this.All);
      this.mainMenu = new UIMenu("Gunlocker", "Select an Option");
      this.modMenuPool.Add(this.mainMenu);
      this.weaponsMenu = this.modMenuPool.AddSubMenu(this.All, "Weapons");
      this.WoredrobeMainMenu = new UIMenu("Wardrobe", "Select an Option");
      this.modMenuPool.Add(this.WoredrobeMainMenu);
      this.WoredrobeMenu = this.modMenuPool.AddSubMenu(this.All, "Change Clothes");
      this.currentbank = 1;
      this.MmainMenu = new UIMenu("DC&R", "Select an Option");
      this.modMenuPool.Add(this.MmainMenu);
      this.MoneyMenu = this.modMenuPool.AddSubMenu(this.All, "Money Options");
      this.SetupMoneyMenu();
      this.SetupWeapons();
      this.WareDrobe();
      this.setupMarker();
    }

    private void SetupWeapons()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Penthouse.\u003C\u003Ec__DisplayClass49_0 cDisplayClass490 = new Penthouse.\u003C\u003Ec__DisplayClass49_0();
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "Classic Black");
      objectList1.Add((object) "Classic Gray");
      objectList1.Add((object) "Classic Two-Tone");
      objectList1.Add((object) "Classic White");
      objectList1.Add((object) "Classic Beige");
      objectList1.Add((object) "Classic Green");
      objectList1.Add((object) "Classic Blue");
      objectList1.Add((object) "Classic Earth");
      objectList1.Add((object) "Classic Brown & Black");
      objectList1.Add((object) "Red Contrast");
      objectList1.Add((object) "Blue Contrast");
      objectList1.Add((object) "Yellow Contrast");
      objectList1.Add((object) "Orange Contrast");
      objectList1.Add((object) "Bold Pink");
      objectList1.Add((object) "Bold Purple & Yellow");
      objectList1.Add((object) "Bold Orange");
      objectList1.Add((object) "Bold Green & Purple");
      objectList1.Add((object) "Bold Red & Black");
      objectList1.Add((object) "Bold Green & Black");
      objectList1.Add((object) "Bold Cyan & Black");
      objectList1.Add((object) "Bold Yellow & Black");
      objectList1.Add((object) "Bold Red & White");
      objectList1.Add((object) "Bold Blue & White");
      objectList1.Add((object) "Metallic Gold");
      objectList1.Add((object) "Metallic Platinum");
      objectList1.Add((object) "Metallic Gray & Lilac");
      objectList1.Add((object) "Metallic Purple & Lime");
      objectList1.Add((object) "Metallic Red");
      objectList1.Add((object) "Metallic Green");
      objectList1.Add((object) "Metallic Blue");
      objectList1.Add((object) "Metallic White & Aqua");
      objectList1.Add((object) "Metallic Red & Yellow");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.CPrice = 34000f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons = new List<object>();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) 961495388);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) -2066285827);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) -86904375);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) -608341376);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) 177293209);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) 1785463520);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) -1075685676);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) 1432025498);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) -879347409);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) 2024373456);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) -2009644972);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Mk2Weapons.Add((object) (WeaponHash) -1768145561);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Components = new List<object>();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Components.Add((object) (WeaponComponent) -1101075946);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Components.Add((object) (WeaponComponent) -1323216997);
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Mk2 Weapons (Advanced)");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.W = new UIMenuListItem("Weapon : ", cDisplayClass490.Mk2Weapons, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) cDisplayClass490.W);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.C = new UIMenuListItem("Component  : ", cDisplayClass490.Components, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) cDisplayClass490.C);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Enable = new UIMenuItem("Enable Component : $" + cDisplayClass490.CPrice.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(cDisplayClass490.Enable);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.DIsable = new UIMenuItem("Disable Component");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(cDisplayClass490.DIsable);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.WT = new UIMenuListItem("Tint ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) cDisplayClass490.WT);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTintAV = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(cDisplayClass490.getTintAV);
      // ISSUE: method pointer
      uiMenu1.add_OnListChange(new ListChangedEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__1)));
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Scifi Weapons");
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Mk2 Weapons");
      UIMenu uiMenu4 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Normal Weapons");
      List<object> objectList2 = new List<object>();
      for (int index = 0; index < this.Tintscount; ++index)
        objectList2.Add((object) index);
      this.MK2Pumpshotgun = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Pump Shotgun");
      this.MK2SNSPistol = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 SNS Pistol");
      this.MK2Revolver = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Revolver");
      this.Mk2SpecialCarbine = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Special Carbine");
      this.MK2Bullpup = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Bullpup Rifle");
      this.MK2MarksmanRifle = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Marksmans Rifle");
      this.MK2Pistol = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Pistol");
      this.MK2SMG = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 SMG");
      this.MK2LMG = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 LMG");
      this.MK2Carbine = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Carbine");
      this.MK2AssaultRifle = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Assault Rifle");
      this.MK2Sniper = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Sniper");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ShotgunP = new UIMenuItem("MK2 Pump Shotgun: $75,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2ShotgunP);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunclip = new UIMenuItem("Normal Shells : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunclip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunclip1 = new UIMenuItem("Dragon's Breath Shells : $65,200");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunclip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunclip3 = new UIMenuItem("Flechette Shells: $75,140");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunclip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunclip2 = new UIMenuItem("Steel Buckshot Shells: $96,645");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunclip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunclip4 = new UIMenuItem("Explosive Shells: $145,850");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunclip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunsights = new UIMenuItem("Holographic Sight: $29,260");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunsights);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunsights2 = new UIMenuItem("Small Scope: $39,920");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunsights2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunsights3 = new UIMenuItem("Medium Scope: $50,785");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunsights3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunflashlight = new UIMenuItem("Flashlight: $10,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunflashlight);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ShotgunSuppressor = new UIMenuItem("Suppressor: $45,860");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2ShotgunSuppressor);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Shotgunmuzzle = new UIMenuItem("Muzzle Brake: $37,650");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.mk2Shotgunmuzzle);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list1 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem((UIMenuItem) cDisplayClass490.list1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint1 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(cDisplayClass490.getTint1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistol = new UIMenuItem("MK2 SNS Pistol: $35,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistol);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolclipn = new UIMenuItem("Default Clip: $8,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolclipn);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolclipe = new UIMenuItem("Extended Clip: $18,300");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolclipe);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolclip1 = new UIMenuItem("Tracer Rounds: $34,320");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolclip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolclip2 = new UIMenuItem("Incendiary Rounds: $41,700");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolclip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolclip3 = new UIMenuItem("Hollow Point Rounds : $47,580");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolclip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolclip4 = new UIMenuItem("Full Metal Jacket Rounds: $62,400");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolclip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolflash = new UIMenuItem("Flashlight: $7,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolflash);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolscope1 = new UIMenuItem("Mounted Scope: $16,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolscope1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolsuppressor = new UIMenuItem("Suppressor: $28,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolsuppressor);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Snspistolcomp = new UIMenuItem("Compensator: $21,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.mk2Snspistolcomp);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list2 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem((UIMenuItem) cDisplayClass490.list2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint2 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(cDisplayClass490.getTint2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolver = new UIMenuItem("MK2 Revolver: $35,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolver);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolverclip = new UIMenuItem("Normal Rounds: $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolverclip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolverclip1 = new UIMenuItem("Tracer Rounds: $31,460");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolverclip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolverclip2 = new UIMenuItem("Incendiary Rounds: $38,225");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolverclip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolverclip3 = new UIMenuItem("Hollow Point Rounds: $43,615");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolverclip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolverclip4 = new UIMenuItem("Full Metal Jacket Rounds: $57,200");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolverclip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolversights = new UIMenuItem("Holographic Sight: $16,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolversights);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolversights1 = new UIMenuItem("Small Scope: $25,450");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolversights1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Revolverflashlight = new UIMenuItem("Flashlight: $7,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2Revolverflashlight);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2RevolverComp = new UIMenuItem("Compensator: $21,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.mk2RevolverComp);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list3 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem((UIMenuItem) cDisplayClass490.list3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint3 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(cDisplayClass490.getTint3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbine = new UIMenuItem("MK2 Special Carbine: $65,000");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbine);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbineclip = new UIMenuItem("Default Clip: $5,000");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbineclip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbineclip1 = new UIMenuItem("Extended Clip: $26,450");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbineclip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbineclip2 = new UIMenuItem("Tracer Rounds: $61,465");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbineclip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbineclip3 = new UIMenuItem("Incendiary Rounds : $70,950");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbineclip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbineclip4 = new UIMenuItem("Armor Piercing Rounds : $90,750");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbineclip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbineclip5 = new UIMenuItem("Full Metal Jacket Rounds : $104,775");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbineclip5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbineflash = new UIMenuItem("Flashlight: $10,500");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbineflash);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbinesight1 = new UIMenuItem("Holographic Sight: $19,600");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbinesight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbinesight2 = new UIMenuItem("Small Scope: $23,730");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbinesight2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbinesight3 = new UIMenuItem("Large Scope: $34,020");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbinesight3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbinesupressor = new UIMenuItem("Suppressor : $40,250");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbinesupressor);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbinemuzzle = new UIMenuItem("Muzzle : $29,750");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbinemuzzle);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2SCarbinegrip = new UIMenuItem("Grip : $14,080");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.mk2SCarbinegrip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list4 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem((UIMenuItem) cDisplayClass490.list4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint4 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(cDisplayClass490.getTint4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpup = new UIMenuItem("MK2 Bullpup Rifle: $60,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpup);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupclip1 = new UIMenuItem("Default Clip : $5,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupclip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupclip2 = new UIMenuItem("Extended Clip : $22,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupclip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupclip3 = new UIMenuItem("Tracer Rounds : $44,350");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupclip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupclip4 = new UIMenuItem("Incendiary Rounds : $52,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupclip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupclip5 = new UIMenuItem("Armor Piercing Rounds  : $87,320");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupclip5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupclip6 = new UIMenuItem("Full Metal Jacket Rounds : $77,490");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupclip6);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupflash = new UIMenuItem("Flashlight  : $10,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupflash);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupsight1 = new UIMenuItem("Holographic Sight : $19,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupsight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupsight2 = new UIMenuItem("Small Scope : $23,730");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupsight2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupsight3 = new UIMenuItem("Medium Scope : $34,020");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupsight3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2BullpupBarrel = new UIMenuItem("Heavy Barrel : $49,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2BullpupBarrel);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2BullpupGrip = new UIMenuItem("Grip : $14,080");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2BullpupGrip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2Bullpupmuzzle = new UIMenuItem("Muzzle  : $29,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2Bullpupmuzzle);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2BullpupSuppressor = new UIMenuItem("Suppressor  : $40,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.mk2BullpupSuppressor);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list5 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem((UIMenuItem) cDisplayClass490.list5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint5 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(cDisplayClass490.getTint5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksman = new UIMenuItem("MK2 Marksman Rifle : $80,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksman);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanclip1 = new UIMenuItem("Default Clip : $5,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanclip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanclip2 = new UIMenuItem("Extended Clip : $26,850");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanclip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanclip3 = new UIMenuItem("Tracer Rounds : $49,775");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanclip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanclip4 = new UIMenuItem("Incendiary Rounds : $57,295");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanclip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanclip5 = new UIMenuItem("Armor Piercing Rounds  : $73,560");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanclip5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanclip6 = new UIMenuItem("Full Metal Jacket Rounds : $85,570");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanclip6);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanflash = new UIMenuItem("Flashlight  : $11,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanflash);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmansight1 = new UIMenuItem("Holographic Sight  : $11,485");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmansight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmansight2 = new UIMenuItem("Large Scope  : $17,870");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmansight2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmansight3 = new UIMenuItem("Zoom Scope  : $27,150");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmansight3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanGrip = new UIMenuItem("Grip  : $14,080");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanGrip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanmuzzle = new UIMenuItem("Muzzle  : $44,620");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanmuzzle);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2marksmanSuppressor = new UIMenuItem("Suppressor  : $60,375");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.mk2marksmanSuppressor);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list6 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem((UIMenuItem) cDisplayClass490.list6);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint6 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(cDisplayClass490.getTint6);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistol = new UIMenuItem("MK2 Pistol : $20,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistol);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolClip = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolClip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolClip1 = new UIMenuItem("Extended Clip : $15,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolClip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolClip2 = new UIMenuItem("Tracer Rounds : $32,850");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolClip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolClip3 = new UIMenuItem("Incendiary Rounds : $34,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolClip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolClip4 = new UIMenuItem("Hollow Point Rounds : $39,650");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolClip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolClip5 = new UIMenuItem("Full Metal Jacket Rounds  : $52,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolClip5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolSight1 = new UIMenuItem("Mounted Scope : $16,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolSight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolflash = new UIMenuItem("Flashlight : $7,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolflash);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolsupp = new UIMenuItem("Suppressor : $28,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolsupp);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2pistolcomp = new UIMenuItem("Compensator : $21,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.mk2pistolcomp);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list7 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem((UIMenuItem) cDisplayClass490.list7);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint7 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(cDisplayClass490.getTint7);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smg = new UIMenuItem("MK2 SMG : $25,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smg);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgclip = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgclip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgclip1 = new UIMenuItem("Extended Clip : $18,300");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgclip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgClip2 = new UIMenuItem("Tracer Rounds : $28,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgClip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgClip3 = new UIMenuItem("Incendiary Rounds : $34,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgClip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgClip4 = new UIMenuItem("Hollow Point Rounds : $39,650");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgClip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgClip5 = new UIMenuItem("Full Metal Jacket Rounds  : $52,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgClip5);
      this.MK2SMG.AddItem(new UIMenuItem("Flashlight : $7,500"));
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgsight1 = new UIMenuItem("Holographic Sight : $15,200");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgsight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgsight2 = new UIMenuItem("Small Scope: $19,950");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgsight2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgsight3 = new UIMenuItem("Holographic Sight : $24,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgsight3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgsupp = new UIMenuItem("Suppressor  : $34,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgsupp);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgmuzzle = new UIMenuItem("Muzzle : $25,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgmuzzle);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2smgbarrel = new UIMenuItem("Barrel : $22,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.mk2smgbarrel);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list8 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem((UIMenuItem) cDisplayClass490.list8);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint8 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(cDisplayClass490.getTint8);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbine = new UIMenuItem("MK2 Carbine : $35,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbine);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineClip1 = new UIMenuItem("Default Clip: $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineClip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineClip2 = new UIMenuItem("Extended Clip: $25,925");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineClip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineClip3 = new UIMenuItem("Tracer Rounds: $44,700");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineClip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineClip4 = new UIMenuItem("Incendiary Rounds : $51,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineClip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineClip5 = new UIMenuItem("Armor Piercing Rounds: $66,000 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineClip5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineClip6 = new UIMenuItem("Full Metal Jacket Rounds: $76,200 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineClip6);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineGrip = new UIMenuItem("Grip: $14,080 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineGrip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineFlash = new UIMenuItem("Flashlight: $10,500 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineFlash);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineSight1 = new UIMenuItem("Holographic Sight: $19,600  ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineSight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineSight2 = new UIMenuItem("Small Scope: $23,730 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineSight2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineSight3 = new UIMenuItem("Large Scope: $34,020 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineSight3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2carbineSupp = new UIMenuItem("Suppressor: $40,250 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.mk2carbineSupp);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list9 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem((UIMenuItem) cDisplayClass490.list9);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint9 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(cDisplayClass490.getTint9);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2AR = new UIMenuItem("MK2 Assault Rifle : $30,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2AR);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClip1 = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClip2 = new UIMenuItem("Extended Clip: $22,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClip3 = new UIMenuItem("Tracer Rounds  : $42,700");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClip4 = new UIMenuItem("Incendiary Rounds  : $49,400");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClip5 = new UIMenuItem("Armor Piercing Rounds : $63,200");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClip5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClip6 = new UIMenuItem("Full Metal Jacket Rounds  : $73,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClip6);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClipFlash = new UIMenuItem("Flashlight : $10,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClipFlash);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClipSight1 = new UIMenuItem("Holographic Sight : $19,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClipSight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClipSight2 = new UIMenuItem("Small Scope : $23,730");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClipSight2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClipSight3 = new UIMenuItem("Large Scope : $33,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClipSight3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARClipGrip = new UIMenuItem("Grip : $14,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARClipGrip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2ARsuppressor = new UIMenuItem("Suppressor : $40,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.mk2ARsuppressor);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list10 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem((UIMenuItem) cDisplayClass490.list10);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint10 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(cDisplayClass490.getTint10);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmg = new UIMenuItem("MK2 LMG : $95,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmg);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgClip1 = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgClip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgClip2 = new UIMenuItem("Extended Clip : $28,975");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgClip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgClip3 = new UIMenuItem("Tracer Rounds : $57,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgClip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgClip4 = new UIMenuItem("Incendiary Rounds : $64,650");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgClip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgClip5 = new UIMenuItem("Armor Piercing Rounds : $82,550");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgClip5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgClip6 = new UIMenuItem("Full Metal Jacket Rounds  : $94,950");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgClip6);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgGrip = new UIMenuItem("Grip : $20,180");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgGrip);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgSight1 = new UIMenuItem("Holographic Sight : $26,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgSight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgSight2 = new UIMenuItem("Small Scope : $36,290");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgSight2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgSight3 = new UIMenuItem("Large Scope : $46,170");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgSight3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgMuzzle = new UIMenuItem("Flat Muzzle Brake : $40,375");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgMuzzle);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2lmgBarrel = new UIMenuItem("Heavy Barrel : $66,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.mk2lmgBarrel);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list11 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem((UIMenuItem) cDisplayClass490.list11);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint11 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(cDisplayClass490.getTint11);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniper = new UIMenuItem("MK2 Heavy Sniper : $100,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniper);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperClip1 = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperClip1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperClip2 = new UIMenuItem("Extended Clip : $35,025");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperClip2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperClip3 = new UIMenuItem("Incendiary Rounds : $59,275");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperClip3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperClip4 = new UIMenuItem("Armor Piercing Rounds : $76,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperClip4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperClip5 = new UIMenuItem("Full Metal Jacket Rounds : $88,525");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperClip5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperClip6 = new UIMenuItem("Explosive Rounds : $115,450");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperClip6);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperSight1 = new UIMenuItem("Zoom scope : $20.200");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperSight1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperSight2 = new UIMenuItem("Advanced Scope : $32,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperSight2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperSight3 = new UIMenuItem("Night Vision Scope : $57,400");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperSight3);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperSight4 = new UIMenuItem("Thermal Scope : $69,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperSight4);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperSupp = new UIMenuItem("Suppressor : $40,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperSupp);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperMuzzle = new UIMenuItem("Bell-End Muzzle Brake : $57,790");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperMuzzle);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.mk2sniperBarrel = new UIMenuItem("Heavy Barrel : $27,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.mk2sniperBarrel);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list12 = new UIMenuListItem("Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem((UIMenuItem) cDisplayClass490.list12);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getTint12 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(cDisplayClass490.getTint12);
      List<object> objectList3 = new List<object>();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.allweaponhashes = (WeaponHash[]) Enum.GetValues(typeof (WeaponHash));
      // ISSUE: reference to a compiler-generated field
      for (int index = 0; index < cDisplayClass490.allweaponhashes.Length; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        objectList3.Add((object) (WeaponHash) (int) (uint) cDisplayClass490.allweaponhashes[index]);
      }
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.list = new UIMenuListItem("Weapon: ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem((UIMenuItem) cDisplayClass490.list);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.getWeapon = new UIMenuItem("Buy Weapon : $10000");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(cDisplayClass490.getWeapon);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.RayGun = new UIMenuItem("Ray Gun : $100,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(cDisplayClass490.RayGun);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.UnholyHellbringer = new UIMenuItem("UnholyHellbringer : $250,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(cDisplayClass490.UnholyHellbringer);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass490.Widowmaker = new UIMenuItem("Widowmaker : $1,000,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(cDisplayClass490.Widowmaker);
      // ISSUE: method pointer
      uiMenu4.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__3)));
      // ISSUE: method pointer
      this.MK2Sniper.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__4)));
      // ISSUE: method pointer
      this.MK2LMG.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__5)));
      // ISSUE: method pointer
      this.MK2Carbine.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__6)));
      // ISSUE: method pointer
      this.MK2SMG.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__7)));
      // ISSUE: method pointer
      this.MK2AssaultRifle.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__8)));
      // ISSUE: method pointer
      this.MK2Pistol.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__9)));
      // ISSUE: method pointer
      this.MK2Pumpshotgun.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__10)));
      // ISSUE: method pointer
      this.MK2SNSPistol.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__11)));
      // ISSUE: method pointer
      this.MK2Revolver.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__12)));
      // ISSUE: method pointer
      this.Mk2SpecialCarbine.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__13)));
      // ISSUE: method pointer
      this.MK2Bullpup.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__14)));
      // ISSUE: method pointer
      this.MK2MarksmanRifle.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass490, __methodptr(\u003CSetupWeapons\u003Eb__15)));
    }

    public void setupMarker()
    {
      this.Range = World.CreateBlip(this.MoneyStorageMarker);
      this.Range.set_Sprite((BlipSprite) 108);
      this.Range.set_Color(this.Blip_Colour);
      this.Range.set_Name("DC&R Money Vault");
      this.Range.set_IsShortRange(true);
      this.Range2 = World.CreateBlip(this.GunLockerMarker);
      this.Range2.set_Sprite((BlipSprite) 549);
      this.Range2.set_Color(this.Blip_Colour);
      this.Range2.set_Name("DC&R Gunlocker");
      this.Range2.set_IsShortRange(true);
    }

    public void DeleteMarker()
    {
      if (Blip.op_Inequality(this.Range2, (Blip) null))
        this.Range2.Remove();
      if (!Blip.op_Inequality(this.Range, (Blip) null))
        return;
      this.Range.Remove();
    }

    public void SetupMoneyMenu()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Penthouse.\u003C\u003Ec__DisplayClass65_0 cDisplayClass650 = new Penthouse.\u003C\u003Ec__DisplayClass65_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass650.\u003C\u003E4__this = this;
      List<object> objectList = new List<object>();
      objectList.Add((object) "1");
      objectList.Add((object) "2");
      objectList.Add((object) "3");
      objectList.Add((object) "4");
      objectList.Add((object) "5");
      objectList.Add((object) "6");
      objectList.Add((object) "7");
      objectList.Add((object) "8");
      objectList.Add((object) "9");
      objectList.Add((object) "10");
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.MoneyMenu, "Money Options");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass650.list5 = new UIMenuListItem("Vault: ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass650.list5);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass650.GetColor2 = new UIMenuItem("Change Bank Vault Number");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(cDisplayClass650.GetColor2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass650.WithDraw = new UIMenuItem("Withdraw");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(cDisplayClass650.WithDraw);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass650.Deposit2 = new UIMenuItem("Deposit");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(cDisplayClass650.Deposit2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass650.balance = new UIMenuItem("Show Balance");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(cDisplayClass650.balance);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass650, __methodptr(\u003CSetupMoneyMenu\u003Eb__0)));
    }

    private void Deposit()
    {
      string userInput = Game.GetUserInput(12);
      if (!(userInput != ""))
        return;
      if (int.Parse(userInput) <= Game.get_Player().get_Money())
      {
        this.MoneyStored = (float) int.Parse(userInput);
        Player player = Game.get_Player();
        player.set_Money(player.get_Money() - int.Parse(userInput));
        this.Config.SetValue<float>("ADDON2", "MONEYSTORED[" + (object) this.currentbank + "]", (M0) ((double) this.MoneyStored + (double) (float) this.Config.GetValue<float>("ADDON2", "MONEYSTORED[" + (object) this.currentbank + "]", (M0) (double) this.MoneyStored)));
        this.Config.Save();
      }
      else
        UI.Notify("Lester : boss you dont have that amount of money to deposit: value: " + (object) int.Parse(userInput));
    }

    private void Withdrawl()
    {
      string userInput = Game.GetUserInput(12);
      if (!(userInput != ""))
        return;
      if ((double) int.Parse(userInput) <= (double) this.MoneyStored)
      {
        this.MoneyStored = (float) this.Config.GetValue<float>("ADDON2", "MONEYSTORED[" + (object) this.currentbank + "]", (M0) (double) this.MoneyStored) - (float) int.Parse(userInput);
        Player player = Game.get_Player();
        player.set_Money(player.get_Money() + int.Parse(userInput));
        this.Config.SetValue<float>("ADDON2", "MONEYSTORED[" + (object) this.currentbank + "]", (M0) (double) this.MoneyStored);
        this.Config.Save();
      }
      else
        UI.Notify("Lester : boss you dont have that amount of money stored to withdraw, value: " + (object) this.MoneyStored);
    }

    private void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.HostName = (string) this.Config.GetValue<string>("Misc", "HostName", (M0) this.HostName);
        this.Blip_Colour = (BlipColor) this.Config.GetValue<BlipColor>("Misc", "Blip_Colour", (M0) this.Blip_Colour);
        this.Uicolour = (string) this.Config.GetValue<string>("Misc", "Uicolour", (M0) this.Uicolour);
        this.MarkerColorString = (string) this.Config.GetValue<string>("Misc", "MarkerColor", (M0) this.MarkerColorString);
        this.MarkerColor = Color.FromName(this.MarkerColorString);
        this.Casino_level = (int) this.Config.GetValue<int>("Setup", "Casinoi_Upgrade_Level", (M0) this.Casino_level);
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~:Casino.ini Failed To Load.");
      }
    }

    protected virtual void Dispose(bool A_0)
    {
      if (!A_0)
        return;
      if (Entity.op_Inequality((Entity) this.GunBase, (Entity) null))
        ((Entity) this.GunBase).Delete();
      using (List<Prop>.Enumerator enumerator = this.GunComp.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Blip.op_Inequality(this.Range, (Blip) null))
        this.Range.Remove();
      if (Blip.op_Inequality(this.Range2, (Blip) null))
        this.Range2.Remove();
      if (Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) 1885233650)) && Model.op_Inequality(this.OldCharacter, Model.op_Implicit((string) null)))
      {
        Model model;
        ((Model) ref model).\u002Ector(((Model) ref this.OldCharacter).get_Hash());
        ((Model) ref model).Request(500);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(100);
          Function.Call((Hash) 45540521788082230L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Game.get_Player()),
            InputArgument.op_Implicit(((Model) ref model).get_Hash())
          });
          Function.Call((Hash) 5039218013098765667L, new InputArgument[1]
          {
            InputArgument.op_Implicit(((Entity) Game.get_Player().get_Character()).get_Handle())
          });
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
        Game.get_Player().set_MaxArmor(400);
        Game.get_Player().get_Character().set_Armor(0);
        ((Entity) Game.get_Player().get_Character()).set_Health(200);
        ((Entity) Game.get_Player().get_Character()).set_MaxHealth(200);
      }
    }

    public void WareDrobe()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Penthouse.\u003C\u003Ec__DisplayClass70_0 cDisplayClass700 = new Penthouse.\u003C\u003Ec__DisplayClass70_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "Save");
      objectList1.Add((object) "Load");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots = new List<object>();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot1.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot2.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot3.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot4.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot5.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot6.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot7.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot8.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot9.ini");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Slots.Add((object) "Slot10.ini");
      List<object> objectList2 = new List<object>()
      {
        (object) (WeaponHash) -1569615261,
        (object) (WeaponHash) -1716189206,
        (object) (WeaponHash) 1737195953,
        (object) (WeaponHash) 1317494643,
        (object) (WeaponHash) -102973651,
        (object) (WeaponHash) -656458692,
        (object) (WeaponHash) -581044007,
        (object) (WeaponHash) -1810795771,
        (object) (WeaponHash) 419712736,
        (object) (WeaponHash) -538741184,
        (object) (WeaponHash) 1141786504,
        (object) (WeaponHash) -1951375401
      };
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours = new List<object>();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "Outfit Default");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "Blue");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "Green");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "Red");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "Orange");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "Pink");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "Purple");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "White");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Colours.Add((object) "Black");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits = new List<object>();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Soldier");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Cloaker");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Hacker");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Juggernaut");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Arena War A");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Arena War B");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Space Marine");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Commando");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Space Suit");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Outfits.Add((object) "Tron");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Draw = new List<object>();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Tex = new List<object>();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Draw.Add((object) 0);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Draw.Add((object) 1);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Tex.Add((object) 0);
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) " 0 FACE");
      objectList3.Add((object) "1 BEARD");
      objectList3.Add((object) "2 HAIRCUT");
      objectList3.Add((object) "3 SHIRT");
      objectList3.Add((object) "4 PANTS");
      objectList3.Add((object) "5 Hands / Gloves");
      objectList3.Add((object) "6 SHOES");
      objectList3.Add((object) "7 Eyes");
      objectList3.Add((object) "8 Accessories");
      objectList3.Add((object) "9 Mission Items/ Tasks");
      objectList3.Add((object) "10 Decals");
      objectList3.Add((object) "11 Collars and Inner Shirts");
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.WoredrobeMenu, "Change Outfit");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.O = new UIMenuListItem("", cDisplayClass700.Outfits, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) cDisplayClass700.O);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) cDisplayClass700.O).set_Description("While Using this outfit you will not be able to purchase anything due to being the MP male");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.C = new UIMenuListItem("Color : ", cDisplayClass700.Colours, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) cDisplayClass700.C);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) cDisplayClass700.C).set_Description("Use this Colour Whenever possible or use Default");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Set = new UIMenuItem("Wear Outfit ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(cDisplayClass700.Set);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Set.set_Description("~y~ Warning ~w~ Lag is normal while applying outfits, simple alt tab out to avoid crash");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Remove = new UIMenuItem("Remove Outift ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(cDisplayClass700.Remove);
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.WoredrobeMenu, "Change Clothes");
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(this.WoredrobeMenu, "Save/Load Outfit");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.SVL = new UIMenuListItem("Function ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) cDisplayClass700.SVL);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Sl = new UIMenuListItem("Slot ", cDisplayClass700.Slots, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) cDisplayClass700.Sl);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Get = new UIMenuItem("Save");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(cDisplayClass700.Get);
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass700, __methodptr(\u003CWareDrobe\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu3.add_OnListChange(new ListChangedEvent((object) cDisplayClass700, __methodptr(\u003CWareDrobe\u003Eb__1)));
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Comp1 = new UIMenuListItem("", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) cDisplayClass700.Comp1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Drawable = new UIMenuListItem("Item : ", cDisplayClass700.Draw, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) cDisplayClass700.Drawable);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass700.Texture = new UIMenuListItem("Texture : ", cDisplayClass700.Tex, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) cDisplayClass700.Texture);
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass700, __methodptr(\u003CWareDrobe\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu1.add_OnListChange(new ListChangedEvent((object) cDisplayClass700, __methodptr(\u003CWareDrobe\u003Eb__3)));
      // ISSUE: method pointer
      uiMenu2.add_OnListChange(new ListChangedEvent((object) cDisplayClass700, __methodptr(\u003CWareDrobe\u003Eb__4)));
    }

    public int CheckClothes(int T, int RComp, int RDraw)
    {
      int num = 0;
      if (T == 1)
      {
        if ((bool) Function.Call<bool>((Hash) -1718696417760418019L, new InputArgument[3]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character()),
          InputArgument.op_Implicit(RComp),
          InputArgument.op_Implicit(RDraw)
        }))
          num = (int) Function.Call<int>((Hash) 2834476523764480066L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(RComp)
          });
      }
      if (T == 2)
      {
        if ((bool) Function.Call<bool>((Hash) -1718696417760418019L, new InputArgument[3]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character()),
          InputArgument.op_Implicit(RComp),
          InputArgument.op_Implicit(RDraw)
        }))
          num = (int) Function.Call<int>((Hash) -8110606195499570259L, new InputArgument[3]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(RComp),
            InputArgument.op_Implicit(RDraw)
          });
      }
      return num;
    }

    public void Setoutfit(int i)
    {
      Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
      {
        InputArgument.op_Implicit(Game.get_Player().get_Character()),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0)
      });
      if (Model.op_Inequality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) 1885233650)))
        this.OldCharacter = ((Entity) Game.get_Player().get_Character()).get_Model();
      Function.Call((Hash) -6164042450715612628L, new InputArgument[2]
      {
        InputArgument.op_Implicit(Game.get_Player().get_Character()),
        InputArgument.op_Implicit(1.0)
      });
      Function.Call((Hash) 2328651364711703671L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Game.get_Player().get_Character())
      });
      Model model;
      ((Model) ref model).\u002Ector((PedHash) 1885233650);
      ((Model) ref model).Request(500);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(100);
        Function.Call((Hash) 45540521788082230L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Game.get_Player()),
          InputArgument.op_Implicit(((Model) ref model).get_Hash())
        });
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      Ped character = Game.get_Player().get_Character();
      Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
      {
        InputArgument.op_Implicit(character),
        InputArgument.op_Implicit(-1),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(17)
      });
      bool flag = false;
      string idC = this.ID_C;
      if (i == 0)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 1)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(89),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(55),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(54),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(89),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(55),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(54),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 2 && idC.Equals("Outfit Default"))
      {
        if (!flag && !idC.Equals("Outfit Default"))
          UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num = new Random().Next(1, 100);
        if (num <= 25)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(38),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 25 && num <= 50)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(112),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 50 && num <= 75)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 75)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(104),
            InputArgument.op_Implicit(25),
            InputArgument.op_Implicit(1)
          });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(17),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(34),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(69),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(125),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(68),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (i == 3)
      {
        if (idC.Equals("Blue"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Black") || idC.Equals("Outfit Default"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 4)
      {
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(13),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(15),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 5)
      {
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(13),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(15),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 6)
      {
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(134),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(147),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(167),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(113),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(90),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(286),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(135),
            InputArgument.op_Implicit(0)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(134),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(147),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(167),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(113),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(90),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(286),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(135),
            InputArgument.op_Implicit(0)
          });
        }
      }
      if (i == 7)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 8)
      {
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i != 9)
        return;
      if (idC.Equals("Outfit Default"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Green"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("White"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Blue"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Black"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (!flag)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
    }

    private void DisplayHelpTextThisFrame(string text)
    {
      Function.Call((Hash) -8860350453193909743L, new InputArgument[1]
      {
        InputArgument.op_Implicit("STRING")
      });
      Function.Call((Hash) 7789129354908300458L, new InputArgument[1]
      {
        InputArgument.op_Implicit(text)
      });
      Function.Call((Hash) 2562546386151446694L, new InputArgument[4]
      {
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(-1)
      });
    }

    public void OnTick(object sender, EventArgs e)
    {
      this.OnKeyDown();
      if (this.modMenuPool != null && this.modMenuPool.IsAnyMenuOpen())
        this.modMenuPool.ProcessMenus();
      if (this.All.get_Visible())
        this.modMenuPool.CloseAllMenus();
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(3000f, 1000f, 2000f)) < 3.0)
        this.ReReadIni();
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MoneyStorageMarker) < 40.0)
        this.LoadIniFile("scripts//DC&R//Casino.ini");
      if (this.MoneyVaultBought == 1)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MoneyStorageMarker) < 1.5 && this.Casino_level >= 3)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ open Money Vault");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MoneyStorageMarker) < 40.0 && this.Casino_level >= 3)
          World.DrawMarker((MarkerType) 1, this.MoneyStorageMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.8f, 0.8f, 1f), this.MarkerColor);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GunLockerMarker) < 1.5 && this.Casino_level >= 3)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ open Gun Locker");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GunLockerMarker) < 40.0 && this.Casino_level >= 3)
        World.DrawMarker((MarkerType) 1, this.GunLockerMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.8f, 0.8f, 1f), this.MarkerColor);
      for (int index = 0; index < this.SeatPos.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SeatPos[index]) < 3.0 && !this.sitting)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Sit");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SeatPos[index]) < 3.0 && this.sitting)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to get up");
      }
      using (List<Vector3>.Enumerator enumerator = this.SHowerPositions.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Vector3 current = enumerator.Current;
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 80.0)
          {
            if (this.InShower)
              World.DrawMarker((MarkerType) 1, current, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), this.MarkerColor);
            if (!this.InShower)
              World.DrawMarker((MarkerType) 1, current, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), this.MarkerColor);
          }
        }
      }
      using (List<Vector3>.Enumerator enumerator = this.WordrobePositions.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Vector3 current = enumerator.Current;
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 80.0)
            World.DrawMarker((MarkerType) 1, current, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), this.MarkerColor);
        }
      }
      using (List<Vector3>.Enumerator enumerator = this.SHowerPositions.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Vector3 current = enumerator.Current;
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 3.0)
          {
            if (this.InShower)
              this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to get out of shower");
            if (!this.InShower)
              this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to take a shower");
          }
        }
      }
      using (List<Vector3>.Enumerator enumerator = this.WordrobePositions.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Vector3 current = enumerator.Current;
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to access Wardrobe");
        }
      }
    }

    public void OnKeyDown()
    {
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MoneyStorageMarker) < 1.5 && this.Casino_level >= 3)
        this.MoneyMenu.set_Visible(!this.MoneyMenu.get_Visible());
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GunLockerMarker) < 1.5 && this.Casino_level >= 3)
        this.weaponsMenu.set_Visible(!this.weaponsMenu.get_Visible());
      for (int index = 0; index < this.SeatPos.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SeatPos[index]) < 3.0 && Game.IsControlJustPressed(2, (Control) 51))
        {
          if (!this.sitting)
          {
            Game.FadeScreenOut(500);
            Script.Wait(500);
            this.sitting = true;
            ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
            ((Entity) Game.get_Player().get_Character()).set_Position(this.SeatPos[index]);
            ((Entity) Game.get_Player().get_Character()).set_Heading(this.SeatRot[index]);
            Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
            {
              InputArgument.op_Implicit(0.0f)
            });
            Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
            {
              InputArgument.op_Implicit(0.0f)
            });
            Game.get_Player().get_Character().get_Task().PlayAnimation("anim@amb@office@seating@male@var_e@base@", "base", 8f, -1, true, -1f);
            Script.Wait(500);
            Game.FadeScreenIn(500);
          }
          else if (this.sitting)
          {
            ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
            Game.FadeScreenOut(500);
            Script.Wait(500);
            this.sitting = false;
            ((Entity) Game.get_Player().get_Character()).set_Position(this.SeatPos[index]);
            ((Entity) Game.get_Player().get_Character()).set_Heading(this.SeatRot[index]);
            Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
            {
              InputArgument.op_Implicit(0.0f)
            });
            Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
            {
              InputArgument.op_Implicit(0.0f)
            });
            Game.get_Player().get_Character().get_Task().ClearAnimation("anim@amb@office@seating@male@var_e@base@", "base");
            ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
            Script.Wait(500);
            Game.FadeScreenIn(500);
          }
        }
      }
      using (List<Vector3>.Enumerator enumerator = this.WordrobePositions.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Vector3 current = enumerator.Current;
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
            this.WoredrobeMenu.set_Visible(!this.WoredrobeMenu.get_Visible());
        }
      }
      using (List<Vector3>.Enumerator enumerator = this.SHowerPositions.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Vector3 current = enumerator.Current;
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
          {
            if (this.InShower)
            {
              this.InShower = false;
              ((Entity) Game.get_Player().get_Character()).set_Position(current);
              ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
              ((Entity) Game.get_Player().get_Character()).set_Health(500);
              Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
              {
                InputArgument.op_Implicit(Game.get_Player().get_Character()),
                InputArgument.op_Implicit(3),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
              {
                InputArgument.op_Implicit(Game.get_Player().get_Character()),
                InputArgument.op_Implicit(4),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
              {
                InputArgument.op_Implicit(Game.get_Player().get_Character()),
                InputArgument.op_Implicit(6),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1)
              });
              Game.get_Player().get_Character().get_Task().ClearAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a");
              Function.Call((Hash) -5116459798881995739L, new InputArgument[1]
              {
                InputArgument.op_Implicit(Game.get_Player().get_Character())
              });
            }
            else if (!this.InShower)
            {
              Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
              {
                InputArgument.op_Implicit("scr_fbi5a")
              });
              Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
              {
                InputArgument.op_Implicit("scr_fbi5a")
              });
              Function.Call((Hash) 960291159887317458L, new InputArgument[12]
              {
                InputArgument.op_Implicit("scr_fbi5_ped_water_splash"),
                InputArgument.op_Implicit(Game.get_Player().get_Character()),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(-0.5),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(1.0),
                InputArgument.op_Implicit(false),
                InputArgument.op_Implicit(false),
                InputArgument.op_Implicit(false)
              });
              this.InShower = true;
              ((Entity) Game.get_Player().get_Character()).set_Position(current);
              ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
              if (Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) -1692214353)) || Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) 225514697)))
              {
                Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(Game.get_Player().get_Character()),
                  InputArgument.op_Implicit(3),
                  InputArgument.op_Implicit(26),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(Game.get_Player().get_Character()),
                  InputArgument.op_Implicit(4),
                  InputArgument.op_Implicit(5),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(Game.get_Player().get_Character()),
                  InputArgument.op_Implicit(6),
                  InputArgument.op_Implicit(15),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1)
                });
              }
              else
              {
                Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(Game.get_Player().get_Character()),
                  InputArgument.op_Implicit(3),
                  InputArgument.op_Implicit(16),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(Game.get_Player().get_Character()),
                  InputArgument.op_Implicit(4),
                  InputArgument.op_Implicit(19),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(Game.get_Player().get_Character()),
                  InputArgument.op_Implicit(6),
                  InputArgument.op_Implicit(16),
                  InputArgument.op_Implicit(17),
                  InputArgument.op_Implicit(1)
                });
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a", 8f, -1, true, -1f);
            }
          }
        }
      }
    }
  }
}
