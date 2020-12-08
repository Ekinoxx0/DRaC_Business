// Decompiled with JetBrains decompiler
// Type: DRaC_Business.GaragesXl
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
using System.IO;

namespace DRaC_Business
{
  internal class GaragesXl : Script
  {
    public SaveCar SC;
    public Vector3 EnterMarkerA;
    public Vector3 EnterMarkerB;
    public Vector3 EnterMarkerC;
    public Vector3 ExitMarker;
    public Vector3 Vehicle1Loc;
    public Vehicle Vehicle1;
    public Vector3 Vehicle2Loc;
    public Vehicle Vehicle2;
    public Vector3 Vehicle3Loc;
    public Vehicle Vehicle3;
    public Vector3 Vehicle4Loc;
    public Vehicle Vehicle4;
    public Vector3 Vehicle5Loc;
    public Vehicle Vehicle5;
    public Vector3 Vehicle6Loc;
    public Vehicle Vehicle6;
    public Vector3 Vehicle7Loc;
    public Vehicle Vehicle7;
    public Vector3 Vehicle8Loc;
    public Vehicle Vehicle8;
    public Vector3 Vehicle9Loc;
    public Vehicle Vehicle9;
    public Vector3 Vehicle10Loc;
    public Vehicle Vehicle10;
    public Vector3 Vehicle11Loc;
    public Vehicle Vehicle11;
    public Vector3 Vehicle12Loc;
    public Vehicle Vehicle12;
    public Vector3 Vehicle13Loc;
    public Vehicle Vehicle13;
    public Vector3 Vehicle14Loc;
    public Vehicle Vehicle14;
    public Vector3 Vehicle15Loc;
    public Vehicle Vehicle15;
    public Vector3 Vehicle16Loc;
    public Vehicle Vehicle16;
    public Vector3 Vehicle17Loc;
    public Vehicle Vehicle17;
    public Vector3 Vehicle18Loc;
    public Vehicle Vehicle18;
    public Vector3 Vehicle19Loc;
    public Vehicle Vehicle19;
    public Vector3 Vehicle20Loc;
    public Vehicle Vehicle20;
    public Vector3 Vehicle21Loc;
    public Vehicle Vehicle21;
    public Vector3 Vehicle22Loc;
    public Vehicle Vehicle22;
    public Vector3 Vehicle23Loc;
    public Vehicle Vehicle23;
    public Vector3 Vehicle24Loc;
    public Vehicle Vehicle24;
    public Vector3 Vehicle25Loc;
    public Vehicle Vehicle25;
    public Vector3 Vehicle26Loc;
    public Vehicle Vehicle26;
    public Vector3 Vehicle27Loc;
    public Vehicle Vehicle27;
    public Vector3 Vehicle28Loc;
    public Vehicle Vehicle28;
    public Vector3 Vehicle29Loc;
    public Vehicle Vehicle29;
    public Vector3 Vehicle30Loc;
    public Vehicle Vehicle30;
    public Vector3 Vehicle31Loc;
    public Vehicle Vehicle31;
    public Vector3 Vehicle32Loc;
    public Vehicle Vehicle32;
    public Vector3 Vehicle33Loc;
    public Vehicle Vehicle33;
    public Vector3 Vehicle34Loc;
    public Vehicle Vehicle34;
    public Vector3 Vehicle35Loc;
    public Vehicle Vehicle35;
    public Vector3 Vehicle36Loc;
    public Vehicle Vehicle36;
    public Vector3 Vehicle37Loc;
    public Vehicle Vehicle37;
    public Vector3 Vehicle38Loc;
    public Vehicle Vehicle38;
    private MenuPool modMenuPool;
    private UIMenu GarageMenu;
    private UIMenu mainMenu;
    public Vector3 EntryMarker;
    public Vector3 ExitMarker2;
    private string path;
    public Vehicle SaveVehicle;
    public Vector3 RemoveMarker;
    private MenuPool modMenuPool2;
    private UIMenu RemoveMenu;
    private UIMenu mainMenu2;
    public string GarageNum;
    public bool DeliveringVehicle;
    public Vehicle VehicleToDeliver;
    public string SlotToDelete;
    public bool IsInInterior;
    private MenuPool modMenuPool3;
    private UIMenu BuyCar1;
    private UIMenu mainMenu3;
    private ScriptSettings Config;
    public Blip VehicleWarehouseMarker;
    public Vector3 WherehouseMarker;
    public Vector3 MenuMarker;
    private ScriptSettings ScriptConfig;
    public bool IsScriptEnabled;
    public string HostName;
    public BlipColor Blip_Colour;
    public string Uicolour;
    public Color MarkerColor;
    public string MarkerColorString;
    public int Casino_level;
    public Vector3 GarageEnt;
    public Vector3 GarageExit;
    public Vehicle CarToDelete;
    public float M;
    public string Price;
    public string Model;
    public string man;
    public string ListPath;

    public string GetHostName() => "~" + this.Uicolour + "~ " + this.HostName + "~w~ ";

    public void UpdateValues() => this.LoadIniFile("scripts//DC&R//Casino.ini");

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

    public GaragesXl()
    {
      base.\u002Ector();
      this.CheckForScriptEnabled("scripts//DisableBusinesses.ini");
      if (!this.IsScriptEnabled)
        return;
      this.SC = new SaveCar();
      this.Setup();
      this.add_Tick(new EventHandler(this.OnTick));
      this.GarageMenu.SetBannerType("scripts\\DC&R\\DC&R.png");
      this.mainMenu.SetBannerType("scripts\\DC&R\\DC&R.png");
      this.BuyCar1.SetBannerType("scripts\\DC&R\\DC&R.png");
      this.mainMenu3.SetBannerType("scripts\\DC&R\\DC&R.png");
    }

    private void SetupMarker()
    {
      this.VehicleWarehouseMarker = World.CreateBlip(this.WherehouseMarker);
      this.VehicleWarehouseMarker.set_Sprite((BlipSprite) 357);
      this.VehicleWarehouseMarker.set_Color(this.Blip_Colour);
      this.VehicleWarehouseMarker.set_Name("Casino Garage");
      this.VehicleWarehouseMarker.set_IsShortRange(true);
    }

    private void Setup()
    {
      this.LoadIniFile("scripts//DC&R//Casino.ini");
      this.SetupMarker();
      this.ExitMarker = new Vector3(1336f, 190.9267f, -49f);
      this.modMenuPool3 = new MenuPool();
      this.mainMenu3 = new UIMenu("Buy a special Vehicle", "Select an Option");
      this.modMenuPool3.Add(this.mainMenu3);
      this.BuyCar1 = this.modMenuPool3.AddSubMenu(this.mainMenu3, "Special Vehicles");
      this.modMenuPool = new MenuPool();
      this.mainMenu = new UIMenu("DC&R Business", "Select an Option");
      this.modMenuPool.Add(this.mainMenu);
      this.GarageMenu = this.modMenuPool.AddSubMenu(this.mainMenu, "Garage Options");
      this.modMenuPool2 = new MenuPool();
      this.mainMenu2 = new UIMenu("Remove a Vehicle", "Select an Option");
      this.modMenuPool2.Add(this.mainMenu2);
      this.RemoveMenu = this.modMenuPool2.AddSubMenu(this.mainMenu2, "Remove A Vehicle");
      this.SetupGarage();
      this.RemoveCar();
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
        UI.Notify("~r~Error~w~: ArcadiusTower.ini Failed To Load.");
      }
    }

    public void DeleteCarinSlot(string Slot, Vehicle V)
    {
      this.SC.LoadIniFile(this.path + "GarageA//" + Slot + ".ini");
      if (this.SC.VehicleName != "null")
      {
        if (V.get_DisplayName() == "ZTYPE")
        {
          int num = new Random().Next(10000000, 11000000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        if (V.get_ClassType() == 3)
        {
          int num = new Random().Next(85000, 125000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 19)
        {
          int num = new Random().Next(500000, 750000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 7)
        {
          int num = new Random().Next(345000, 400000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 2)
        {
          int num = new Random().Next(75000, 150000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 9)
        {
          int num = new Random().Next(100000, 250000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 6)
        {
          int num = new Random().Next(150000, 400000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 5)
        {
          int num = new Random().Next(240000, 350000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 1)
        {
          int num = new Random().Next(50000, 200000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 4)
        {
          int num = new Random().Next(225000, 300000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 8)
        {
          int num = new Random().Next(60000, 200000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else
        {
          int num = new Random().Next(50000, 120000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        UI.Notify("Office Assistant : Vehicle Sold");
      }
      if (this.SC.VehicleName == "null")
        UI.Notify("Office Assistant : There is no Vehicle in " + Slot);
      this.SC.SaveName();
      this.VehicleToDeliver = (Vehicle) null;
      ((Entity) V).Delete();
    }

    public void DeleteCarinSlot2(string Slot, Vehicle V)
    {
      this.SC.LoadIniFile(this.path + "GarageA//" + Slot + ".ini");
      if (this.SC.VehicleName != "null")
      {
        if (V.get_DisplayName() == "ZTYPE")
        {
          int num = new Random().Next(10000000, 11000000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        if (V.get_ClassType() == 3)
        {
          int num = new Random().Next(140000, 400000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 19)
        {
          int num = new Random().Next(750000, 1500000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 7)
        {
          int num = new Random().Next(640000, 900000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 2)
        {
          int num = new Random().Next(125000, 400000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 9)
        {
          int num = new Random().Next(200000, 600000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 6)
        {
          int num = new Random().Next(340000, 500000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 5)
        {
          int num = new Random().Next(450000, 1200000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 1)
        {
          int num = new Random().Next(120000, 400000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 4)
        {
          int num = new Random().Next(450000, 800000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else if (V.get_ClassType() == 8)
        {
          int num = new Random().Next(100000, 400000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        else
        {
          int num = new Random().Next(100000, 320000);
          Player player = Game.get_Player();
          player.set_Money(player.get_Money() + num);
        }
        UI.Notify("Office Assistant : Vehicle Sold");
      }
      if (this.SC.VehicleName == "null")
        UI.Notify("Office Assistant : There is no Vehicle in " + Slot);
      if (GTA.Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), GTA.Model.op_Implicit((PedHash) -1692214353)))
        UI.Notify("Buyer: Thank you Mr " + "Clinton" + " For your donation");
      if (GTA.Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), GTA.Model.op_Implicit((PedHash) 225514697)))
        UI.Notify("Buyer: Thank you Mr " + "De Santa" + " For your donation");
      if (GTA.Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), GTA.Model.op_Implicit((PedHash) -1686040670)))
        UI.Notify("Buyer: Thank you Mr " + "Philips" + " For your donation");
      UI.Notify("Buyer: Calculating Bonus");
      int num1 = 0;
      if (V.GetMod((VehicleMod) 48) >= 1)
        num1 += 10000;
      if (V.GetMod((VehicleMod) 11) > 0)
      {
        if (V.GetMod((VehicleMod) 11) == 1)
          num1 += 5000;
        if (V.GetMod((VehicleMod) 11) == 2)
          num1 += 10000;
        if (V.GetMod((VehicleMod) 11) == 3)
          num1 += 15000;
      }
      if (V.GetMod((VehicleMod) 13) > 0)
      {
        if (V.GetMod((VehicleMod) 13) == 1)
          num1 += 5000;
        if (V.GetMod((VehicleMod) 13) == 2)
          num1 += 10000;
        if (V.GetMod((VehicleMod) 13) == 3)
          num1 += 15000;
      }
      if (V.GetMod((VehicleMod) 16) > 0)
      {
        if (V.GetMod((VehicleMod) 16) == 1)
          num1 += 5000;
        if (V.GetMod((VehicleMod) 16) == 2)
          num1 += 10000;
        if (V.GetMod((VehicleMod) 16) == 3)
          num1 += 15000;
      }
      if (V.GetMod((VehicleMod) 12) > 0)
      {
        if (V.GetMod((VehicleMod) 12) == 1)
          num1 += 5000;
        if (V.GetMod((VehicleMod) 12) == 2)
          num1 += 10000;
        if (V.GetMod((VehicleMod) 12) == 3)
          num1 += 15500;
      }
      if (V.GetMod((VehicleMod) 10) == 1 || V.GetMod((VehicleMod) 10) == -1)
        num1 += 35000;
      UI.Notify("Buyer : Bonus for mods: $" + (object) num1);
      Player player1 = Game.get_Player();
      player1.set_Money(player1.get_Money() + num1);
      this.SC.SaveName();
      this.DeliveringVehicle = false;
      this.VehicleToDeliver = (Vehicle) null;
      ((Entity) V).Delete();
    }

    public GTA.Model RequestModel(string Name)
    {
      GTA.Model model;
      ((GTA.Model) ref model).\u002Ector(Name);
      ((GTA.Model) ref model).Request(250);
      if (((GTA.Model) ref model).get_IsInCdImage() && ((GTA.Model) ref model).get_IsValid())
      {
        while (!((GTA.Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((GTA.Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public void RemoveCar()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GaragesXl.\u003C\u003Ec__DisplayClass130_0 displayClass1300 = new GaragesXl.\u003C\u003Ec__DisplayClass130_0()
      {
        \u003C\u003E4__this = this,
        Slots = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot1");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot2");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot3");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot4");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot5");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot6");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot7");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot8");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot9");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot10");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot11");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot12");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot13");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot14");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot15");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot16");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot17");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot18");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot19");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot20");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot21");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot22");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot23");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot24");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot25");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot26");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot27");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot28");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot29");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot30");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot31");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot32");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot33");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot34");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot35");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot36");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot37");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Slots.Add((object) "Slot38");
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.RemoveMenu, "Sell Vehicle Option A (Worse)");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1300.s = new UIMenuListItem("Slot : ", displayClass1300.Slots, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass1300.s);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.CarinSlot = new UIMenuItem("Car : ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass1300.CarinSlot);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Delete1 = new UIMenuItem("Sell and Remove");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass1300.Delete1);
      // ISSUE: method pointer
      uiMenu1.add_OnListChange(new ListChangedEvent((object) displayClass1300, __methodptr(\u003CRemoveCar\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu1.add_OnListChange(new ListChangedEvent((object) displayClass1300, __methodptr(\u003CRemoveCar\u003Eb__1)));
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass1300, __methodptr(\u003CRemoveCar\u003Eb__2)));
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.RemoveMenu, "Add vehicle in Slot");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.LogList = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1300.logFile = File.ReadAllLines(this.ListPath);
      // ISSUE: reference to a compiler-generated field
      foreach (string str in displayClass1300.logFile)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1300.LogList.Add((object) str);
      }
      this.LoadIniFile(this.ListPath);
      List<object> objectList = new List<object>()
      {
        (object) "None",
        (object) "Super",
        (object) "Sport",
        (object) "Armoured",
        (object) "SportClassic",
        (object) "Compact",
        (object) "Coupe",
        (object) "Bikes",
        (object) "Offroad",
        (object) "Sedan",
        (object) "Suv",
        (object) "Vans"
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Ve = new UIMenuListItem("Vehicle : ", displayClass1300.LogList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass1300.Ve);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.VDName = new UIMenuItem("Vehicle Spawn Name  : Dukes2");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1300.VDName);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.VName = new UIMenuItem("Vehicle Full Name  : Imponte Dukes");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1300.VName);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.PuchaseV = new UIMenuItem("Purchase Vehicle : $0");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1300.PuchaseV);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.STlist = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1300.STlist.Add((object) "NULL");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.STlist.Add((object) "NULL");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.STlist.Add((object) "NULL");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.STlist.Add((object) "NULL");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.STlist.Add((object) "NULL");
      // ISSUE: reference to a compiler-generated field
      displayClass1300.STlist.Add((object) "NULL");
      UIMenuItem uiMenuItem1 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu2.AddItem(uiMenuItem1);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Search = new UIMenuItem("Enter Vehicle Name");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1300.Search);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1300.Ve2 = new UIMenuListItem("Vehicle : ", displayClass1300.STlist, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass1300.Ve2);
      UIMenuItem uiMenuItem2 = new UIMenuItem("Search Term  : NULL");
      uiMenu2.AddItem(uiMenuItem2);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.VDName2 = new UIMenuItem("Vehicle Spawn Name  : NULL");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1300.VDName2);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.VName2 = new UIMenuItem("Vehicle Full Name  : NULL");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1300.VName2);
      // ISSUE: reference to a compiler-generated field
      displayClass1300.PuchaseV2 = new UIMenuItem("Purchase Vehicle : NULL");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1300.PuchaseV2);
      UIMenuItem uiMenuItem3 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu2.AddItem(uiMenuItem3);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1300.ListSlot = new UIMenuListItem("Slot: ", displayClass1300.Slots, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass1300.ListSlot);
      // ISSUE: method pointer
      uiMenu2.add_OnListChange(new ListChangedEvent((object) displayClass1300, __methodptr(\u003CRemoveCar\u003Eb__3)));
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass1300, __methodptr(\u003CRemoveCar\u003Eb__4)));
    }

    public void SaveLocalcar(string G, Vehicle V, string Slot)
    {
      if (Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
      {
        if (Game.get_Player().get_Character().get_CurrentVehicle().get_DisplayName() != "RHINO" || Game.get_Player().get_Character().get_CurrentVehicle().get_DisplayName() != "KHANJALI" || Game.get_Player().get_Character().get_CurrentVehicle().get_DisplayName() != "CHERNOBOG")
        {
          if (Entity.op_Inequality((Entity) this.SaveVehicle, (Entity) null))
            ((Entity) this.SaveVehicle).Delete();
          string str = G;
          this.GarageNum = G;
          UI.Notify(this.path + str + "//" + Slot + ".ini");
          this.SC.LoadIniFile(this.path + str + "//" + Slot + ".ini");
          this.SC.SaveWithoutDelete();
          Script.Wait(1000);
          if (Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
            ((Entity) Game.get_Player().get_Character().get_CurrentVehicle()).Delete();
          if (!Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_LastVehicle(), (Entity) null))
            return;
          ((Entity) Game.get_Player().get_Character().get_LastVehicle()).Delete();
        }
        else
          this.DisplayHelpTextThisFrame("You cannot save this vehicle");
      }
      else
        this.DisplayHelpTextThisFrame("Bring a vehicle to save");
    }

    private void SetupGarage()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GaragesXl.\u003C\u003Ec__DisplayClass132_0 displayClass1320 = new GaragesXl.\u003C\u003Ec__DisplayClass132_0()
      {
        \u003C\u003E4__this = this,
        Slots = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot1");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot2");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot3");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot4");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot5");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot6");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot7");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot8");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot9");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot10");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot11");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot12");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot13");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot14");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot15");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot16");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot17");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot18");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot19");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot20");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot21");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot22");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot23");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot24");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot25");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot26");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot27");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot28");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot29");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot30");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot31");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot32");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot33");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot34");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot35");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot36");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot37");
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Slots.Add((object) "Slot38");
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.GarageMenu, "Enter Garage");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1320.s = new UIMenuListItem("Slot : ", displayClass1320.Slots, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass1320.s);
      // ISSUE: reference to a compiler-generated field
      displayClass1320.CarinSlot = new UIMenuItem("Car : ");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1320.CarinSlot);
      // ISSUE: reference to a compiler-generated field
      displayClass1320.Set = new UIMenuItem("Save Current Car");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1320.Set);
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass1320, __methodptr(\u003CSetupGarage\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass1320, __methodptr(\u003CSetupGarage\u003Eb__1)));
    }

    public void ReReadIni() => this.LoadIniFile("scripts//DC&R//Casino.ini");

    protected virtual void Dispose(bool A_0)
    {
      if (!A_0)
        return;
      if (Blip.op_Inequality(this.VehicleWarehouseMarker, (Blip) null))
        this.VehicleWarehouseMarker.Remove();
      if (Entity.op_Inequality((Entity) this.Vehicle1, (Entity) null))
        ((Entity) this.Vehicle1).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle2, (Entity) null))
        ((Entity) this.Vehicle2).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle3, (Entity) null))
        ((Entity) this.Vehicle3).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle4, (Entity) null))
        ((Entity) this.Vehicle4).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle5, (Entity) null))
        ((Entity) this.Vehicle5).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle5, (Entity) null))
        ((Entity) this.Vehicle5).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle6, (Entity) null))
        ((Entity) this.Vehicle6).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle7, (Entity) null))
        ((Entity) this.Vehicle7).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle8, (Entity) null))
        ((Entity) this.Vehicle8).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle9, (Entity) null))
        ((Entity) this.Vehicle9).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle10, (Entity) null))
        ((Entity) this.Vehicle10).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle11, (Entity) null))
        ((Entity) this.Vehicle11).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle12, (Entity) null))
        ((Entity) this.Vehicle12).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle13, (Entity) null))
        ((Entity) this.Vehicle13).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle14, (Entity) null))
        ((Entity) this.Vehicle14).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle15, (Entity) null))
        ((Entity) this.Vehicle15).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle16, (Entity) null))
        ((Entity) this.Vehicle16).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle17, (Entity) null))
        ((Entity) this.Vehicle17).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle18, (Entity) null))
        ((Entity) this.Vehicle18).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle19, (Entity) null))
        ((Entity) this.Vehicle19).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle20, (Entity) null))
        ((Entity) this.Vehicle20).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle21, (Entity) null))
        ((Entity) this.Vehicle21).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle22, (Entity) null))
        ((Entity) this.Vehicle22).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle23, (Entity) null))
        ((Entity) this.Vehicle23).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle24, (Entity) null))
        ((Entity) this.Vehicle24).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle25, (Entity) null))
        ((Entity) this.Vehicle25).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle26, (Entity) null))
        ((Entity) this.Vehicle26).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle27, (Entity) null))
        ((Entity) this.Vehicle27).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle28, (Entity) null))
        ((Entity) this.Vehicle28).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle29, (Entity) null))
        ((Entity) this.Vehicle29).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle30, (Entity) null))
        ((Entity) this.Vehicle30).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle31, (Entity) null))
        ((Entity) this.Vehicle31).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle32, (Entity) null))
        ((Entity) this.Vehicle32).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle33, (Entity) null))
        ((Entity) this.Vehicle33).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle34, (Entity) null))
        ((Entity) this.Vehicle34).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle35, (Entity) null))
        ((Entity) this.Vehicle35).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle36, (Entity) null))
        ((Entity) this.Vehicle36).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle37, (Entity) null))
        ((Entity) this.Vehicle37).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle38, (Entity) null))
        ((Entity) this.Vehicle38).Delete();
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

    private void OnTick(object sender, EventArgs e)
    {
      this.OnKeyDown();
      if (this.modMenuPool != null && this.modMenuPool.IsAnyMenuOpen())
        this.modMenuPool.ProcessMenus();
      if (this.modMenuPool2 != null && this.modMenuPool2.IsAnyMenuOpen())
        this.modMenuPool2.ProcessMenus();
      if (this.modMenuPool3 != null && this.modMenuPool3.IsAnyMenuOpen())
        this.modMenuPool3.ProcessMenus();
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(3000f, 1000f, 2000f)) < 3.0)
        this.ReReadIni();
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(404f, 404f, 404f)) < 3.0 && this.IsInInterior)
      {
        UI.Notify("Delete");
        this.DestoryCars();
        this.IsInInterior = false;
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(808f, 808f, 808f)) < 3.0 && !this.IsInInterior)
      {
        UI.Notify("Load");
        this.DestoryCars();
        this.CreateCars("GarageA");
        this.IsInInterior = true;
      }
      if (this.Casino_level >= 3 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ExitMarker) < 60.0)
        World.DrawMarker((MarkerType) 1, this.ExitMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(3f, 3f, 1f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ExitMarker) < 5.0 && this.Casino_level >= 3)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to exit the garage ");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WherehouseMarker) < 5.0 && this.Casino_level >= 3)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to save a vehicle into Garage the or Press ~INPUT_COVER~ to Enter Garage ");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RemoveMarker) < 2.0 && this.IsInInterior)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Sell/Buy a vehicle");
      if (this.Casino_level >= 3 && this.IsInInterior)
        World.DrawMarker((MarkerType) 1, this.RemoveMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
      if (Entity.op_Inequality((Entity) this.VehicleToDeliver, (Entity) null))
      {
        if (((Entity) this.VehicleToDeliver).get_IsAlive())
        {
          Vector3 vector3;
          ((Vector3) ref vector3).\u002Ector(862.92f, 2171.73f, 53f);
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), vector3) < 20.0 && Entity.op_Inequality((Entity) this.VehicleToDeliver, (Entity) null))
          {
            this.DeliveringVehicle = false;
            this.DeleteCarinSlot2(this.SlotToDelete, this.VehicleToDeliver);
            this.SlotToDelete = (string) null;
          }
        }
        if (Entity.op_Inequality((Entity) this.VehicleToDeliver, (Entity) null) && (!((Entity) this.VehicleToDeliver).get_IsAlive() && Entity.op_Inequality((Entity) this.VehicleToDeliver, (Entity) null)))
        {
          this.DeliveringVehicle = false;
          this.GarageNum = "GarageA";
          this.SC.LoadIniFile(this.path + "GarageA//" + this.SlotToDelete + ".ini");
          UI.Notify(this.path + "GarageA//" + this.SlotToDelete + ".ini");
          this.SC.SaveName();
          ((Entity) this.VehicleToDeliver).Delete();
          this.SlotToDelete = (string) null;
          UI.Notify("Office Assistant : Sorry boss, there is no pay for a destroyed vehicle");
        }
      }
      if (!this.IsInInterior || !Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
        return;
      Vehicle currentVehicle = Game.get_Player().get_Character().get_CurrentVehicle();
      if (Game.IsControlJustPressed(2, (Control) 44) && Entity.op_Inequality((Entity) currentVehicle, (Entity) null))
        ((Entity) currentVehicle).set_FreezePosition(false);
      if (Entity.op_Inequality((Entity) this.Vehicle1, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle1))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle2, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle2))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle3, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle3))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle4, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle4))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle5, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle5))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle6, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle6))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle7, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle7))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle8, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle8))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle9, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle9))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle10, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle10))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle11, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle11))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle12, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle12))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle13, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle13))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle14, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle14))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle15, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle15))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle16, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle16))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle17, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle17))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle18, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle18))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle19, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle19))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle20, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle20))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle21, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle21))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle22, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle22))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle23, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle23))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle24, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle24))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle25, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle25))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle26, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle26))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle27, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle27))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle28, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle28))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle29, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle29))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle30, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle30))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle31, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle31))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle32, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle32))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle33, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle33))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle34, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle34))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle35, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle35))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle36, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle36))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle37, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle37))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
      if (Entity.op_Inequality((Entity) this.Vehicle38, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle38))
      {
        ((Entity) currentVehicle).set_FreezePosition(true);
        currentVehicle.set_EngineRunning(true);
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use this vehicle or ~INPUT_COVER~ to save this vehicle ");
      }
    }

    public void LoadCarinToRealWorld(Vehicle V)
    {
      Vehicle currentVehicle = Game.get_Player().get_Character().get_CurrentVehicle();
      this.IsInInterior = false;
      ((Entity) currentVehicle).set_Position(this.WherehouseMarker);
      Game.get_Player().get_Character().SetIntoVehicle(currentVehicle, (VehicleSeat) -1);
      this.DestoryCars();
      ((Entity) currentVehicle).set_Heading(147f);
      currentVehicle.set_IsDriveable(true);
      this.SaveVehicle = currentVehicle;
      this.SaveVehicle.set_IsDriveable(true);
      this.SaveVehicle.Repair();
      ((Entity) this.SaveVehicle).set_FreezePosition(false);
    }

    public void LoadCarinToRealWorld2(Vehicle V, string Slot)
    {
      this.SC.LoadIniFile(this.path + "GarageA//" + Slot + ".ini");
      V = World.CreateVehicle(GTA.Model.op_Implicit(V.get_DisplayName()), this.MenuMarker, 147f);
      this.SC.Load(V);
      V.set_IsDriveable(true);
      ((Entity) V).set_Position(this.MenuMarker);
      this.VehicleToDeliver = V;
      V = (Vehicle) null;
      this.IsInInterior = false;
      ((Entity) this.VehicleToDeliver).set_Position(this.WherehouseMarker);
      Game.get_Player().get_Character().SetIntoVehicle(this.VehicleToDeliver, (VehicleSeat) -1);
      this.DestoryCars();
      ((Entity) this.VehicleToDeliver).set_Heading(147f);
      this.VehicleToDeliver.set_IsDriveable(true);
      this.SaveVehicle = this.VehicleToDeliver;
      this.SaveVehicle.set_IsDriveable(true);
      this.SaveVehicle.Repair();
      ((Entity) this.SaveVehicle).set_FreezePosition(false);
    }

    private void OnKeyDown()
    {
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WherehouseMarker) < 5.0 && (this.Casino_level >= 3 && Game.get_Player().get_WantedLevel() == 0))
        this.mainMenu.set_Visible(!this.mainMenu.get_Visible());
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RemoveMarker) < 2.0 && (this.Casino_level >= 3 && this.IsInInterior))
        this.mainMenu2.set_Visible(!this.mainMenu2.get_Visible());
      if (Game.IsControlJustPressed(2, (Control) 44) && Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
        Game.get_Player().get_Character().get_CurrentVehicle();
      if (Game.IsControlJustPressed(2, (Control) 44) && Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
      {
        Vehicle currentVehicle = Game.get_Player().get_Character().get_CurrentVehicle();
        if (Entity.op_Inequality((Entity) this.Vehicle1, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle1))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot1.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle2, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle2))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot2.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle3, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle3))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot3.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle4, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle4))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot4.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle5, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle5))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot5.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle6, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle6))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot6.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle7, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle7))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot7.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle8, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle8))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot8.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle9, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle9))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot9.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle10, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle10))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot10.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle11, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle11))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot11.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle12, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle12))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot12.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle13, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle13))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot13.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle14, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle14))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot14.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle15, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle15))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot15.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle16, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle16))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot16.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle17, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle17))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot17.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle18, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle18))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot18.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle19, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle19))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot19.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle20, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle20))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot20.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle21, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle21))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot21.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle22, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle22))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot22.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle23, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle23))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot23.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle24, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle24))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot24.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle25, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle25))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot25.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle26, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle26))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot26.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle27, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle27))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot27.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle28, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle28))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot28.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle29, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle29))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot29.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle30, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle30))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot30.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle31, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle31))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot31.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle32, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle32))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot32.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle33, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle33))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot33.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle34, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle34))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot34.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle35, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle35))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot35.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle36, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle36))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot36.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle37, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle37))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot37.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
        if (Entity.op_Inequality((Entity) this.Vehicle38, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle38))
        {
          this.SC.LoadIniFile(this.path + "GarageA//Slot38.ini");
          this.SC.SaveWithoutDelete();
          UI.Notify(this.GetHostName() + " : Saved Current vehicle");
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
      {
        Vehicle currentVehicle = Game.get_Player().get_Character().get_CurrentVehicle();
        if (Entity.op_Inequality((Entity) this.Vehicle1, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle1))
        {
          this.Vehicle1 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle1);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle2, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle2))
        {
          this.Vehicle2 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle2);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle3, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle3))
        {
          this.Vehicle3 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle3);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle4, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle4))
        {
          this.Vehicle4 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle4);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle5, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle5))
        {
          this.Vehicle5 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle5);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle6, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle6))
        {
          this.Vehicle6 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle6);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle7, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle7))
        {
          this.Vehicle7 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle7);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle8, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle8))
        {
          this.Vehicle8 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle8);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle9, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle9))
        {
          this.Vehicle9 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle9);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle10, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle10))
        {
          this.Vehicle10 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle10);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle11, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle11))
        {
          this.Vehicle11 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle11);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle12, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle12))
        {
          this.Vehicle12 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle12);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle13, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle13))
        {
          this.Vehicle13 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle13);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle14, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle14))
        {
          this.Vehicle14 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle14);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle15, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle15))
        {
          this.Vehicle15 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle15);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle16, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle16))
        {
          this.Vehicle16 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle16);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle17, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle17))
        {
          this.Vehicle17 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle17);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle18, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle18))
        {
          this.Vehicle18 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle18);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle19, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle19))
        {
          this.Vehicle19 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle19);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle20, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle20))
        {
          this.Vehicle20 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle20);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle21, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle21))
        {
          this.Vehicle21 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle21);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle22, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle22))
        {
          this.Vehicle22 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle22);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle23, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle23))
        {
          this.Vehicle23 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle23);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle24, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle24))
        {
          this.Vehicle24 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle24);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle25, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle25))
        {
          this.Vehicle25 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle25);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle26, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle26))
        {
          this.Vehicle26 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle26);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle27, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle27))
        {
          this.Vehicle27 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle27);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle28, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle28))
        {
          this.Vehicle28 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle28);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle29, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle29))
        {
          this.Vehicle29 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle29);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle30, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle30))
        {
          this.Vehicle30 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle30);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle31, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle31))
        {
          this.Vehicle31 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle31);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle32, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle32))
        {
          this.Vehicle32 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle32);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle33, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle33))
        {
          this.Vehicle33 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle33);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle34, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle34))
        {
          this.Vehicle34 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle34);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle35, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle35))
        {
          this.Vehicle35 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle35);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle36, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle36))
        {
          this.Vehicle36 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle36);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle37, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle37))
        {
          this.Vehicle37 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle37);
        }
        if (Entity.op_Inequality((Entity) this.Vehicle38, (Entity) null) && Entity.op_Equality((Entity) currentVehicle, (Entity) this.Vehicle38))
        {
          this.Vehicle38 = (Vehicle) null;
          this.LoadCarinToRealWorld(this.Vehicle38);
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 44) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WherehouseMarker) < 2.0)
      {
        if (this.IsInInterior)
          ;
        ((Entity) Game.get_Player().get_Character()).set_Position(this.ExitMarker);
        this.DestoryCars();
        this.IsInInterior = true;
        this.CreateCars("GarageA");
        UI.Notify("Loading in Cars this may take a minute");
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && this.IsInInterior && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ExitMarker) < 2.0)
      {
        this.IsInInterior = false;
        Script.Wait(300);
        this.DestoryCars();
        ((Entity) Game.get_Player().get_Character()).set_Position(this.WherehouseMarker);
      }
      if (!Game.IsControlJustPressed(2, (Control) 44) || !this.IsInInterior || (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ExitMarker2) >= 2.0)
        return;
      this.IsInInterior = false;
      Script.Wait(300);
      this.DestoryCars();
      ((Entity) Game.get_Player().get_Character()).set_Position(this.MenuMarker);
    }

    public void DestoryCars()
    {
      if (Entity.op_Inequality((Entity) this.Vehicle1, (Entity) null))
        ((Entity) this.Vehicle1).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle2, (Entity) null))
        ((Entity) this.Vehicle2).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle3, (Entity) null))
        ((Entity) this.Vehicle3).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle4, (Entity) null))
        ((Entity) this.Vehicle4).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle5, (Entity) null))
        ((Entity) this.Vehicle5).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle5, (Entity) null))
        ((Entity) this.Vehicle5).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle6, (Entity) null))
        ((Entity) this.Vehicle6).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle7, (Entity) null))
        ((Entity) this.Vehicle7).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle8, (Entity) null))
        ((Entity) this.Vehicle8).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle9, (Entity) null))
        ((Entity) this.Vehicle9).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle10, (Entity) null))
        ((Entity) this.Vehicle10).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle11, (Entity) null))
        ((Entity) this.Vehicle11).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle12, (Entity) null))
        ((Entity) this.Vehicle12).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle13, (Entity) null))
        ((Entity) this.Vehicle13).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle14, (Entity) null))
        ((Entity) this.Vehicle14).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle15, (Entity) null))
        ((Entity) this.Vehicle15).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle16, (Entity) null))
        ((Entity) this.Vehicle16).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle17, (Entity) null))
        ((Entity) this.Vehicle17).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle18, (Entity) null))
        ((Entity) this.Vehicle18).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle19, (Entity) null))
        ((Entity) this.Vehicle19).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle20, (Entity) null))
        ((Entity) this.Vehicle20).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle21, (Entity) null))
        ((Entity) this.Vehicle21).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle22, (Entity) null))
        ((Entity) this.Vehicle22).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle23, (Entity) null))
        ((Entity) this.Vehicle23).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle24, (Entity) null))
        ((Entity) this.Vehicle24).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle25, (Entity) null))
        ((Entity) this.Vehicle25).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle26, (Entity) null))
        ((Entity) this.Vehicle26).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle27, (Entity) null))
        ((Entity) this.Vehicle27).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle28, (Entity) null))
        ((Entity) this.Vehicle28).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle29, (Entity) null))
        ((Entity) this.Vehicle29).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle30, (Entity) null))
        ((Entity) this.Vehicle30).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle31, (Entity) null))
        ((Entity) this.Vehicle31).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle32, (Entity) null))
        ((Entity) this.Vehicle32).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle33, (Entity) null))
        ((Entity) this.Vehicle33).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle34, (Entity) null))
        ((Entity) this.Vehicle34).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle35, (Entity) null))
        ((Entity) this.Vehicle35).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle36, (Entity) null))
        ((Entity) this.Vehicle36).Delete();
      if (Entity.op_Inequality((Entity) this.Vehicle37, (Entity) null))
        ((Entity) this.Vehicle37).Delete();
      if (!Entity.op_Inequality((Entity) this.Vehicle38, (Entity) null))
        return;
      ((Entity) this.Vehicle38).Delete();
    }

    public void CreateCars(string Garage)
    {
      try
      {
        Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
        {
          InputArgument.op_Implicit("imp_impexp_interior_placement_interior_1_impexp_intwaremed_milo_")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("basic_style_set")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("urban_style_set")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("branded_style_set")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("basic_style_set")
        });
        Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
        {
          InputArgument.op_Implicit(252673),
          InputArgument.op_Implicit("car_floor_hatch")
        });
        Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
        {
          InputArgument.op_Implicit(252673)
        });
        Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
        {
          InputArgument.op_Implicit("imp_impexp_interior_placement_interior_1_impexp_intwaremed_milo_")
        });
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(994.5925),
          InputArgument.op_Implicit(-3002.594),
          InputArgument.op_Implicit(-39.64699)
        });
        this.LoadIniFile("scripts//DC&R//Casino.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot1.ini");
        GTA.Model model1 = this.SC.CheckCar(this.path + Garage + "//Slot1.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot2.ini");
        GTA.Model model2 = this.SC.CheckCar(this.path + Garage + "//Slot2.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot3.ini");
        GTA.Model model3 = this.SC.CheckCar(this.path + Garage + "//Slot3.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot4.ini");
        GTA.Model model4 = this.SC.CheckCar(this.path + Garage + "//Slot4.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot5.ini");
        GTA.Model model5 = this.SC.CheckCar(this.path + Garage + "//Slot5.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot6.ini");
        GTA.Model model6 = this.SC.CheckCar(this.path + Garage + "//Slot6.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot7.ini");
        GTA.Model model7 = this.SC.CheckCar(this.path + Garage + "//Slot7.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot8.ini");
        GTA.Model model8 = this.SC.CheckCar(this.path + Garage + "//Slot8.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot9.ini");
        GTA.Model model9 = this.SC.CheckCar(this.path + Garage + "//Slot9.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot10.ini");
        GTA.Model model10 = this.SC.CheckCar(this.path + Garage + "//Slot10.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot11.ini");
        GTA.Model model11 = this.SC.CheckCar(this.path + Garage + "//Slot11.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot12.ini");
        GTA.Model model12 = this.SC.CheckCar(this.path + Garage + "//Slot12.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot13.ini");
        GTA.Model model13 = this.SC.CheckCar(this.path + Garage + "//Slot13.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot14.ini");
        GTA.Model model14 = this.SC.CheckCar(this.path + Garage + "//Slot14.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot15.ini");
        GTA.Model model15 = this.SC.CheckCar(this.path + Garage + "//Slot15.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot16.ini");
        GTA.Model model16 = this.SC.CheckCar(this.path + Garage + "//Slot15.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot17.ini");
        GTA.Model model17 = this.SC.CheckCar(this.path + Garage + "//Slot17.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot18.ini");
        GTA.Model model18 = this.SC.CheckCar(this.path + Garage + "//Slot18.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot19.ini");
        GTA.Model model19 = this.SC.CheckCar(this.path + Garage + "//Slot19.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot20.ini");
        GTA.Model model20 = this.SC.CheckCar(this.path + Garage + "//Slot20.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot21.ini");
        GTA.Model model21 = this.SC.CheckCar(this.path + Garage + "//Slot21.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot22.ini");
        GTA.Model model22 = this.SC.CheckCar(this.path + Garage + "//Slot22.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot23.ini");
        GTA.Model model23 = this.SC.CheckCar(this.path + Garage + "//Slot23.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot24.ini");
        GTA.Model model24 = this.SC.CheckCar(this.path + Garage + "//Slot24.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot25.ini");
        GTA.Model model25 = this.SC.CheckCar(this.path + Garage + "//Slot25.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot26.ini");
        GTA.Model model26 = this.SC.CheckCar(this.path + Garage + "//Slot26.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot27.ini");
        GTA.Model model27 = this.SC.CheckCar(this.path + Garage + "//Slot27.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot28.ini");
        GTA.Model model28 = this.SC.CheckCar(this.path + Garage + "//Slot28.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot29.ini");
        GTA.Model model29 = this.SC.CheckCar(this.path + Garage + "//Slot29.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot30.ini");
        GTA.Model model30 = this.SC.CheckCar(this.path + Garage + "//Slot30.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot31.ini");
        GTA.Model model31 = this.SC.CheckCar(this.path + Garage + "//Slot31.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot32.ini");
        GTA.Model model32 = this.SC.CheckCar(this.path + Garage + "//Slot32.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot33.ini");
        GTA.Model model33 = this.SC.CheckCar(this.path + Garage + "//Slot33.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot34.ini");
        GTA.Model model34 = this.SC.CheckCar(this.path + Garage + "//Slot34.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot35.ini");
        GTA.Model model35 = this.SC.CheckCar(this.path + Garage + "//Slot35.ini");
        this.LoadIniFile("scripts//DC&R//Casino.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot36.ini");
        GTA.Model model36 = this.SC.CheckCar(this.path + Garage + "//Slot36.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot37.ini");
        GTA.Model model37 = this.SC.CheckCar(this.path + Garage + "//Slot37.ini");
        this.SC.LoadIniFile(this.path + Garage + "//Slot38.ini");
        GTA.Model model38 = this.SC.CheckCar(this.path + Garage + "//Slot38.ini");
        this.LoadIniFile("scripts//DC&R//Casino.ini");
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model1, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot1.ini");
          this.Vehicle1 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot1.ini"), this.Vehicle1Loc, -90f);
          this.SC.Load(this.Vehicle1);
          this.Vehicle1.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model2, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot2.ini");
          this.Vehicle2 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot2.ini"), this.Vehicle2Loc, -90f);
          this.SC.Load(this.Vehicle2);
          this.Vehicle2.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model3, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot3.ini");
          this.Vehicle3 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot3.ini"), this.Vehicle3Loc, -90f);
          this.SC.Load(this.Vehicle3);
          this.Vehicle3.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model4, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot4.ini");
          this.Vehicle4 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot4.ini"), this.Vehicle4Loc, -90f);
          this.SC.Load(this.Vehicle4);
          this.Vehicle4.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model5, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot5.ini");
          this.Vehicle5 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot5.ini"), this.Vehicle5Loc, -90f);
          this.SC.Load(this.Vehicle5);
          this.Vehicle5.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model6, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot6.ini");
          this.Vehicle6 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot6.ini"), this.Vehicle6Loc, -90f);
          this.SC.Load(this.Vehicle6);
          this.Vehicle6.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model7, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot7.ini");
          this.Vehicle7 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot7.ini"), this.Vehicle7Loc, -90f);
          this.SC.Load(this.Vehicle7);
          this.Vehicle7.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model8, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot8.ini");
          this.Vehicle8 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot8.ini"), this.Vehicle8Loc, -90f);
          this.SC.Load(this.Vehicle8);
          this.Vehicle8.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model9, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot9.ini");
          this.Vehicle9 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot9.ini"), this.Vehicle9Loc, -90f);
          this.SC.Load(this.Vehicle9);
          this.Vehicle9.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model10, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot10.ini");
          this.Vehicle10 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot10.ini"), this.Vehicle10Loc, -90f);
          this.SC.Load(this.Vehicle10);
          this.Vehicle10.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model11, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot11.ini");
          this.Vehicle11 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot11.ini"), this.Vehicle11Loc, -90f);
          this.SC.Load(this.Vehicle11);
          this.Vehicle11.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model12, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot12.ini");
          this.Vehicle12 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot12.ini"), this.Vehicle12Loc, -90f);
          this.SC.Load(this.Vehicle12);
          this.Vehicle12.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model13, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot13.ini");
          this.Vehicle13 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot13.ini"), this.Vehicle13Loc, -90f);
          this.SC.Load(this.Vehicle13);
          this.Vehicle13.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model14, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot14.ini");
          this.Vehicle14 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot14.ini"), this.Vehicle14Loc, -90f);
          this.SC.Load(this.Vehicle14);
          this.Vehicle14.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model15, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot15.ini");
          this.Vehicle15 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot15.ini"), this.Vehicle15Loc, 90f);
          this.SC.Load(this.Vehicle15);
          this.Vehicle15.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model16, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot16.ini");
          this.Vehicle16 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot16.ini"), this.Vehicle16Loc, 90f);
          this.SC.Load(this.Vehicle16);
          this.Vehicle16.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model17, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot17.ini");
          this.Vehicle17 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot17.ini"), this.Vehicle17Loc, 90f);
          this.SC.Load(this.Vehicle17);
          this.Vehicle17.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model18, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot18.ini");
          this.Vehicle18 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot18.ini"), this.Vehicle18Loc, 90f);
          this.SC.Load(this.Vehicle18);
          this.Vehicle18.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model19, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot19.ini");
          this.Vehicle19 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot19.ini"), this.Vehicle19Loc, 90f);
          this.SC.Load(this.Vehicle19);
          this.Vehicle19.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model20, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot20.ini");
          this.Vehicle20 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot20.ini"), this.Vehicle20Loc, 90f);
          this.SC.Load(this.Vehicle20);
          this.Vehicle20.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model21, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot21.ini");
          this.Vehicle21 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot21.ini"), this.Vehicle21Loc, 90f);
          this.SC.Load(this.Vehicle21);
          this.Vehicle21.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model22, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot22.ini");
          this.Vehicle22 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot22.ini"), this.Vehicle22Loc, 90f);
          this.SC.Load(this.Vehicle22);
          this.Vehicle22.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model23, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot23.ini");
          this.Vehicle23 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot23.ini"), this.Vehicle23Loc, 90f);
          this.SC.Load(this.Vehicle23);
          this.Vehicle23.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model24, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot24.ini");
          this.Vehicle24 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot24.ini"), this.Vehicle24Loc, 90f);
          this.SC.Load(this.Vehicle24);
          this.Vehicle24.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model25, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot25.ini");
          this.Vehicle25 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot25.ini"), this.Vehicle25Loc, 90f);
          this.SC.Load(this.Vehicle25);
          this.Vehicle25.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model26, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot26.ini");
          this.Vehicle26 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot26.ini"), this.Vehicle26Loc, 90f);
          this.SC.Load(this.Vehicle26);
          this.Vehicle26.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model27, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot27.ini");
          this.Vehicle27 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot27.ini"), this.Vehicle27Loc, 90f);
          this.SC.Load(this.Vehicle27);
          this.Vehicle27.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model28, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot28.ini");
          this.Vehicle28 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot28.ini"), this.Vehicle28Loc, 90f);
          this.SC.Load(this.Vehicle28);
          this.Vehicle28.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model29, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot29.ini");
          this.Vehicle29 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot29.ini"), this.Vehicle29Loc, 90f);
          this.SC.Load(this.Vehicle29);
          this.Vehicle29.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model30, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot30.ini");
          this.Vehicle30 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot30.ini"), this.Vehicle30Loc, 90f);
          this.SC.Load(this.Vehicle30);
          this.Vehicle30.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model31, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot31.ini");
          this.Vehicle31 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot31.ini"), this.Vehicle31Loc, 90f);
          this.SC.Load(this.Vehicle31);
          this.Vehicle31.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model32, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot32.ini");
          this.Vehicle32 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot32.ini"), this.Vehicle32Loc, 90f);
          this.SC.Load(this.Vehicle32);
          this.Vehicle32.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model33, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot33.ini");
          this.Vehicle33 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot33.ini"), this.Vehicle33Loc, 90f);
          this.SC.Load(this.Vehicle33);
          this.Vehicle33.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model34, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot34.ini");
          this.Vehicle34 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot34.ini"), this.Vehicle34Loc, 90f);
          this.SC.Load(this.Vehicle34);
          this.Vehicle34.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model35, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot35.ini");
          this.Vehicle35 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot35.ini"), this.Vehicle35Loc, 90f);
          this.SC.Load(this.Vehicle35);
          this.Vehicle35.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model36, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot36.ini");
          this.Vehicle36 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot36.ini"), this.Vehicle36Loc, 90f);
          this.SC.Load(this.Vehicle36);
          this.Vehicle36.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model37, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot37.ini");
          this.Vehicle37 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot37.ini"), this.Vehicle37Loc, 90f);
          this.SC.Load(this.Vehicle37);
          this.Vehicle37.set_IsDriveable(false);
        }
        Script.Wait(100);
        if (GTA.Model.op_Inequality(model38, GTA.Model.op_Implicit("null")))
        {
          this.SC.LoadIniFile(this.path + Garage + "//Slot38.ini");
          this.Vehicle38 = World.CreateVehicle(this.SC.CheckCar(this.path + Garage + "//Slot38.ini"), this.Vehicle38Loc, 90f);
          this.SC.Load(this.Vehicle38);
          this.Vehicle38.set_IsDriveable(false);
        }
        this.GarageNum = Garage;
      }
      catch (NullReferenceException ex)
      {
        UI.Notify("~r~ DC&R Garage : Somthing went wrong while loading these vehicles, please retry, if it persists check the vehicle ini files for invald vehiclenames or contact HKH~w~");
      }
    }
  }
}
