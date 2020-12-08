// Decompiled with JetBrains decompiler
// Type: DRaC_Business.Class1
// Assembly: DRaC_Business, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 46ED2638-FF60-4062-85B3-F169AC3C0185
// Assembly location: C:\Users\Ekinoxx\Desktop\DRaC_Business.dll

using GTA;
using GTA.Math;
using GTA.Native;
using Microsoft.CSharp.RuntimeBinder;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DRaC_Business
{
  public class Class1 : Script
  {
    private bool firstTime;
    private string ModName;
    private string Developer;
    private string Version;
    public Vector3 MarkerEnter;
    public Vector3 MarkerExit;
    public Vector3 MenuMarker;
    public Vector3 RoofEnterMarker;
    public Vector3 RoofExitMarker;
    public Vector3 HeliSpawn;
    public Vector3 GarageMarker;
    public Vector3 CarSpawn;
    public Vector3 WherehouseEnter;
    private ScriptSettings Config;
    private ScriptSettings OnlineInteriorsConfig;
    private Keys Key1;
    public Vector3 BuyMarker;
    public Vector3 BuyMarker2;
    public int num;
    private MenuPool modMenuPool;
    private UIMenu Missions;
    private UIMenu VehicleGaragePool;
    public Vector3 WherehouseMarker;
    private UIMenu mainMenu;
    private UIMenu methgarage;
    private UIMenu VehicleWherehouseOptions;
    private UIMenu ProductStock;
    public int PartyPedChance;
    public int PoolPedChance;
    public bool bought;
    public int purchaselvl;
    public int maxstocks;
    public float stocksvalue;
    public float profitMargin;
    public int stockscount;
    public int stockstimer;
    public int waittime;
    public int DisplayWait;
    public bool CreatedPeds2;
    public Prop PlayerCardA;
    public Prop PlayerCardB;
    public Prop PlayerCardC;
    public Prop PlayerCardD;
    public Prop PlayerCardE;
    public Prop PlayerCardF;
    public bool EnemySetup;
    public int Chooseenemynum;
    public Vehicle VehicleId;
    public bool VehicleSetup;
    private List<WeaponHash> weapons;
    public string carid;
    public int vehiclemissionid;
    public bool setupdelivery;
    public Vector3 DeliveryMaker;
    public Blip DeliveryLoc;
    public Blip ballasBlip1;
    public Vector3 Deliverypoint;
    public UIMenu Garage;
    public UIMenu Sourcingmenu;
    public UIMenu SupplyRunsmenu;
    public UIMenu OrganizationOptions;
    public bool setupwantedfordelivery;
    public int waittimeforwanted;
    public Vehicle AirVehicle;
    public int BuzzardBought;
    public int FMJBought;
    public int A911Bought;
    public int X80Bought;
    public int SEVEN70Bought;
    public int wherehosuebought;
    public int cargaragebought;
    public VehicleHash VehicleIdentifier;
    public Vehicle VehicleName;
    public bool foundvehicleyet;
    public Vector3 Vehicleloc;
    public Blip VehicleMarker;
    public Vehicle Vehicletoget;
    public Vector3 VehicleSpawn;
    public bool hasgotvehicle;
    private Blip Enemy;
    private Ped EnemyPed;
    private Vector3 EnemyLoc;
    public Random VehicleLoc;
    public Random VehicleRan;
    public Vehicle VehicleMissioncar;
    public Vector3 VehicleLocation;
    public int Missionnum;
    public Blip DestoryVehicle;
    private Random RandomWanted;
    private Random randomwantedwait;
    private int triggerwanted;
    public int Aircraftstorage;
    public bool warnedplayer;
    public Vector3 AircraftStorageLoc;
    public Blip AircraftStorageMarker;
    public Blip VehicleWarehouseMarker;
    public int GunLockerBought;
    public int MoneyVaultBought;
    public int DockBought;
    public int VehicleLotBought;
    public Vector3 Dockloc;
    public Blip DockBlip;
    public Vector3 LotLoc;
    public Blip LotBlip;
    public float SourcingPayout;
    public bool SourcingCheckingforDamage;
    public int AATrailerABought;
    public int AATrailerBBought;
    public int AATrailerCBought;
    public string OrganizationName;
    public UIMenu AssetRecoveryMenu;
    public bool TriggeredWanted;
    public int ValkyrieBought;
    public int AkulaBought;
    public int HunterBought;
    public int SavageBought;
    public int AnnihilatorBought;
    public Vehicle Vehicle1;
    public Vehicle Vehicle2;
    public Vehicle Vehicle3;
    public Blip ConvoyBlip1;
    public Blip ConvoyBlip2;
    public Blip ConvoyBlip3;
    public int convoysetup;
    public bool checkforconvoy;
    public int UseCustomWaitTime;
    public bool setWaittime;
    public Vector3 Radiopos;
    public int turretedlimo;
    public int assassinationmission;
    public int assassinationpayout;
    public Blip TowerBlip;
    public string Design;
    public Vector3 SleepPos;
    public Vector3 MBTOfficeSitRespawnPos;
    public Vector3 MBTOfficeSitPos;
    public bool sitting;
    public UIMenu Sourcingmenu2;
    public string SourcedVehicle;
    public bool NewVehicleSourcing;
    public float increaseGain;
    public AllStocks Allstocks;
    public UIMenu SpecialMissions;
    public List<Ped> Guards;
    public List<Ped> Driver;
    public Vehicle VtoGet;
    public Blip VtoGetBlip;
    public bool GotCar;
    public Vehicle VtoGet1;
    public Vehicle VtoGet2;
    public Vehicle VtoGet3;
    public int Vehiclesleft;
    public Blip DropzoneBlip;
    public Vector3 Dropzone;
    public bool VehicleisDamaged;
    public int Vehiclehealth;
    public Vehicle RentedVehicle;
    public bool startedRent;
    public int RentTimer;
    public int RentalvehicleHealth;
    public bool ISinPiracyScamMission;
    public int Piracymission;
    public int TimerLeft;
    public VehicleHash RandomVehicle;
    public bool HackhasStarted;
    public Vector3 GoPoint;
    public int StockTimer;
    public int StockTimer2;
    public float stocktoloose;
    private ScriptSettings ScriptConfig;
    public bool IsScriptEnabled;
    public Vector3 ChairPos;
    public float P_Rotation;
    public bool IsSittinginCeoSeat;
    public bool IsSittinginCeoSeat2;
    public string WarehousePos;
    public Camera WarehouseCam;
    public bool WCamOn;
    public bool IsinInterior;
    public Vector3 EnterMarkerA;
    public Vector3 EnterMarkerB;
    public Vector3 EnterMarkerC;
    public Vector3 ExitMarkerA;
    public Vector3 ExitMarkerB;
    public Vector3 ExitMarkerC;
    public string officetext;
    public bool CleanUpO1;
    public bool CleanUpO2;
    public bool CleanUpO3;
    public bool CleanUpO4;
    public int Effect;
    public List<Ped> MainPed;
    private int ao;
    private int bo;
    public string CurrentText;
    public int currentFont;
    public int currentColor;
    public int SlotTimer;
    private int OStage;
    private int OSMovie;
    private int OSF1;
    public bool BarPeds;
    public bool SlotPeds;
    public bool MainPeds;
    public bool RandomWanderPeds;
    public bool MainWanderPeds;
    public Prop CardA;
    public Prop CardB;
    public Prop CardC;
    public Vector3 AssistantChair;
    public Vector3 AssistantPos;
    public Vector3 CEOChairPos;
    public int ChairModelCEO;
    public int ChairModelAssistant;
    public PedHash AssistantPedModel;
    public bool CreatedAssistant;
    public Prop AssistantChairProp;
    public Prop CEOChairProp;
    public Ped AssistantPed;
    public Ped ViewPed;
    public string SearchPedInput;
    public Prop Chair;
    public Vector3 PenthouseUpgradeMarker;
    public Prop RouletteTableA;
    public Prop RouletteTableB;
    public Prop RouletteTableC;
    public List<string> ExProp;
    private List<string> CashProp;
    public int AmountOfCash;
    public string HostName;
    public BlipColor Blip_Colour;
    public string Uicolour;
    public Color MarkerColor;
    public string MarkerColorString;
    public int Casino_level;
    public int Chips_Amount;
    public Vector3 PenthouseEnter;
    public Vector3 PenthouseExit;
    public Vector3 PenthouseEnter2;
    public Vector3 PenthouseExit2;
    public Vector3 PenthouseEnter3;
    public Vector3 MembershipUpgradeMarker;
    public UIMenu Casino_Menu;
    public UIMenu Chips_Menu;
    public Vector3 GarageEnt;
    public Vector3 GarageExit;
    public Vector3 ChipsPurchaseMarker;
    public Blip MenuBlip;
    public Blip GarageBlip;
    public Blip PenthouseBlip;
    public List<Ped> Peds;
    public List<Ped> Peds2;
    public List<Vector3> Spawns;
    public Vehicle Prizecar;
    public Ped ped;
    public List<Vector3> PokerTables;
    public List<float> PokerTablesRot;
    public List<Vector3> BlackJackTables;
    public List<float> BlackJackRot;
    public List<Vector3> SlotMachines;
    public List<float> SlotMachinesRot;
    public List<Vector3> RouletteTables;
    public List<float> RouletteTablesRot;
    public List<Prop> Tables;
    public List<Prop> Tables2;
    public List<Prop> Chips;
    public List<Ped> SMPed;
    public int PlayerCard_1;
    public int PlayerCard_2;
    public int PlayerCard_3;
    public int PlayerCard_4;
    public int PlayerCard_5;
    public int PlayerCard_6;
    public int DealerCard_1;
    public int DealerCard_2;
    public int DealerCard_3;
    public int DealerCard_4;
    public int DealerCard_5;
    public int DealerCard_6;
    public float Mp;
    public bool Playing_Poker;
    public bool Playing_BlackJack;
    public bool Playing_SlotMachine;
    public bool Playing_Roulette;
    public bool Placebet;
    public bool Drawcards;
    public bool Editbet;
    public int Playercards;
    public int DealerCards;
    private float Bet;
    public int Penthouse_Style;
    public int Penthouse_Media;
    public int Penthouse_Spa;
    public int Penthouse_Bar;
    public int Penthouse_Colour;
    public int Penthouse_Arcade;
    public int Penthouse_BarLight;
    public int Penthouse_PokerDealer;
    public int Penthouse_ExtraBedroom;
    public UIMenu Pent_Menu;
    public UIMenu Misc;
    public bool Endgame;
    public bool IsinHottub;
    public Vector3 jacuzziSeat1;
    public float J_rot1;
    public Vector3 jacuzziSeat2;
    public float J_rot2;
    public Vector3 jacuzziSeat3;
    public float J_rot3;
    public Vector3 jacuzziSeat4;
    public float J_rot4;
    public Vector3 jacuzziSeat5;
    public float J_rot5;
    public Vector3 jacuzziSeat6;
    public float J_rot6;
    public Vector3 jacuzziSeat7;
    public float J_rot7;
    public Vector3 jacuzziSeat8;
    public float J_rot8;
    public Vector3 jacuzziSeat9;
    public float J_rot9;
    public Vector3 jacuzziSeat10;
    public float J_rot10;
    public Ped Vendor1;
    public Ped Vendor2;
    public int PedType;
    public int PedType2;
    public int RMax;
    public int RTimer;
    public int ThraxUnlocked;
    public Prop Champaine;
    public bool IsDrinking;
    public int DrinkTimer;
    public Vector3 RooftopEntA;
    public Vector3 RooftopEntB;
    public Vector3 RooftopExitA;
    public Vector3 RooftopExitB;
    public Vector3 LuckyWheel;
    public List<Vector3> DrinkPosPent;
    public List<float> DrinkPosRot;
    public List<Vector3> DrinkPosBar;
    public List<float> DrinkPosBarRot;
    public UIMenu DrinksMainMenu;
    public int DevMission;
    public UIMenu ChipsMenu;
    public Prop WheelProp;
    public Prop WheelProp2;
    public int Dis_Unlocked;
    public bool IsInbettingRace;
    public int Multiplyer;
    public Vector3 FinishLine;
    public Vehicle VehicleA;
    public Vehicle VehicleB;
    public Vehicle VehicleC;
    public Vehicle VehicleD;
    public Vehicle VehicleE;
    public Vehicle VehicleF;
    public Vector3 RaceMarker;
    public int PlayersPos;
    public bool StartedRace;
    public bool IsLeading;
    public bool FinishedRace;
    public bool inRace;
    public Blip RaceBlip;
    public Blip FinishLineBLip;
    public bool InRace;
    public List<Vector3> CheckpointPos;
    public List<Blip> CheckPointBlips;
    public List<Blip> PoliceCarBlips;
    public bool CheckpointRace;
    public int Laps;
    public int CurrentLap;
    public int Position;
    public int NextCheckpoint;
    public int CarsFinished;
    public int lap;
    public int checkpoint;
    public Vector3[] Route;
    public bool CircuitRace;
    public int ACheck;
    public int BCheck;
    public int CCheck;
    public int Alap;
    public int Blap;
    public int Clap;
    public int DCheck;
    public int ECheck;
    public int FCheck;
    public int Dlap;
    public int Elap;
    public int Flap;
    public bool StartR;
    public int Race;
    public float RaceBet;
    public bool CamActive;
    public UIMenu RaceMenu;
    public int CurrentTable;
    public List<Prop> Champ;
    public Vector3 RaceSTMarker;
    public Vehicle SpectateCar;
    public bool Opposite;
    public bool isRotating;
    public Prop Computer;
    public Vector3 ComputerPos;
    public Prop VIPBlocker;
    public bool IsBuying;
    public Prop BasePlate;
    public Prop BasePlate2;
    public Vector3 ThraxPos;
    public Blip LocationBlip;
    public Vehicle Plane;
    public Blip PlaneBlip;
    public Vector3 Spawn;
    public Vector3 MissionMarker;
    public bool DeliveryMissionOn;
    public int shipmentsDElivered;
    public Prop RouletteMarker;
    public Prop RouletteMarker1;
    public Prop RouletteMarker2;
    public int RouletteBetsPlaced;
    public float RouletteBet1;
    public string RouletteP1;
    public float RouletteBet2;
    public string RouletteP2;
    public float RouletteBet3;
    public string RouletteP3;
    public bool PlaceBet_R;
    public string BetPos;
    public int BetPosNum;
    public int MarkerNum;
    public Prop MarkerTomove;
    public Prop TableT;
    public int Vic1;
    public int Vic2;
    public int Vic3;
    public bool CreatedMarker;
    public bool ActiveInt;
    public List<Ped> EnemyAi;
    public List<Vehicle> EnemyVeh;
    public int EnemyTimer;
    public float VehicleA_stalltime;
    public int VehicleA_MpValue;
    public int VehicleA_max;
    public int VehicleB_MpValue;
    public float VehicleB_stalltime;
    public int VehicleB_max;
    public int VehicleC_MpValue;
    public float VehicleC_stalltime;
    public int VehicleC_max;
    public int VehicleD_MpValue;
    public float VehicleD_stalltime;
    public int VehicleD_max;
    public int VehicleE_MpValue;
    public float VehicleE_stalltime;
    public int VehicleE_max;
    public int VehicleF_MpValue;
    public float VehicleF_stalltime;
    public int VehicleF_max;
    public bool StopCounter;
    public int CarsCounted;
    public int MpValue;
    public int PlayerDeck;
    public int EliteDeckUnlocked;
    public int TDMPrice;
    public int TMDUnlocked;
    public bool TMD_UseNormalDeckCards;
    public bool TMD_UseEliteDeckCards;
    public bool TMD_UseAce;
    public bool TMD_UseKing;
    public bool TMD_UseQueen;
    public bool TMD_UseJack;
    public bool TMD_Use02;
    public bool TMD_Use03;
    public bool TMD_Use04;
    public bool TMD_Use05;
    public bool TMD_Use06;
    public bool TMD_Use07;
    public bool TMD_Use08;
    public bool TMD_Use09;
    public bool TMD_Use10;
    public bool TMD_Dealer;
    public Prop WheelWinMarker;
    public List<Prop> WheelMarkers;
    public Vehicle TankerA;
    public Vehicle TankerB;
    public Vehicle TankerC;
    public Vehicle TankerD;
    public Vehicle TankerE;
    public Vehicle TankerF;
    public Vehicle TankerG;
    public Vehicle TankerH;
    public List<Prop> Card_Deck;
    public UIMenu ArtMenu;
    public Vector3 Art_POSITION1;
    public Vector3 Art_POSITION2;
    public Vector3 Art_POSITION3;
    public Vector3 Art_POSITION4;
    public Vector3 Art_POSITION5;
    public Vector3 Art_POSITION6;
    public Vector3 Art_POSITION7;
    public Vector3 Art_POSITION8;
    public Vector3 Art_POSITION9;
    public Vector3 Art_POSITION10;
    public Vector3 Art_POSITION11;
    public Vector3 Art_POSITION12;
    public Vector3 Art_POSITION13;
    public Vector3 Art_POSITION14;
    public List<Prop> ArtProps;
    public string ArtPropName_1;
    public string ArtPropName_2;
    public string ArtPropName_3;
    public string ArtPropName_4;
    public string ArtPropName_5;
    public string ArtPropName_6;
    public string ArtPropName_7;
    public string ArtPropName_8;
    public string ArtPropName_9;
    public string ArtPropName_10;
    public string ArtPropName_11;
    public string ArtPropName_12;
    public string ArtPropName_13;
    public string ArtPropName_14;
    public Prop CurrentArtProp;
    public Camera ArtPropCam;
    public bool RemoveArt;
    public List<object> PaintProp;
    public List<object> SculptProp;
    public List<object> SculptLoc;
    public List<float> SculptPropRot;
    public List<object> PLocations;
    public int SunbatherPedChamce;
    public UIMenu submenu14s;
    public UIMenu submenu13s;
    public UIMenu submenu12s;
    public List<Ped> MiscPed;
    public List<PedHash> CustomTerracePeds;
    public bool MiscPedsEnabled;
    public bool IsinGarageMenu;
    public Camera RaceCam;
    public UIMenu DrinksMenu;
    public UIMenu MainStuffMenu;
    public Vector3 GarageMenuPos;
    public int EnemiesKilled;
    public int EnemySpawntimer;
    public List<Ped> Guard;
    public List<Vector3> PatrolNodes;
    public List<Vector3> PatrolNodes2;
    public Vehicle EscapeHeli;
    public Vehicle PatrolCar;
    public int MoveTimer;
    public Ped Avery;
    public Ped Pilot;
    public bool TriggeredEscape;
    public Ped TargetPed;
    public bool CreatedBlips;

    public string GetHostName() => "~" + this.Uicolour + "~ " + this.HostName + "~w~ ";

    public void CreateChipProp(Vector3 Spawn, string Name)
    {
    }

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

    public Class1()
    {
      base.\u002Ector();
      this.CheckForScriptEnabled("scripts//DisableBusinesses.ini");
      if (!this.IsScriptEnabled)
        return;
      this.Allstocks = new AllStocks();
      this.LoadIniFile("scripts//DC&R//Casino.ini");
      this.Setup();
      this.add_Tick(new EventHandler(this.OnTick));
      this.set_Interval(1);
      this.ReReadIni();
      this.DrinkPosPent.Add(new Vector3(944.2045f, 14.49989f, 115f));
      this.DrinkPosRot.Add(-125f);
      this.DrinkPosPent.Add(new Vector3(977.7616f, 69.39769f, 115f));
      this.DrinkPosRot.Add(-31f);
      this.DrinkPosPent.Add(new Vector3(1115.319f, 209.0317f, -50.5f));
      this.DrinkPosRot.Add(104f);
      this.DrinkPosPent.Add(new Vector3(958.1443f, 69.64272f, 112f));
      this.DrinkPosRot.Add(104f);
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_0_dlc_casino_main_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_2_dlc_casino_garage_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_4_dlc_casino_carpark_milo_")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_penthouse")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_carpark")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_main")
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_garage")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_0_dlc_casino_main_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_2_dlc_casino_garage_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_4_dlc_casino_carpark_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_penthouse")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_carpark")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_main")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_casino_garage")
      });
      int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(1100.0),
        InputArgument.op_Implicit(220.0),
        InputArgument.op_Implicit(-50.0)
      });
      int num2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(1380.0),
        InputArgument.op_Implicit(200.0),
        InputArgument.op_Implicit(-50.0)
      });
      int num3 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(1295.0),
        InputArgument.op_Implicit(230.0),
        InputArgument.op_Implicit(-50.0)
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      int num4 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(976.6364f),
        InputArgument.op_Implicit(70.29476f),
        InputArgument.op_Implicit(115.1641)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num4)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_05")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_06")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_07")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_08")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_09")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Dealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_NoDealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Bar_Clutter")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Clutter_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Clutter_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Clutter_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("set_pent_bar_light_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("set_pent_bar_light_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("set_pent_bar_light_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("set_pent_bar_party_1")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("set_pent_bar_party_2")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("set_pent_bar_party_after")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_GUEST_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_LOUNGE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_OFFICE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_CINE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_SPA_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_BAR_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_BLOCKER")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_01")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_01"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_02")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_02"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_03")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_03"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_04")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_04"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_05")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_05"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_06")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_06"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_07")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_07"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_08")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_08"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Pattern_09")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Pattern_09"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Spa == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
        });
      if (this.Penthouse_Spa == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
        });
      if (this.Penthouse_Media == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Open"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Media == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_PokerDealer == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Dealer")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_Dealer"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_PokerDealer == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_NoDealer")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("Set_Pent_NoDealer"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Arcade == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
        });
      if (this.Penthouse_Arcade == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
        });
      if (this.Penthouse_BarLight == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("set_pent_bar_light_0")
        });
      if (this.Penthouse_BarLight == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("set_pent_bar_light_01")
        });
      if (this.Penthouse_BarLight == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("set_pent_bar_light_02")
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num4),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      if (this.Penthouse_ExtraBedroom == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_GUEST_BLOCKER")
        });
      if (this.Penthouse_Media == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_CINE_BLOCKER")
        });
      if (this.Penthouse_Spa == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_SPA_BLOCKER")
        });
      if (this.Penthouse_Bar == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit("Set_Pent_BAR_BLOCKER")
        });
    }

    private void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.Key1 = (Keys) this.Config.GetValue<Keys>("Configurations", "Key1", (M0) this.Key1);
        this.purchaselvl = (int) this.Config.GetValue<int>("Setup", "BuisnessLevel", (M0) this.purchaselvl);
        this.stockscount = (int) this.Config.GetValue<int>("Setup", "stockslevel", (M0) this.stockscount);
        this.stocksvalue = (float) this.Config.GetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
        this.HostName = (string) this.Config.GetValue<string>("Misc", "HostName", (M0) this.HostName);
        this.Blip_Colour = (BlipColor) this.Config.GetValue<BlipColor>("Misc", "Blip_Colour", (M0) this.Blip_Colour);
        this.Uicolour = (string) this.Config.GetValue<string>("Misc", "Uicolour", (M0) this.Uicolour);
        this.MarkerColorString = (string) this.Config.GetValue<string>("Misc", "MarkerColor", (M0) this.MarkerColorString);
        this.MarkerColor = Color.FromName(this.MarkerColorString);
        this.Casino_level = (int) this.Config.GetValue<int>("Setup", "Casinoi_Upgrade_Level", (M0) this.Casino_level);
        this.Chips_Amount = (int) this.Config.GetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Mp = (float) this.Config.GetValue<float>("Setup", "Chips_Multiplier", (M0) (double) this.Mp);
        this.ThraxUnlocked = (int) this.Config.GetValue<int>("Setup", "ThraxUnlocked", (M0) this.ThraxUnlocked);
        this.Dis_Unlocked = (int) this.Config.GetValue<int>("Setup", "Dis_Unlocked", (M0) this.Dis_Unlocked);
        this.Penthouse_Style = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Style", (M0) this.Penthouse_Style);
        this.Penthouse_Media = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Media", (M0) this.Penthouse_Media);
        this.Penthouse_Spa = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Spa", (M0) this.Penthouse_Spa);
        this.Penthouse_Bar = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Bar", (M0) this.Penthouse_Bar);
        this.Penthouse_Colour = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Colour", (M0) this.Penthouse_Colour);
        this.Penthouse_Arcade = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_Arcade", (M0) this.Penthouse_Arcade);
        this.Penthouse_BarLight = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_BarLight", (M0) this.Penthouse_BarLight);
        this.Penthouse_PokerDealer = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_PokerDealer", (M0) this.Penthouse_PokerDealer);
        this.Penthouse_ExtraBedroom = (int) this.Config.GetValue<int>("Penthouse", "Penthouse_ExtraBedroom", (M0) this.Penthouse_ExtraBedroom);
        this.PedType = (int) this.Config.GetValue<int>("Penthouse", "PedType", (M0) this.PedType);
        this.PedType2 = (int) this.Config.GetValue<int>("Penthouse", "TerracePedType", (M0) this.PedType2);
        this.PartyPedChance = (int) this.Config.GetValue<int>("Penthouse", "PartyPedChance", (M0) this.PartyPedChance);
        this.PoolPedChance = (int) this.Config.GetValue<int>("Penthouse", "PoolPedChance", (M0) this.PoolPedChance);
        this.SunbatherPedChamce = (int) this.Config.GetValue<int>("Penthouse", "SunbatherPedChamce", (M0) this.SunbatherPedChamce);
        this.BarPeds = (bool) this.Config.GetValue<bool>("Interior Peds", "BarPeds", (M0) (this.BarPeds ? 1 : 0));
        this.SlotPeds = (bool) this.Config.GetValue<bool>("Interior Peds", "SlotPeds", (M0) (this.SlotPeds ? 1 : 0));
        this.MiscPedsEnabled = (bool) this.Config.GetValue<bool>("Interior Peds", "MiscPedsEnabled", (M0) (this.MiscPedsEnabled ? 1 : 0));
        this.MainPeds = (bool) this.Config.GetValue<bool>("Interior Peds", "MainPeds", (M0) (this.MainPeds ? 1 : 0));
        this.RandomWanderPeds = (bool) this.Config.GetValue<bool>("Interior Peds", "RandomWanderPeds", (M0) (this.RandomWanderPeds ? 1 : 0));
        this.MainWanderPeds = (bool) this.Config.GetValue<bool>("Interior Peds", "MainWanderPeds", (M0) (this.MainWanderPeds ? 1 : 0));
        this.PlayerDeck = (int) this.Config.GetValue<int>("CardDeck", "PlayerDeck", (M0) this.PlayerDeck);
        this.EliteDeckUnlocked = (int) this.Config.GetValue<int>("CardDeck", "EliteDeckUnlocked", (M0) this.EliteDeckUnlocked);
        this.TMDUnlocked = (int) this.Config.GetValue<int>("CardDeck -TMD", "TMDUnlocked", (M0) this.TMDUnlocked);
        this.TMD_UseNormalDeckCards = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseNormalDeckCards", (M0) (this.TMD_UseNormalDeckCards ? 1 : 0));
        this.TMD_UseEliteDeckCards = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseEliteDeckCards", (M0) (this.TMD_UseEliteDeckCards ? 1 : 0));
        this.TMD_UseAce = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseAce", (M0) (this.TMD_UseAce ? 1 : 0));
        this.TMD_UseKing = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseKing", (M0) (this.TMD_UseKing ? 1 : 0));
        this.TMD_UseQueen = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseQueen", (M0) (this.TMD_UseQueen ? 1 : 0));
        this.TMD_UseJack = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseJack", (M0) (this.TMD_UseJack ? 1 : 0));
        this.TMD_Use02 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use02", (M0) (this.TMD_Use02 ? 1 : 0));
        this.TMD_Use03 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use03", (M0) (this.TMD_Use03 ? 1 : 0));
        this.TMD_Use04 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use04", (M0) (this.TMD_Use04 ? 1 : 0));
        this.TMD_Use05 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use05", (M0) (this.TMD_Use05 ? 1 : 0));
        this.TMD_Use06 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use06", (M0) (this.TMD_Use06 ? 1 : 0));
        this.TMD_Use07 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use07", (M0) (this.TMD_Use07 ? 1 : 0));
        this.TMD_Use08 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use08", (M0) (this.TMD_Use08 ? 1 : 0));
        this.TMD_Use09 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use09", (M0) (this.TMD_Use09 ? 1 : 0));
        this.TMD_Use10 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use10", (M0) (this.TMD_Use10 ? 1 : 0));
        this.TMD_Dealer = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Dealer", (M0) (this.TMD_Dealer ? 1 : 0));
        this.ArtPropName_1 = (string) this.Config.GetValue<string>("Art", "ArtPropName_1", (M0) this.ArtPropName_1);
        this.ArtPropName_2 = (string) this.Config.GetValue<string>("Art", "ArtPropName_2", (M0) this.ArtPropName_2);
        this.ArtPropName_3 = (string) this.Config.GetValue<string>("Art", "ArtPropName_3", (M0) this.ArtPropName_3);
        this.ArtPropName_4 = (string) this.Config.GetValue<string>("Art", "ArtPropName_4", (M0) this.ArtPropName_4);
        this.ArtPropName_5 = (string) this.Config.GetValue<string>("Art", "ArtPropName_5", (M0) this.ArtPropName_5);
        this.ArtPropName_6 = (string) this.Config.GetValue<string>("Art", "ArtPropName_6", (M0) this.ArtPropName_6);
        this.ArtPropName_7 = (string) this.Config.GetValue<string>("Art", "ArtPropName_7", (M0) this.ArtPropName_7);
        this.ArtPropName_8 = (string) this.Config.GetValue<string>("Art", "ArtPropName_8", (M0) this.ArtPropName_8);
        this.ArtPropName_9 = (string) this.Config.GetValue<string>("Art", "ArtPropName_9", (M0) this.ArtPropName_9);
        this.ArtPropName_10 = (string) this.Config.GetValue<string>("Art", "ArtPropName_10", (M0) this.ArtPropName_10);
        this.ArtPropName_11 = (string) this.Config.GetValue<string>("Art", "ArtPropName_11", (M0) this.ArtPropName_11);
        this.ArtPropName_12 = (string) this.Config.GetValue<string>("Art", "ArtPropName_12", (M0) this.ArtPropName_12);
        this.ArtPropName_13 = (string) this.Config.GetValue<string>("Art", "ArtPropName_13", (M0) this.ArtPropName_13);
        this.ArtPropName_14 = (string) this.Config.GetValue<string>("Art", "ArtPropName_14", (M0) this.ArtPropName_14);
        try
        {
          for (int index = 0; index < 100; ++index)
            this.CustomTerracePeds.Add((PedHash) this.Config.GetValue<PedHash>("Terrace-CustomPeds", "CustomPed_" + (object) index, (M0) 793443893));
        }
        catch
        {
        }
        this.maxstocks = 10 * this.purchaselvl;
        float num = (float) (125000 * this.purchaselvl) / 0.75f;
        this.profitMargin = (float) (0.85 * (double) this.purchaselvl + 0.0);
        this.increaseGain = num;
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: Casino.ini Failed To Load.");
      }
    }

    private void Setup()
    {
      this.PLocations.Add((object) this.Art_POSITION1);
      this.PLocations.Add((object) this.Art_POSITION2);
      this.PLocations.Add((object) this.Art_POSITION3);
      this.PLocations.Add((object) this.Art_POSITION4);
      this.PLocations.Add((object) this.Art_POSITION5);
      this.PLocations.Add((object) this.Art_POSITION6);
      this.PLocations.Add((object) this.Art_POSITION7);
      this.PLocations.Add((object) this.Art_POSITION8);
      this.PLocations.Add((object) this.Art_POSITION9);
      this.PLocations.Add((object) this.Art_POSITION10);
      this.IsSittinginCeoSeat2 = false;
      this.IsSittinginCeoSeat = false;
      this.waittime = this.Allstocks.waittime;
      this.MarkerEnter = new Vector3(935.9782f, 47.018f, 80.2f);
      this.MarkerExit = new Vector3(1089.677f, 205.8681f, -50f);
      this.MenuMarker = new Vector3(-147.381f, -640.501f, 167f);
      this.CarSpawn = new Vector3(915.0286f, 51.88765f, 80f);
      this.GarageMarker = new Vector3(-144.336f, -577.952f, 31f);
      this.VehicleSpawn = new Vector3(-36f, -939.158f, 29.5f);
      this.SetupMarker();
      this.modMenuPool = new MenuPool();
      this.mainMenu = new UIMenu("DC&R Business", "Select an Option");
      this.modMenuPool.Add(this.mainMenu);
      this.MainStuffMenu = this.modMenuPool.AddSubMenu(this.mainMenu, "Purchase Options");
      this.methgarage = this.modMenuPool.AddSubMenu(this.MainStuffMenu, "Purchase Options");
      this.ProductStock = this.modMenuPool.AddSubMenu(this.MainStuffMenu, "Product Options");
      this.SpecialMissions = this.modMenuPool.AddSubMenu(this.MainStuffMenu, "Missions (Missions)");
      this.Garage = this.modMenuPool.AddSubMenu(this.MainStuffMenu, "Garage");
      this.ChipsMenu = this.modMenuPool.AddSubMenu(this.MainStuffMenu, "Chips Menu");
      this.Misc = this.modMenuPool.AddSubMenu(this.MainStuffMenu, "Misc");
      this.Chips_Menu = this.modMenuPool.AddSubMenu(this.mainMenu, "Arcade Chip Options");
      this.Casino_Menu = this.modMenuPool.AddSubMenu(this.mainMenu, "Membership Options");
      this.Pent_Menu = this.modMenuPool.AddSubMenu(this.mainMenu, "Penthouse Options");
      this.ArtMenu = this.modMenuPool.AddSubMenu(this.mainMenu, "Penthouse Options");
      this.DrinksMenu = this.modMenuPool.AddSubMenu(this.mainMenu, "Drinks");
      this.RaceMenu = this.modMenuPool.AddSubMenu(this.mainMenu, "Start");
      this.SetupRaceMenu();
      this.MiscMenu();
      this.Drinks();
      this.PenthouseOptions();
      this.Setupbuisness();
      this.SetupGarage();
      this.SetupProduct();
      this.CHipsM();
      this.SetupGames();
      this.CasinoOptions();
      this.ChipsOptions();
      this.SetupSpecialMissions();
      this.SetupArtMenu();
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MarkerEnter) >= 50.0)
        return;
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit(this.Design)
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit(this.Design)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(-141.392),
          InputArgument.op_Implicit(-621.0451),
          InputArgument.op_Implicit(168.8204)
        }))
      });
    }

    private void SetupMarker()
    {
      this.CreatedBlips = false;
      this.TowerBlip = World.CreateBlip(this.MarkerEnter);
      this.TowerBlip.set_Sprite((BlipSprite) 617);
      this.TowerBlip.set_Color(this.Blip_Colour);
      this.TowerBlip.set_Name("Diamond Casino & Resort");
    }

    public void ReReadIni() => this.LoadIniFile("scripts//DC&R//Casino.ini");

    public void RefreshPenthouse()
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(976.6364f),
        InputArgument.op_Implicit(70.29476f),
        InputArgument.op_Implicit(115.1641)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num1)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_05")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_06")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_07")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_08")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_09")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Dealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_NoDealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Bar_Clutter")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Clutter_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Clutter_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Clutter_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("set_pent_bar_light_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("set_pent_bar_light_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("set_pent_bar_light_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("set_pent_bar_party_1")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("set_pent_bar_party_2")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("set_pent_bar_party_after")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_GUEST_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_LOUNGE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_OFFICE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_CINE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_SPA_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_BAR_BLOCKER")
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_01")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_01"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_02")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_02"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_03")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_03"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_04")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_04"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_05")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_05"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_06")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_06"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_07")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_07"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_08")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_08"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Pattern_09")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Pattern_09"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Spa == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
        });
      if (this.Penthouse_Spa == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
        });
      if (this.Penthouse_Media == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Open"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Media == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_PokerDealer == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Dealer")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_Dealer"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_PokerDealer == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_NoDealer")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("Set_Pent_NoDealer"),
        InputArgument.op_Implicit(this.Penthouse_Colour)
      });
      if (this.Penthouse_Arcade == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
        });
      if (this.Penthouse_Arcade == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
        });
      if (this.Penthouse_BarLight == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("set_pent_bar_light_0")
        });
      if (this.Penthouse_BarLight == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("set_pent_bar_light_01")
        });
      if (this.Penthouse_BarLight == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("set_pent_bar_light_02")
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      if (this.Penthouse_ExtraBedroom == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_GUEST_BLOCKER")
        });
      if (this.Penthouse_Media == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_CINE_BLOCKER")
        });
      if (this.Penthouse_Spa == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_SPA_BLOCKER")
        });
      if (this.Penthouse_Bar == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num1),
          InputArgument.op_Implicit("Set_Pent_BAR_BLOCKER")
        });
      using (List<Prop>.Enumerator enumerator = this.ArtProps.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (this.RemoveArt)
        ;
      if (Entity.op_Inequality((Entity) this.CurrentArtProp, (Entity) null))
        ((Entity) this.CurrentArtProp).Delete();
      if (this.RemoveArt)
        this.RemoveArt = false;
      bool flag = false;
      int num2 = 0;
      for (int index = 0; index < this.SculptLoc.Count; ++index)
      {
        this.Config.GetValue<string>("Art", "SculptPropName_" + (object) index, (M0) "null");
        this.Config.GetValue<int>("Art", "SculptPropRotationZ_" + (object) index, (M0) 0);
        try
        {
          int num3 = (int) this.Config.GetValue<int>("Art", "SculptPropRotationZ_" + (object) index, (M0) 0);
          string Prop = (string) this.Config.GetValue<string>("Art", "SculptPropName_" + (object) index, (M0) "null");
          if (!Prop.Equals("null") && !Prop.Equals("None"))
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__564.\u003C\u003Ep__0 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__564.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, Vector3>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Vector3), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Vector3 vector3 = Class1.\u003C\u003Eo__564.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__564.\u003C\u003Ep__0, this.SculptLoc[index]);
            ((Vector3) ref vector3).\u002Ector((float) vector3.X, (float) vector3.Y, (float) (vector3.Z - 0.025000000372529));
            Prop prop = World.CreateProp(this.RequestModel(Prop), vector3, true, false);
            ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, (float) num3));
            ((Entity) prop).set_FreezePosition(true);
            this.ArtProps.Add(prop);
          }
        }
        catch
        {
          ++num2;
          flag = true;
          UI.Notify("(~b~1~w~) Error, Found New Item " + (object) index + ",(~b~2~w~)Repairing Ini file, this may take some time");
          this.Config.SetValue<string>("Art", "SculptPropName_" + (object) index, (M0) "null");
          this.Config.SetValue<int>("Art", "SculptPropRotationZ_" + (object) index, (M0) 0);
          this.Config.Save();
        }
      }
      if (flag)
        UI.Notify("(~b~1~w~) Ini Repair Complete, (~b~2~w~) Found " + (object) num2 + " Missing Files");
      if (!this.ArtPropName_1.Equals("null") && !this.ArtPropName_1.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_1), this.Art_POSITION1, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, -33f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_2.Equals("null") && !this.ArtPropName_2.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_2), this.Art_POSITION2, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, 146f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_3.Equals("null") && !this.ArtPropName_3.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_3), this.Art_POSITION3, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, 146f));
        ((Entity) prop).GetOffsetInWorldCoords(new Vector3(-0.8f, 0.2f, 0.0f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_4.Equals("null") && !this.ArtPropName_4.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_4), this.Art_POSITION4, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, 146f));
        ((Entity) prop).GetOffsetInWorldCoords(new Vector3(-0.8f, 0.2f, 0.0f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_5.Equals("null") && !this.ArtPropName_5.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_5), this.Art_POSITION5, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, 146f));
        ((Entity) prop).GetOffsetInWorldCoords(new Vector3(0.0f, 0.2f, 0.0f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_6.Equals("null") && !this.ArtPropName_6.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_6), this.Art_POSITION6, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, 61f));
        ((Entity) prop).GetOffsetInWorldCoords(new Vector3(0.0f, -0.8f, 0.0f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_7.Equals("null") && !this.ArtPropName_7.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_7), this.Art_POSITION7, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, 61f));
        ((Entity) prop).GetOffsetInWorldCoords(new Vector3(0.0f, -0.8f, 0.0f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_8.Equals("null") && !this.ArtPropName_8.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_8), this.Art_POSITION8, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, -33f));
        ((Entity) prop).GetOffsetInWorldCoords(new Vector3(0.0f, -0.05f, 0.0f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_9.Equals("null") && !this.ArtPropName_9.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_9), this.Art_POSITION9, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, -33f));
        ((Entity) prop).GetOffsetInWorldCoords(new Vector3(0.0f, -0.02f, 0.0f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (!this.ArtPropName_10.Equals("null") && !this.ArtPropName_10.Equals("None"))
      {
        Prop prop = World.CreateProp(this.RequestModel(this.ArtPropName_10), this.Art_POSITION10, true, false);
        ((Entity) prop).set_Rotation(new Vector3(0.0f, 0.0f, 55f));
        ((Entity) prop).GetOffsetInWorldCoords(new Vector3(-0.8f, 0.2f, 0.0f));
        ((Entity) prop).set_FreezePosition(true);
        this.ArtProps.Add(prop);
      }
      if (this.ArtPropName_11.Equals("null") || this.ArtPropName_11.Equals("None"))
        return;
      Prop prop1 = World.CreateProp(this.RequestModel(this.ArtPropName_11), this.Art_POSITION11, true, false);
      ((Entity) prop1).set_Rotation(new Vector3(0.0f, 0.0f, 55f));
      ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, -0.1f, 0.0f));
      ((Entity) prop1).set_FreezePosition(true);
      this.ArtProps.Add(prop1);
    }

    public void DeletePentInterior()
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(976.6364f),
        InputArgument.op_Implicit(70.29476f),
        InputArgument.op_Implicit(115.1641)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_04")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_05")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_06")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_07")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_08")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_09")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Dealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_NoDealer")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Bar_Clutter")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Clutter_03")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_01")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_light_02")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_1")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_2")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_after")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_GUEST_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_LOUNGE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_OFFICE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_CINE_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_SPA_BLOCKER")
      });
      Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_BAR_BLOCKER")
      });
    }

    public void ActiveInterior(
      int Style,
      int Spa,
      int Media,
      int PokerDealer,
      int Arcade,
      int ExtraBedroom,
      int Bar,
      int Colour)
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
      {
        InputArgument.op_Implicit("vw_int_placement_vw_interior_1_dlc_casino_apart_milo_")
      });
      int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(976.6364f),
        InputArgument.op_Implicit(70.29476f),
        InputArgument.op_Implicit(115.1641)
      });
      Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
      {
        InputArgument.op_Implicit(num)
      });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell")
      });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Tint_Shell"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_01")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_01"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_02")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_02"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_03")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_03"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_04")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_04"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_05")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_05"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_06")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_06"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_07")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_07"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_08")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_08"),
        InputArgument.op_Implicit(Colour)
      });
      if (Style == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Pattern_09")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Pattern_09"),
        InputArgument.op_Implicit(Colour)
      });
      if (Spa == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Spa_Bar_Open")
        });
      if (Spa == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Spa_Bar_Closed")
        });
      if (Media == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Media_Bar_Open")
        });
      if (Media == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Media_Bar_Closed")
        });
      if (PokerDealer == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Dealer")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_Dealer"),
        InputArgument.op_Implicit(Colour)
      });
      if (PokerDealer == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_NoDealer")
        });
      Function.Call((Hash) 3590001984630001091L, new InputArgument[3]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_NoDealer"),
        InputArgument.op_Implicit(Colour)
      });
      if (Arcade == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Arcade_Retro")
        });
      if (Arcade == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_Arcade_Modern")
        });
      if (this.Penthouse_BarLight == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("set_pent_bar_light_0")
        });
      if (this.Penthouse_BarLight == 1)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("set_pent_bar_light_01")
        });
      if (this.Penthouse_BarLight == 2)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("set_pent_bar_light_02")
        });
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("set_pent_bar_party_0")
      });
      if (ExtraBedroom == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_GUEST_BLOCKER")
        });
      if (Media == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_CINE_BLOCKER")
        });
      if (Spa == 0)
        Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
        {
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit("Set_Pent_SPA_BLOCKER")
        });
      if (Bar != 0)
        return;
      Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num),
        InputArgument.op_Implicit("Set_Pent_BAR_BLOCKER")
      });
    }

    public void AttemptSpawn()
    {
      try
      {
      }
      catch
      {
        UI.Notify("~r~ Error on Load, Attempting again!");
        this.AttemptAgain();
      }
    }

    public void AttemptAgain()
    {
      Script.Wait(1000);
      this.AttemptSpawn();
    }

    public void GrabArtWork()
    {
      this.PaintProp.Add((object) "vw_prop_vw_wallart_01a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_02a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_03a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_04a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_05a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_06a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_07a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_08a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_09a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_10a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_11a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_12a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_14a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_15a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_16a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_17a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_18a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_19a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_20a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_21a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_22a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_23a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_24a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_25a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_26a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_28a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_29a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_30a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_31a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_32a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_33a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_34a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_35a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_36a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_37a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_38a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_39a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_40a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_41a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_42a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_43a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_44a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_46a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_47a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_48a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_49a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_50a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_51a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_52a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_53a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_54a_01a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_55a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_56a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_57a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_58a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_59a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_60a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_61a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_62a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_63a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_64a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_65a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_66a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_67a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_68a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_69a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_70a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_71a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_72a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_73a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_74a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_75a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_76a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_77a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_78a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_79a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_80a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_81a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_82a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_83a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_84a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_85a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_86a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_87a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_88a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_89a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_90a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_91a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_92a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_93a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_94a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_95a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_96a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_97a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_98a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_99a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_100a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_101a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_102a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_103a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_104a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_105a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_106a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_107a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_108a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_109a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_110a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_111a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_112a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_113a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_114a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_115a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_116a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_117a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_118a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_123a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_124a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_125a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_126a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_127a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_128a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_129a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_130a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_131a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_132a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_133a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_134a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_135a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_136a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_137a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_138a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_139a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_140a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_141a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_142a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_143a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_144a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_145a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_146a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_147a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_150a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_151a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_151b");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_151c");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_151d");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_151e");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_151f");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_152a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_153a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_154a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_155a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_156a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_157a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_158a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_159a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_160a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_161a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_162a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_163a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_164a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_165a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_166a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_167a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_168a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_169a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_170a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_171a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_172a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_173a");
      this.PaintProp.Add((object) "vw_prop_vw_wallart_174a");
    }

    public void GrabArtWork2()
    {
      this.SculptProp.Add((object) "vw_prop_casino_art_concrete_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_concrete_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_console_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_console_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_miniature_05a");
      this.SculptProp.Add((object) "vw_prop_casino_art_miniature_05b");
      this.SculptProp.Add((object) "vw_prop_casino_art_miniature_05c");
      this.SculptProp.Add((object) "vw_prop_casino_art_miniature_09a");
      this.SculptProp.Add((object) "vw_prop_casino_art_miniature_09b");
      this.SculptProp.Add((object) "vw_prop_casino_art_miniature_09c");
      this.SculptProp.Add((object) "vw_prop_casino_art_sculpture_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_sculpture_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_sculpture_02b");
      this.SculptProp.Add((object) "vw_prop_casino_art_skull_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_skull_01b");
      this.SculptProp.Add((object) "vw_prop_casino_art_skull_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_skull_02b");
      this.SculptProp.Add((object) "vw_prop_casino_art_skull_03a");
      this.SculptProp.Add((object) "vw_prop_casino_art_skull_03b");
      this.SculptProp.Add((object) "vw_prop_casino_art_statue_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_statue_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_bird_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_03a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_04a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_05a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_06a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_07a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_08a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_09a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_10a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_11a");
      this.SculptProp.Add((object) "vw_prop_casino_art_car_12a");
      this.SculptProp.Add((object) "vw_prop_casino_art_cherries_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_deer_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_dog_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_egg_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_figurines_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_figurines_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_grenade_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_grenade_01b");
      this.SculptProp.Add((object) "vw_prop_casino_art_grenade_01c");
      this.SculptProp.Add((object) "vw_prop_casino_art_grenade_01d");
      this.SculptProp.Add((object) "vw_prop_casino_art_guitar_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_gun_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_gun_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_head_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_head_01b");
      this.SculptProp.Add((object) "vw_prop_casino_art_head_01c");
      this.SculptProp.Add((object) "vw_prop_casino_art_head_01d");
      this.SculptProp.Add((object) "vw_prop_casino_art_lampf_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_lampm_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_lollipop_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_03a");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_03a_a");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_03a_b");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_03a_c");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_03b");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_03b_a");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_03b_b");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_03b_c");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_04a");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_04b");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_04c");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_05a");
      this.SculptProp.Add((object) "vw_prop_casino_art_mod_06a");
      this.SculptProp.Add((object) "vw_prop_casino_art_pill_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_pill_01b");
      this.SculptProp.Add((object) "vw_prop_casino_art_pill_01c");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_03a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_04a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_05a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_06a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_07a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_08a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_09a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_10a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_11a");
      this.SculptProp.Add((object) "vw_prop_casino_art_plant_12a");
      this.SculptProp.Add((object) "vw_prop_casino_art_sh_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_statue_04a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_03a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_04a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_05a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_06a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_07a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_08a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_09a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_10a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_11a");
      this.SculptProp.Add((object) "vw_prop_casino_art_vase_12a");
      this.SculptProp.Add((object) "vw_prop_vw_plant_int_03a");
      this.SculptProp.Add((object) "vw_prop_art_football_01a");
      this.SculptProp.Add((object) "vw_prop_art_mic_01a");
      this.SculptProp.Add((object) "vw_prop_art_pug_01a");
      this.SculptProp.Add((object) "vw_prop_art_pug_01b");
      this.SculptProp.Add((object) "vw_prop_art_pug_02a");
      this.SculptProp.Add((object) "vw_prop_art_pug_02b");
      this.SculptProp.Add((object) "vw_prop_art_pug_03a");
      this.SculptProp.Add((object) "vw_prop_art_pug_03b");
      this.SculptProp.Add((object) "vw_prop_art_resin_balls_01a");
      this.SculptProp.Add((object) "vw_prop_art_resin_guns_01a");
      this.SculptProp.Add((object) "vw_prop_art_wall_segment_01a");
      this.SculptProp.Add((object) "vw_prop_art_wall_segment_02a");
      this.SculptProp.Add((object) "vw_prop_art_wall_segment_02b");
      this.SculptProp.Add((object) "vw_prop_art_wall_segment_03a");
      this.SculptProp.Add((object) "vw_prop_art_wings_01a");
      this.SculptProp.Add((object) "vw_prop_art_wings_01b");
      this.SculptProp.Add((object) "vw_prop_book_stack_01a");
      this.SculptProp.Add((object) "vw_prop_book_stack_01b");
      this.SculptProp.Add((object) "vw_prop_book_stack_01c");
      this.SculptProp.Add((object) "vw_prop_book_stack_02a");
      this.SculptProp.Add((object) "vw_prop_book_stack_02b");
      this.SculptProp.Add((object) "vw_prop_book_stack_02c");
      this.SculptProp.Add((object) "vw_prop_book_stack_03a");
      this.SculptProp.Add((object) "vw_prop_book_stack_03b");
      this.SculptProp.Add((object) "vw_prop_book_stack_03c");
      this.SculptProp.Add((object) "vw_prop_casino_art_basketball_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_basketball_02a");
      this.SculptProp.Add((object) "vw_prop_flowers_potted_01a");
      this.SculptProp.Add((object) "vw_prop_flowers_potted_02a");
      this.SculptProp.Add((object) "vw_prop_flowers_potted_03a");
      this.SculptProp.Add((object) "vw_prop_flowers_vase_01a");
      this.SculptProp.Add((object) "vw_prop_flowers_vase_02a");
      this.SculptProp.Add((object) "vw_prop_flowers_vase_03a");
      this.SculptProp.Add((object) "vw_prop_miniature_yacht_01a");
      this.SculptProp.Add((object) "vw_prop_miniature_yacht_01b");
      this.SculptProp.Add((object) "vw_prop_miniature_yacht_01c");
      this.SculptProp.Add((object) "vw_prop_plaque_01a");
      this.SculptProp.Add((object) "vw_prop_plaque_02a");
      this.SculptProp.Add((object) "vw_prop_plaque_02b");
      this.SculptProp.Add((object) "vw_prop_toy_sculpture_01a");
      this.SculptProp.Add((object) "vw_prop_toy_sculpture_02a");
      this.SculptProp.Add((object) "vw_prop_vw_pogo_gold_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_absman_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_bottle_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_bowling_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_bowling_01b");
      this.SculptProp.Add((object) "vw_prop_casino_art_bowling_02a");
      this.SculptProp.Add((object) "vw_prop_casino_art_ego_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_horse_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_horse_01b");
      this.SculptProp.Add((object) "vw_prop_casino_art_horse_01c");
      this.SculptProp.Add((object) "vw_prop_casino_art_panther_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_panther_01b");
      this.SculptProp.Add((object) "vw_prop_casino_art_panther_01c");
      this.SculptProp.Add((object) "vw_prop_casino_art_rocket_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_v_01a");
      this.SculptProp.Add((object) "vw_prop_casino_art_v_01b");
      this.SculptProp.Add((object) "ba_prop_battle_champ_closed");
      this.SculptProp.Add((object) "ba_prop_battle_champ_closed_02");
      this.SculptProp.Add((object) "ba_prop_battle_champ_closed_03");
      this.SculptProp.Add((object) "ba_prop_battle_champ_open");
      this.SculptProp.Add((object) "ba_prop_battle_champ_open_02");
      this.SculptProp.Add((object) "ba_prop_battle_champ_open_03");
      this.SculptProp.Add((object) "ba_prop_battle_cuffs");
      this.SculptProp.Add((object) "ba_prop_battle_trophy_battler");
      this.SculptProp.Add((object) "ba_prop_battle_trophy_dancer");
      this.SculptProp.Add((object) "ba_prop_battle_trophy_no1");
      this.SculptProp.Add((object) "xs_prop_arena_champ_closed");
      this.SculptProp.Add((object) "xs_prop_arena_champ_open");
      this.SculptProp.Add((object) "xs_prop_arena_trophy_double_01a");
      this.SculptProp.Add((object) "xs_prop_arena_trophy_double_01b");
      this.SculptProp.Add((object) "xs_prop_arena_trophy_double_01c");
      this.SculptProp.Add((object) "xs_prop_arena_trophy_single_01a");
      this.SculptProp.Add((object) "xs_prop_arena_trophy_single_01b");
      this.SculptProp.Add((object) "xs_prop_arena_trophy_single_01c");
      this.SculptProp.Add((object) "xs_prop_trophy_bandito_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_carfire_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_carstack_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_champ_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_cup_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_drone_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_firepit_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_flags_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_flipper_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_goldbag_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_imperator_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_mines_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_pegasus_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_presents_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_rc_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_shunt_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_spinner_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_telescope_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_tower_01a");
      this.SculptProp.Add((object) "xs_prop_trophy_wrench_01a");
      this.SculptProp.Add((object) "p_ld_heist_bag_s_1");
      this.SculptProp.Add((object) "prop_gold_bar");
      this.SculptProp.Add((object) "prop_jewel_02a");
      this.SculptProp.Add((object) "prop_jewel_02b");
      this.SculptProp.Add((object) "prop_jewel_02c");
      this.SculptProp.Add((object) "prop_jewel_03a");
      this.SculptProp.Add((object) "prop_jewel_03b");
      this.SculptProp.Add((object) "prop_jewel_04a");
      this.SculptProp.Add((object) "prop_jewel_04b");
      this.SculptProp.Add((object) "p_watch_01");
      this.SculptProp.Add((object) "p_watch_02");
      this.SculptProp.Add((object) "p_watch_03");
      this.SculptProp.Add((object) "p_watch_04");
      this.SculptProp.Add((object) "p_watch_05");
      this.SculptProp.Add((object) "p_watch_06");
      this.SculptProp.Add((object) "prop_idol_01_error");
      this.SculptProp.Add((object) "ex_prop_exec_award_bronze");
      this.SculptProp.Add((object) "ex_prop_exec_award_diamond");
      this.SculptProp.Add((object) "ex_prop_exec_award_gold");
      this.SculptProp.Add((object) "ex_prop_exec_award_plastic");
      this.SculptProp.Add((object) "ex_prop_exec_award_silver");
      this.SculptProp.Add((object) "ex_cash_pile_01");
      this.SculptProp.Add((object) "vw_prop_casino_cards_01");
      this.SculptProp.Add((object) "vw_prop_casino_cards_02");
      this.SculptProp.Add((object) "vw_prop_casino_cards_single");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_02");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_03");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_04");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_05");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_06");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_07");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_08");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_ace");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_jack");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_king");
      this.SculptProp.Add((object) "vw_prop_cas_card_club_queen");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_02");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_03");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_04");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_05");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_06");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_07");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_08");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_09");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_10");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_ace");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_jack");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_king");
      this.SculptProp.Add((object) "vw_prop_cas_card_dia_queen");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_02");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_03");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_04");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_05");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_06");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_07");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_08");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_09");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_10");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_ace");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_jack");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_king");
      this.SculptProp.Add((object) "vw_prop_cas_card_hrt_queen");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_02");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_03");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_04");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_05");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_06");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_07");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_08");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_09");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_10");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_ace");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_jack");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_king");
      this.SculptProp.Add((object) "vw_prop_cas_card_spd_queen");
      this.SculptProp.Add((object) "vw_prop_vw_3card_01a");
      this.SculptProp.Add((object) "vw_prop_vw_card_case_01a");
      this.SculptProp.Add((object) "vw_prop_vw_casino_cards_01");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_02a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_03a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_04a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_05a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_06a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_07a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_08a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_09a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_10a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_a_a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_j_a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_k_a");
      this.SculptProp.Add((object) "vw_prop_vw_club_char_q_a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_02a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_03a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_04a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_05a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_06a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_07a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_08a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_09a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_10a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_a_a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_j_a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_k_a");
      this.SculptProp.Add((object) "vw_prop_vw_dia_char_q_a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_02a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_03a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_04a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_05a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_06a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_07a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_08a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_09a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_10a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_a_a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_j_a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_k_a");
      this.SculptProp.Add((object) "vw_prop_vw_hrt_char_q_a");
      this.SculptProp.Add((object) "vw_prop_vw_jo_char_01a");
      this.SculptProp.Add((object) "vw_prop_vw_jo_char_02a");
      this.SculptProp.Add((object) "vw_prop_vw_key_card_01a");
      this.SculptProp.Add((object) "vw_prop_vw_lux_card_01a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_02a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_03a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_04a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_05a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_06a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_07a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_08a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_09a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_10a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_a_a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_j_a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_k_a");
      this.SculptProp.Add((object) "vw_prop_vw_spd_char_q_a");
      this.SculptProp.Add((object) "vw_prop_chip_1kdollar_st");
      this.SculptProp.Add((object) "vw_prop_chip_1kdollar_x1");
      this.SculptProp.Add((object) "vw_prop_chip_5kdollar_st");
      this.SculptProp.Add((object) "vw_prop_chip_5kdollar_x1");
      this.SculptProp.Add((object) "vw_prop_chip_10dollar_st");
      this.SculptProp.Add((object) "vw_prop_chip_10dollar_x1");
      this.SculptProp.Add((object) "vw_prop_chip_10kdollar_st");
      this.SculptProp.Add((object) "vw_prop_chip_10kdollar_x1");
      this.SculptProp.Add((object) "vw_prop_chip_50dollar_st");
      this.SculptProp.Add((object) "vw_prop_chip_50dollar_x1");
      this.SculptProp.Add((object) "vw_prop_chip_100dollar_st");
      this.SculptProp.Add((object) "vw_prop_chip_100dollar_x1");
      this.SculptProp.Add((object) "vw_prop_chip_500dollar_st");
      this.SculptProp.Add((object) "vw_prop_chip_500dollar_x1");
      this.SculptProp.Add((object) "vw_prop_plaq_1kdollar_x1");
      this.SculptProp.Add((object) "vw_prop_plaq_5kdollar_st");
      this.SculptProp.Add((object) "vw_prop_plaq_5kdollar_x1");
      this.SculptProp.Add((object) "vw_prop_plaq_10kdollar_st");
      this.SculptProp.Add((object) "vw_prop_plaq_10kdollar_x1");
      this.SculptProp.Add((object) "vw_prop_vw_chips_pile_01a");
      this.SculptProp.Add((object) "vw_prop_vw_chips_pile_02a");
      this.SculptProp.Add((object) "vw_prop_vw_chips_pile_03a");
      this.SculptProp.Add((object) "vw_prop_vw_coin_01a");
      this.SculptProp.Add((object) "vw_prop_casino_champset");
      this.SculptProp.Add((object) "vw_prop_vw_colle_alien");
      this.SculptProp.Add((object) "vw_prop_vw_colle_beast");
      this.SculptProp.Add((object) "vw_prop_vw_colle_imporage");
      this.SculptProp.Add((object) "vw_prop_vw_colle_pogo");
      this.SculptProp.Add((object) "vw_prop_vw_colle_prbubble");
      this.SculptProp.Add((object) "vw_prop_vw_colle_rsrcomm");
      this.SculptProp.Add((object) "vw_prop_vw_colle_rsrgeneric");
      this.SculptProp.Add((object) "vw_prop_vw_colle_sasquatch");
      this.SculptProp.Add((object) "p_gcase_s");
      this.SculptProp.Add((object) "p_laptop_02_s");
      this.SculptProp.Add((object) "p_mr_raspberry_01_s");
      this.SculptProp.Add((object) "vw_prop_vw_v_blueprt_01a");
      this.SculptProp.Add((object) "prop_acc_guitar_01");
      this.SculptProp.Add((object) "prop_acc_guitar_01_d1");
      this.SculptProp.Add((object) "vw_prop_vw_chip_carrier_01a");
      this.SculptProp.Add((object) "apa_mp_h_acc_bottle_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_bottle_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_bowl_ceramic_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_box_trinket_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_box_trinket_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_candles_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_candles_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_candles_04");
      this.SculptProp.Add((object) "apa_mp_h_acc_candles_05");
      this.SculptProp.Add((object) "apa_mp_h_acc_candles_06");
      this.SculptProp.Add((object) "apa_mp_h_acc_coffeemachine_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_dec_head_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_dec_plate_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_dec_plate_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_dec_sculpt_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_dec_sculpt_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_dec_sculpt_03");
      this.SculptProp.Add((object) "apa_mp_h_acc_drink_tray_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_fruitbowl_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_fruitbowl_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_jar_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_jar_03");
      this.SculptProp.Add((object) "apa_mp_h_acc_jar_04");
      this.SculptProp.Add((object) "apa_mp_h_acc_phone_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_plant_palm_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_plant_tall_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_pot_pouri_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_scent_sticks_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_tray_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_04");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_05");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_06");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_flowers_01");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_flowers_02");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_flowers_03");
      this.SculptProp.Add((object) "apa_mp_h_acc_vase_flowers_04");
    }

    public void SetupArtMenu()
    {
      this.SculptLoc.Add((object) new Vector3(971.4469f, 71.12376f, 116.2449f));
      this.SculptLoc.Add((object) new Vector3(973.4052f, 69.97559f, 116.2449f));
      this.SculptLoc.Add((object) new Vector3(972.6075f, 70.53499f, 116.2449f));
      this.SculptLoc.Add((object) new Vector3(968.3544f, 72.30743f, 115.6902f));
      this.SculptLoc.Add((object) new Vector3(976.5177f, 80.23362f, 116.1382f));
      this.SculptLoc.Add((object) new Vector3(969.4531f, 77.62489f, 115.6971f));
      this.SculptLoc.Add((object) new Vector3(976.4003f, 80.65188f, 116.1382f));
      this.SculptLoc.Add((object) new Vector3(977.8342f, 70.76744f, 116.1382f));
      this.SculptLoc.Add((object) new Vector3(971.9137f, 81.98214f, 116.1122f));
      this.SculptLoc.Add((object) new Vector3(972.9839f, 75.56157f, 115.6972f));
      this.SculptLoc.Add((object) new Vector3(983.1158f, 67.49692f, 116.0922f));
      this.SculptLoc.Add((object) new Vector3(984.2914f, 66.72982f, 116.0922f));
      this.SculptLoc.Add((object) new Vector3(974.4702f, 41.89836f, 116.0019f));
      this.SculptLoc.Add((object) new Vector3(966.2922f, 42.10915f, 116.1383f));
      this.SculptLoc.Add((object) new Vector3(974.5083f, 63.8875f, 115.6616f));
      this.SculptLoc.Add((object) new Vector3(965.8897f, 41.60423f, 116.1383f));
      this.SculptLoc.Add((object) new Vector3(964.7979f, 39.74314f, 116.1482f));
      this.SculptLoc.Add((object) new Vector3(966.9099f, 8229f * (float) System.Math.PI / 601f, 115.8882f));
      this.SculptLoc.Add((object) new Vector3(965.3593f, 39.1421f, 116.1482f));
      this.SculptLoc.Add((object) new Vector3(974.4998f, 49.53851f, 116.1383f));
      this.SculptLoc.Add((object) new Vector3(978.0218f, 46.56517f, 115.9923f));
      this.SculptLoc.Add((object) new Vector3(976.4994f, 46.86512f, 115.9922f));
      this.SculptLoc.Add((object) new Vector3(976.5798f, 46.46362f, 115.9922f));
      this.SculptLoc.Add((object) new Vector3(976.8693f, 46.68201f, 115.9922f));
      this.SculptLoc.Add((object) new Vector3(979.0563f, 69.87373f, 116.1382f));
      this.SculptLoc.Add((object) new Vector3(945.124f, 14.89447f, 116.2324f));
      this.SculptLoc.Add((object) new Vector3(948.8206f, 17.97805f, 116.2324f));
      this.SculptLoc.Add((object) new Vector3(940.6143f, 10.60696f, 116.0452f));
      this.SculptLoc.Add((object) new Vector3(947.098f, 17.37584f, 116.2324f));
      this.SculptLoc.Add((object) new Vector3(946.713f, 17.43841f, 116.2324f));
      this.SculptLoc.Add((object) new Vector3(947.0009f, 17.54459f, 116.2324f));
      this.SculptLoc.Add((object) new Vector3(944.1304f, 13.74309f, 116.2324f));
      this.SculptLoc.Add((object) new Vector3(946.6449f, 17.10868f, 116.2324f));
      this.SculptLoc.Add((object) new Vector3(954.0463f, 32.15368f, 115.7886f));
      this.SculptLoc.Add((object) new Vector3(956.1825f, 39.25602f, 115.9771f));
      this.SculptLoc.Add((object) new Vector3(953.3879f, 31.41343f, 116.3413f));
      this.SculptLoc.Add((object) new Vector3(947.5201f, 25.55083f, 115.6968f));
      this.SculptLoc.Add((object) new Vector3(966.8933f, 35.24205f, 116.0023f));
      this.SculptLoc.Add((object) new Vector3(968.6607f, 36.26171f, 116.1769f));
      this.SculptLoc.Add((object) new Vector3(989.285f, 66.46245f, 116.1385f));
      this.SculptLoc.Add((object) new Vector3(989.1791f, 65.0499f, 116.5328f));
      this.SculptLoc.Add((object) new Vector3(989.5279f, 66.66537f, 116.1352f));
      this.SculptLoc.Add((object) new Vector3(989.285f, 66.46245f, 116.1385f));
      this.SculptLoc.Add((object) new Vector3(984.8004f, 68.36877f, 116.1383f));
      this.SculptLoc.Add((object) new Vector3(961.1185f, 42.7681f, 115.7886f));
      this.SculptLoc.Add((object) new Vector3(960.9095f, 47.88779f, 115.7886f));
      this.SculptLoc.Add((object) new Vector3(970.9131f, 41.73798f, 116.1388f));
      this.SculptLoc.Add((object) new Vector3(989.5279f, 66.66537f, 116.1352f));
      this.SculptLoc.Add((object) new Vector3(970.9131f, 41.73798f, 116.1388f));
    }

    public void SetupRaceMenu()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass572_0 displayClass5720 = new Class1.\u003C\u003Ec__DisplayClass572_0();
      // ISSUE: reference to a compiler-generated field
      displayClass5720.\u003C\u003E4__this = this;
      List<object> objectList = new List<object>();
      objectList.Add((object) "Vehicle A");
      objectList.Add((object) "Vehicle B");
      objectList.Add((object) "Vehicle C");
      objectList.Add((object) "Vehicle D");
      objectList.Add((object) "Vehicle E");
      objectList.Add((object) "Vehicle F");
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.RaceMenu, "Race to Win");
      // ISSUE: reference to a compiler-generated field
      displayClass5720.BCar = new UIMenuListItem("Vehicle To WIn : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5720.BCar);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) displayClass5720.BCar).set_Description("The Vehicle that you think will win the 3 Lap race");
      // ISSUE: reference to a compiler-generated field
      displayClass5720.CBet = new UIMenuItem("Enter Bet Amount : Current " + this.RaceBet.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5720.CBet);
      UIMenuItem uiMenuItem = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem);
      // ISSUE: reference to a compiler-generated field
      displayClass5720.Stallodds = new UIMenuItem("Stall Odds : 1/2");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5720.Stallodds);
      // ISSUE: reference to a compiler-generated field
      displayClass5720.StallR = new UIMenuItem("Stall Repair Time : 6s");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5720.StallR);
      // ISSUE: reference to a compiler-generated field
      displayClass5720.MaxSpeed = new UIMenuItem("Max Speed : 435Kph");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5720.MaxSpeed);
      // ISSUE: reference to a compiler-generated field
      displayClass5720.PayoutMp = new UIMenuItem("Payout Multiplier : x1");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5720.PayoutMp);
      // ISSUE: reference to a compiler-generated field
      displayClass5720.Start = new UIMenuItem("Start Race");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5720.Start);
      // ISSUE: reference to a compiler-generated field
      displayClass5720.Cancel = new UIMenuItem("Cancel Race");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5720.Cancel);
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass5720, __methodptr(\u003CSetupRaceMenu\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5720, __methodptr(\u003CSetupRaceMenu\u003Eb__1)));
    }

    public void SetPedOutfit(Ped ped)
    {
      Random random = new Random();
      int num1 = random.Next(1, 9);
      if (num1 == 1)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num2 = random.Next(0, 5);
        int num3 = random.Next(0, 1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        int num4 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num5 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(num5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num6 = random.Next(0, 1);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(num6),
          InputArgument.op_Implicit(1)
        });
      }
      if (num1 == 2)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num2 = random.Next(0, 5);
        int num3 = random.Next(0, 1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num4 = random.Next(0, 2);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (num1 == 3)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num2 = random.Next(0, 5);
        int num3 = random.Next(0, 1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num4 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num5 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(num5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num6 = random.Next(0, 1);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(num6),
          InputArgument.op_Implicit(1)
        });
      }
      if (num1 == 4)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num2 = random.Next(0, 5);
        int num3 = random.Next(0, 1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num4 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num5 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(num5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num6 = random.Next(0, 1);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(num6),
          InputArgument.op_Implicit(1)
        });
      }
      if (num1 == 5)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num2 = random.Next(0, 5);
        int num3 = random.Next(0, 1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num4 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num5 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(num5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num6 = random.Next(0, 1);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(num6),
          InputArgument.op_Implicit(1)
        });
      }
      if (num1 == 6)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num2 = random.Next(0, 5);
        int num3 = random.Next(0, 1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        int num4 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num5 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(num5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        random.Next(0, 1);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
      }
      if (num1 == 7)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num2 = random.Next(0, 5);
        int num3 = random.Next(0, 1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        int num4 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        random.Next(0, 1);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
      }
      if (num1 == 8)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num2 = random.Next(0, 5);
        int num3 = random.Next(0, 1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(num2),
          InputArgument.op_Implicit(num3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num4 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(num4),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num5 = random.Next(0, 2);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(num5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        random.Next(0, 1);
        Script.Wait(1);
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
      }
      if (num1 != 9)
        return;
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(4),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      int num7 = random.Next(0, 5);
      int num8 = random.Next(0, 1);
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(2),
        InputArgument.op_Implicit(num7),
        InputArgument.op_Implicit(num8),
        InputArgument.op_Implicit(1)
      });
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(3),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(2),
        InputArgument.op_Implicit(1)
      });
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(4),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(5),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(6),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      int num9 = random.Next(0, 2);
      Script.Wait(1);
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(7),
        InputArgument.op_Implicit(num9),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      random.Next(0, 2);
      Script.Wait(1);
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(8),
        InputArgument.op_Implicit(2),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(9),
        InputArgument.op_Implicit(2),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(10),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1)
      });
      random.Next(0, 1);
      Script.Wait(1);
      Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
      {
        InputArgument.op_Implicit(ped),
        InputArgument.op_Implicit(11),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(1)
      });
    }

    public void Drinks()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass574_0 displayClass5740 = new Class1.\u003C\u003Ec__DisplayClass574_0();
      // ISSUE: reference to a compiler-generated field
      displayClass5740.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.DrinksMenu, nameof (Drinks));
      // ISSUE: reference to a compiler-generated field
      displayClass5740.DrinkA = new UIMenuItem("Pisswasser                                               $25");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5740.DrinkA);
      // ISSUE: reference to a compiler-generated field
      displayClass5740.DrinkB = new UIMenuItem("Vodka Shot                                              $75");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5740.DrinkB);
      // ISSUE: reference to a compiler-generated field
      displayClass5740.DrinkC = new UIMenuItem("The Mount Whiskey Shot                       $250");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5740.DrinkC);
      // ISSUE: reference to a compiler-generated field
      displayClass5740.DrinkD = new UIMenuItem("Richard's Whiskey Shot                       $1,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5740.DrinkD);
      // ISSUE: reference to a compiler-generated field
      displayClass5740.DrinkE = new UIMenuItem("Macbeth Whiskey Shot                       $5,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5740.DrinkE);
      // ISSUE: reference to a compiler-generated field
      displayClass5740.DrinkF = new UIMenuItem("Bleuter'd Champaine Slver                $30,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5740.DrinkF);
      // ISSUE: reference to a compiler-generated field
      displayClass5740.DrinkG = new UIMenuItem("Bleuter'd Champaine Gold                $50,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5740.DrinkG);
      // ISSUE: reference to a compiler-generated field
      displayClass5740.DrinkH = new UIMenuItem("Bleuter'd Champaine Diamond        $150,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5740.DrinkH);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5740, __methodptr(\u003CDrinks\u003Eb__0)));
    }

    public void CHipsM()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass575_0 displayClass5750 = new Class1.\u003C\u003Ec__DisplayClass575_0()
      {
        \u003C\u003E4__this = this,
        Chips = 10f,
        Money = 10f,
        Cash = new List<object>(),
        Multi = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.0);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.05);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.1);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.15);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.2);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.25);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.3);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.35);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.4);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.45);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.5);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.55);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.6);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.65);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.7);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.75);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.8);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 1.95);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Multi.Add((object) 2.0);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 10);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 50);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 100);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 500);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 1000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 5000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 10000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 100000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Cash.Add((object) 1000000);
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.ChipsMenu, "Chips for Money");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Buy = new UIMenuItem("Buy : " + displayClass5750.Chips.ToString("N") + "c : $" + displayClass5750.Money.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5750.Buy);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5750.list = new UIMenuListItem("Chips Amount : ", displayClass5750.Cash, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5750.list);
      UIMenuItem uiMenuItem1 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5750.C_Mp = new UIMenuListItem("Multiplier : ", displayClass5750.Multi, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5750.C_Mp);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.C_CMP = new UIMenuItem("Change Chips Multiplier");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5750.C_CMP);
      UIMenuItem uiMenuItem2 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem2);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 10);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 50);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 100);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 500);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 1000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 5000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 10000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 25000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 50000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 75000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 100000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 125000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 150000);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.Chip.Add((object) 300000);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5750.C4M = new UIMenuListItem("Amount : ", displayClass5750.Chip, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5750.C4M);
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__575.\u003C\u003Ep__2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__575.\u003C\u003Ep__2 = CallSite<Func<CallSite, System.Type, object, UIMenuItem>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, System.Type, object, UIMenuItem> target1 = Class1.\u003C\u003Eo__575.\u003C\u003Ep__2.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, System.Type, object, UIMenuItem>> p2 = Class1.\u003C\u003Eo__575.\u003C\u003Ep__2;
      System.Type type = typeof (UIMenuItem);
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__575.\u003C\u003Ep__1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__575.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, string, object> target2 = Class1.\u003C\u003Eo__575.\u003C\u003Ep__1.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, string, object>> p1 = Class1.\u003C\u003Eo__575.\u003C\u003Ep__1;
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__575.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__575.\u003C\u003Ep__0 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj1 = Class1.\u003C\u003Eo__575.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__575.\u003C\u003Ep__0, "Exchange ", displayClass5750.Chip[displayClass5750.C4M.get_Index()]);
      object obj2 = target2((CallSite) p1, obj1, "c Chips for Money");
      UIMenuItem uiMenuItem3 = target1((CallSite) p2, type, obj2);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.C_C4M = uiMenuItem3;
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5750.C_C4M);
      // ISSUE: reference to a compiler-generated field
      displayClass5750.C_C4M2 = new UIMenuItem("Exchange " + (object) this.Chips_Amount + "c Chips for Money");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5750.C_C4M2);
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass5750, __methodptr(\u003CCHipsM\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5750, __methodptr(\u003CCHipsM\u003Eb__1)));
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass5750, __methodptr(\u003CCHipsM\u003Eb__2)));
    }

    public void PlayAnim(Ped p, int Gender)
    {
      try
      {
        Random random = new Random();
        int num1 = random.Next(1, 5);
        ((Entity) p).set_FreezePosition(true);
        p.set_AlwaysKeepTask(true);
        if (Gender == 1)
        {
          if (num1 == 1)
          {
            int num2 = random.Next(1, 4);
            if (num2 == 1)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base", 8f, -1, true, -1f);
            if (num2 == 2)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_a", 8f, -1, true, -1f);
            if (num2 == 3)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_b", 8f, -1, true, -1f);
            if (num2 == 4)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          }
          if (num1 == 2)
          {
            int num2 = random.Next(1, 4);
            if (num2 == 1)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base", 8f, -1, true, -1f);
            if (num2 == 2)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_a", 8f, -1, true, -1f);
            if (num2 == 3)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_b", 8f, -1, true, -1f);
            if (num2 == 4)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_c", 8f, -1, true, -1f);
          }
          if (num1 == 3)
          {
            int num2 = random.Next(1, 4);
            if (num2 == 1)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base", 8f, -1, true, -1f);
            if (num2 == 2)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_a", 8f, -1, true, -1f);
            if (num2 == 3)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_b", 8f, -1, true, -1f);
            if (num2 == 4)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_c", 8f, -1, true, -1f);
          }
          if (num1 == 4)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_04@", "base", 8f, -1, true, -1f);
          if (num1 == 5)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_05@", "base", 8f, -1, true, -1f);
        }
        if (Gender == 2)
        {
          if (num1 == 1)
          {
            int num2 = random.Next(1, 4);
            if (num2 == 1)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base", 8f, -1, true, -1f);
            if (num2 == 2)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_a", 8f, -1, true, -1f);
            if (num2 == 3)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_b", 8f, -1, true, -1f);
            if (num2 == 4)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_c", 8f, -1, true, -1f);
          }
          if (num1 == 2)
          {
            int num2 = random.Next(1, 4);
            if (num2 == 1)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base", 8f, -1, true, -1f);
            if (num2 == 2)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_a", 8f, -1, true, -1f);
            if (num2 == 3)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_b", 8f, -1, true, -1f);
            if (num2 == 4)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_c", 8f, -1, true, -1f);
          }
          if (num1 == 3)
          {
            int num2 = random.Next(1, 4);
            if (num2 == 1)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base", 8f, -1, true, -1f);
            if (num2 == 2)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_a", 8f, -1, true, -1f);
            if (num2 == 3)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_b", 8f, -1, true, -1f);
            if (num2 == 4)
              p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_c", 8f, -1, true, -1f);
          }
          if (num1 == 4)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_05@", "base", 8f, -1, true, -1f);
          if (num1 == 5)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_05@", "base", 8f, -1, true, -1f);
        }
        this.Peds2.Add(p);
        p = (Ped) null;
        Script.Wait(10);
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Error ~w~ : Somthing went wrong with the DC&R Business, this is normal on first time load, contact ~g~HKH191~ for more info");
      }
    }

    public void AddPeds()
    {
      try
      {
        this.LoadIniFile("scripts//DC&R//Casino.ini");
        using (List<Ped>.Enumerator enumerator = this.Peds2.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            Ped current = enumerator.Current;
            if (Entity.op_Inequality((Entity) current, (Entity) null))
              ((Entity) current).Delete();
          }
        }
        if (this.PedType != 0)
          ;
        if (this.PedType == 1)
        {
          Random random = new Random();
          int num1 = random.Next(1, 100);
          if (num1 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), this.jacuzziSeat2, this.J_rot2), 2);
          else if (num1 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat2, this.J_rot2), 1);
          Script.Wait(1);
          this.IsinHottub = false;
          int num2 = random.Next(1, 100);
          if (num2 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat3, this.J_rot3), 2);
          else if (num2 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat3, this.J_rot3), 1);
          Script.Wait(1);
          int num3 = random.Next(1, 100);
          if (num3 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat4, this.J_rot4), 2);
          else if (num3 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat4, this.J_rot4), 1);
          Script.Wait(1);
          int num4 = random.Next(1, 100);
          if (num4 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat5, this.J_rot5), 2);
          else if (num4 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat5, this.J_rot5), 1);
          Script.Wait(1);
          int num5 = random.Next(1, 100);
          if (num5 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat6, this.J_rot6), 2);
          else if (num5 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat6, this.J_rot6), 1);
          Script.Wait(1);
        }
        if (this.PedType == 2)
        {
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat2, this.J_rot2), 1);
          Script.Wait(1);
          this.IsinHottub = false;
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat3, this.J_rot3), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat4, this.J_rot4), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat5, this.J_rot5), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat6, this.J_rot6), 1);
          Script.Wait(1);
        }
        if (this.PedType == 3)
        {
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat2, this.J_rot2), 1);
          Script.Wait(1);
          this.IsinHottub = false;
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat3, this.J_rot3), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat4, this.J_rot4), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat5, this.J_rot5), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -945854168), this.jacuzziSeat6, this.J_rot6), 1);
          Script.Wait(1);
        }
        if (this.PedType == 4)
        {
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat2, this.J_rot2), 1);
          Script.Wait(1);
          this.IsinHottub = false;
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat3, this.J_rot3), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat4, this.J_rot4), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat5, this.J_rot5), 1);
          Script.Wait(1);
          this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat6, this.J_rot6), 1);
          Script.Wait(1);
        }
        if (this.PedType == 5)
        {
          Random random = new Random();
          int num1 = random.Next(1, 100);
          if (num1 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat2, this.J_rot2), 2);
          else if (num1 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat2, this.J_rot2), 1);
          Script.Wait(1);
          this.IsinHottub = false;
          int num2 = random.Next(1, 100);
          if (num2 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat3, this.J_rot3), 2);
          else if (num2 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat3, this.J_rot3), 1);
          Script.Wait(1);
          int num3 = random.Next(1, 100);
          if (num3 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat4, this.J_rot4), 2);
          else if (num3 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat4, this.J_rot4), 1);
          Script.Wait(1);
          int num4 = random.Next(1, 100);
          if (num4 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat5, this.J_rot5), 2);
          else if (num4 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat5, this.J_rot5), 1);
          Script.Wait(1);
          int num5 = random.Next(1, 100);
          if (num5 < 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) 1077785853), this.jacuzziSeat6, this.J_rot6), 2);
          else if (num5 > 50)
            this.PlayAnim(World.CreatePed(this.RequestModel((PedHash) -1661836925), this.jacuzziSeat6, this.J_rot6), 1);
          Script.Wait(1);
        }
        if ((uint) this.PedType2 <= 0U)
          return;
        Ped ped1 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(953.3083f, 55.07329f, 110.5f), -120f);
        ((Entity) ped1).set_FreezePosition(true);
        if (ped1.get_Gender() == 1)
          this.PlayAnim(ped1, 1);
        else if (ped1.get_Gender() == 0)
          this.PlayAnim(ped1, 2);
        Ped ped2 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(953.311f, 52.398f, 110.5f), -36f);
        ((Entity) ped2).set_FreezePosition(true);
        if (ped2.get_Gender() == 1)
          this.PlayAnim(ped2, 1);
        else if (ped2.get_Gender() == 0)
          this.PlayAnim(ped2, 2);
        Ped ped3 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(955.2153f, 52.89155f, 110.5f), 62f);
        ((Entity) ped3).set_FreezePosition(true);
        if (ped3.get_Gender() == 1)
          this.PlayAnim(ped3, 1);
        else if (ped3.get_Gender() == 0)
          this.PlayAnim(ped3, 2);
        Ped ped4 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(940.9825f, 33.0413f, 110.5f), -25f);
        ((Entity) ped4).set_FreezePosition(true);
        if (ped4.get_Gender() == 1)
          this.PlayAnim(ped4, 1);
        else if (ped4.get_Gender() == 0)
          this.PlayAnim(ped4, 2);
        Ped ped5 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(942.0065f, 35.54335f, 110.5f), 141f);
        ((Entity) ped5).set_FreezePosition(true);
        if (ped5.get_Gender() == 1)
          this.PlayAnim(ped5, 1);
        else if (ped5.get_Gender() == 0)
          this.PlayAnim(ped5, 2);
        Ped ped6 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(940.6028f, 34.68548f, 110.5f), -127f);
        ((Entity) ped6).set_FreezePosition(true);
        if (ped6.get_Gender() == 1)
          this.PlayAnim(ped6, 1);
        else if (ped6.get_Gender() == 0)
          this.PlayAnim(ped6, 2);
        Ped ped7 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(942.8467f, 33.18393f, 110.5f), 51f);
        ((Entity) ped7).set_FreezePosition(true);
        if (ped7.get_Gender() == 1)
          this.PlayAnim(ped7, 1);
        else if (ped7.get_Gender() == 0)
          this.PlayAnim(ped7, 2);
        Ped ped8 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(934.5349f, 24.71686f, 110.5f), -127f);
        ((Entity) ped8).set_FreezePosition(true);
        if (ped8.get_Gender() == 1)
          this.PlayAnim(ped8, 1);
        else if (ped8.get_Gender() == 0)
          this.PlayAnim(ped8, 2);
        Ped ped9 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(936.165f, 25.40634f, 110.5f), 145f);
        ((Entity) ped9).set_FreezePosition(true);
        if (ped9.get_Gender() == 1)
          this.PlayAnim(ped9, 1);
        else if (ped9.get_Gender() == 0)
          this.PlayAnim(ped9, 2);
        Ped ped10 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(936.542f, 23.40832f, 110.5f), 50f);
        ((Entity) ped10).set_FreezePosition(true);
        if (ped10.get_Gender() == 1)
          this.PlayAnim(ped10, 1);
        else if (ped10.get_Gender() == 0)
          this.PlayAnim(ped10, 2);
        Ped ped11 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(935.2886f, 22.94011f, 110.5f), -36f);
        ((Entity) ped11).set_FreezePosition(true);
        if (ped11.get_Gender() == 1)
          this.PlayAnim(ped11, 1);
        else if (ped11.get_Gender() == 0)
          this.PlayAnim(ped11, 2);
        Ped ped12 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(947.1208f, 42.71227f, 110.5f), -39f);
        ((Entity) ped12).set_FreezePosition(true);
        if (ped12.get_Gender() == 1)
          this.PlayAnim(ped12, 1);
        else if (ped12.get_Gender() == 0)
          this.PlayAnim(ped12, 2);
        Ped ped13 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(946.7648f, 44.66558f, 110.5f), -110f);
        ((Entity) ped13).set_FreezePosition(true);
        if (ped13.get_Gender() == 1)
          this.PlayAnim(ped13, 1);
        else if (ped13.get_Gender() == 0)
          this.PlayAnim(ped13, 2);
        Ped ped14 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(949.2073f, 43.63372f, 110.5f), 61f);
        ((Entity) ped14).set_FreezePosition(true);
        if (ped14.get_Gender() == 1)
          this.PlayAnim(ped14, 1);
        else if (ped14.get_Gender() == 0)
          this.PlayAnim(ped14, 2);
        Random random1 = new Random();
        random1.Next(0, 100);
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(921.5018f, 12.25483f, 111f), 152f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(915.2754f, 11.18526f, 111f), 148f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(912.9713f, 12.28778f, 111f), 130f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(915.5112f, 22.36289f, 111f), 151f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(916.7951f, 21.65291f, 111f), 142f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(932.4772f, 3.29761f, 111.8f), 59f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(931.7728f, 2.344149f, 111.8f), 59f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(908.9769f, 13.32108f, 111.8f), -135f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(909.8641f, 14.7124f, 111.8f), -107f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PoolPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(911.2299f, 17.0978f, 111.6f), -133f);
          ((Entity) ped15).set_FreezePosition(true);
          if (ped15.get_Gender() == 1)
            this.PlayAnim(ped15, 1);
          else if (ped15.get_Gender() == 0)
            this.PlayAnim(ped15, 2);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(957.655f, 53.03374f, 111.6f), -125f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(959.2653f, 55.53594f, 111.6f), -121f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(956.4926f, 50.66952f, 111.6f), -161f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(954.621f, 48.17428f, 111.6f), -90f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(951.3824f, 43.31479f, 111.6f), -97f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(950.2207f, 41.03412f, 111.6f), -170f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(948.5749f, 38.27188f, 111.6f), -92f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(946.7883f, 36.35806f, 111.6f), -166f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(945.3374f, 33.7608f, 111.6f), -94f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(939.468f, 25.97402f, 111.6f), -148f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(936.361f, 19.49258f, 111.6f), -99f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(933.9913f, 30.51657f, 111.2f), 163f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(935.5774f, 29.05956f, 111.6f), 38f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(933.9769f, 28.98641f, 111.6f), -21f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(939.7352f, 42.60273f, 111.2f), 41f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(939.3006f, 41.71557f, 111.2f), 83f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(947.8397f, 52.24321f, 111.2f), -52f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(949.8629f, 52.18896f, 111.6f), 125f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(948.2167f, 53.71968f, 111.6f), -178f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(915.6156f, 39.01409f, 110.2f), 21f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(914.2751f, 39.03038f, 110.2f), -55f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(915.8612f, 40.56638f, 110.6f), 150f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(918.8865f, 54.37997f, 110.6f), -72f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(920.8691f, 53.79646f, 110.6f), 26f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(919.7262f, 56.98275f, 110.2f), -157f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(911.275f, 51.34739f, 110.2f), 28f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(910.2062f, 50.94262f, 110.2f), 3f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(909.1746f, 51.04686f, 110.2f), -24f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(914.95f, 59.79315f, 110.6f), 24f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(913.1617f, 60.00733f, 110.6f), -164f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        int num = random1.Next(0, 100);
        if (num < this.PartyPedChance)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel(this.PedType2)), new Vector3(913.2501f, 62.30947f, 110.6f), -138f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().StartScenario("WORLD_HUMAN_PARTYING", ((Entity) ped15).get_Position());
          this.Peds2.Add(ped15);
        }
        if (num < this.SunbatherPedChamce)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(930.5168f, 25.97536f, 111.95f), -133f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("amb@world_human_sunbathe@female@back@base", "base", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.SunbatherPedChamce)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(943.1041f, 45.63772f, 111.95f), -129f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("amb@world_human_sunbathe@female@back@base", "base", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.SunbatherPedChamce)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(944.0278f, 60.01755f, 113.4f), -129f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("amb@world_human_sunbathe@female@back@base", "base", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.SunbatherPedChamce)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(937.7003f, 50.1327f, 113.4f), -129f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("amb@world_human_sunbathe@female@back@base", "base", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.SunbatherPedChamce)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(937.2131f, 50.67082f, 113.4f), -129f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("amb@world_human_sunbathe@female@back@base", "base", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        if (random1.Next(0, 100) < this.SunbatherPedChamce)
        {
          Ped ped15 = World.CreatePed(this.RequestModel(this.GetpedModel2(this.PedType)), new Vector3(925.7509f, 30.42949f, 113.4f), -129f);
          ((Entity) ped15).set_FreezePosition(true);
          ped15.get_Task().PlayAnimation("amb@world_human_sunbathe@female@back@base", "base", 8f, -1, true, -1f);
          this.Peds2.Add(ped15);
        }
        using (List<Ped>.Enumerator enumerator = this.Peds2.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            Ped current = enumerator.Current;
            if (Entity.op_Inequality((Entity) current, (Entity) null))
            {
              Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
              {
                InputArgument.op_Implicit(current),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
              {
                InputArgument.op_Implicit(current),
                InputArgument.op_Implicit(17),
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
              {
                InputArgument.op_Implicit(current),
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
              {
                InputArgument.op_Implicit(current),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
              {
                InputArgument.op_Implicit(current),
                InputArgument.op_Implicit(17),
                InputArgument.op_Implicit(1)
              });
              current.set_RelationshipGroup(1);
              current.set_AlwaysKeepTask(true);
            }
          }
        }
      }
      catch (Exception ex)
      {
        using (List<Ped>.Enumerator enumerator = this.Peds2.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            Ped current = enumerator.Current;
            if (Entity.op_Inequality((Entity) current, (Entity) null))
              ((Entity) current).Delete();
          }
        }
        this.CreatedPeds2 = false;
        UI.Notify("~r~DC&R Error ~w~ : Somthing has gone wrong with loading the Terrace & Penthouse Peds, Attempting to spawn them again");
      }
    }

    public PedHash GetpedModel2(int p)
    {
      PedHash pedHash = (PedHash) -1661836925;
      int num = new Random().Next(1, 100);
      if (p == 1)
      {
        if (num < 50)
          pedHash = (PedHash) 1077785853;
        else if (num > 50)
          pedHash = (PedHash) -945854168;
      }
      if (p == 2)
        pedHash = (PedHash) 1077785853;
      if (p == 3)
        pedHash = (PedHash) -945854168;
      if (p == 4)
        pedHash = (PedHash) -1661836925;
      if (p == 5)
      {
        if (num < 50)
          pedHash = (PedHash) 1077785853;
        else if (num > 50)
          pedHash = (PedHash) -1661836925;
      }
      if (p == 6)
      {
        Random random = new Random();
        if (this.CustomTerracePeds.Count > 0)
        {
          int index = random.Next(0, this.CustomTerracePeds.Count);
          Script.Wait(1);
          pedHash = this.CustomTerracePeds[index];
        }
        else if (this.CustomTerracePeds.Count <= 0)
        {
          if (num < 50)
            pedHash = (PedHash) 1077785853;
          else if (num > 50)
            pedHash = (PedHash) -1661836925;
        }
      }
      return pedHash;
    }

    public PedHash GetpedModel(int p)
    {
      PedHash pedHash = (PedHash) -1661836925;
      int num = new Random().Next(1, 100);
      if (p == 1)
      {
        if (num < 50)
          pedHash = (PedHash) 1077785853;
        else if (num > 50)
          pedHash = (PedHash) -945854168;
      }
      if (p == 2)
        pedHash = (PedHash) 1077785853;
      if (p == 3)
        pedHash = (PedHash) -945854168;
      if (p == 4)
        pedHash = (PedHash) -1661836925;
      if (p == 5)
      {
        if (num < 50)
          pedHash = (PedHash) 1077785853;
        else if (num > 50)
          pedHash = (PedHash) -1661836925;
      }
      if (p == 6)
      {
        Random random = new Random();
        if (this.CustomTerracePeds.Count > 0)
        {
          int index = random.Next(0, this.CustomTerracePeds.Count);
          Script.Wait(1);
          pedHash = this.CustomTerracePeds[index];
        }
        else if (this.CustomTerracePeds.Count <= 0)
        {
          if (num < 50)
            pedHash = (PedHash) 1077785853;
          else if (num > 50)
            pedHash = (PedHash) -1661836925;
        }
      }
      return pedHash;
    }

    public void MiscMenu()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass580_0 displayClass5800 = new Class1.\u003C\u003Ec__DisplayClass580_0()
      {
        \u003C\u003E4__this = this,
        TF = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass5800.TF.Add((object) true);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.TF.Add((object) false);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 100);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 95);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 90);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 85);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 80);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 75);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 70);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 65);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 60);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 55);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 50);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 45);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 40);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 35);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 30);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 25);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 20);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 15);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChNC.Add((object) 10);
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "None");
      objectList1.Add((object) "Male & Female");
      objectList1.Add((object) "Male");
      objectList1.Add((object) "Female");
      objectList1.Add((object) "Female - Topless");
      objectList1.Add((object) "Male & Female - Topless");
      List<object> objectList2 = new List<object>();
      objectList2.Add((object) "None");
      objectList2.Add((object) "Male & Female");
      objectList2.Add((object) "Male");
      objectList2.Add((object) "Female");
      objectList2.Add((object) "Female - Topless");
      objectList2.Add((object) "Male & Female - Topless");
      objectList2.Add((object) "Custom - From Ini");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.BColour = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5800.BColour.Add((object) (BlipColor) 2);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.BColour.Add((object) (BlipColor) 3);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.BColour.Add((object) (BlipColor) 66);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.BColour.Add((object) (BlipColor) 1);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.BColour.Add((object) (BlipColor) 50);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.BColour.Add((object) (BlipColor) 61);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.MColour = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5800.MColour.Add((object) "Green");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.MColour.Add((object) "Blue");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.MColour.Add((object) "Yellow");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.MColour.Add((object) "Red");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.MColour.Add((object) "Purple");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.MColour.Add((object) "Pink");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.UiColour = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5800.UiColour.Add((object) "   g   ");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.UiColour.Add((object) "   b   ");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.UiColour.Add((object) "   y  ");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.UiColour.Add((object) "   r   ");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.UiColour.Add((object) "   p   ");
      // ISSUE: reference to a compiler-generated field
      displayClass5800.UiColour.Add((object) "   m   ");
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.Misc, "Misc");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.MC = new UIMenuListItem("Marker Color : ", displayClass5800.MColour, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.MC);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.BC = new UIMenuListItem("Blip Color : ", displayClass5800.BColour, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.BC);
      UIMenuItem uiMenuItem1 = new UIMenuItem("Current Host : " + this.GetHostName());
      uiMenu.AddItem(uiMenuItem1);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.SetHN = new UIMenuItem("Set Host Name");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.SetHN);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.uiC = new UIMenuListItem("UI Color : ", displayClass5800.UiColour, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.uiC);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Setall = new UIMenuItem("Save All");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.Setall);
      UIMenuItem uiMenuItem2 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem2);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.PedO = new UIMenuListItem("Jacuzzi Peds  : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.PedO);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChangePeds = new UIMenuItem("Change peds in Jacuzzi");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.ChangePeds);
      UIMenuItem uiMenuItem3 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem3);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.PedO2 = new UIMenuListItem("Terrace Peds : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.PedO2);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChangePeds2 = new UIMenuItem("Change peds in Terrace Area");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.ChangePeds2);
      UIMenuItem uiMenuItem4 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem4);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.PoolPeds = new UIMenuListItem("Party Peds Chance : ", displayClass5800.ChNC, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.PoolPeds);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChangePoolPeds = new UIMenuItem("Change Party Peds Chance");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.ChangePoolPeds);
      UIMenuItem uiMenuItem5 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem5);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.PartyPeds = new UIMenuListItem("Pool Peds Chance : ", displayClass5800.ChNC, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.PartyPeds);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.ChangePartyPeds = new UIMenuItem("Change Pool Peds Chance");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.ChangePartyPeds);
      UIMenuItem uiMenuItem6 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem6);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_BarPedsT = new UIMenuListItem("Bar Peds Enabled : ", displayClass5800.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.Enable_BarPedsT);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_BarPeds = new UIMenuItem("Change Bar Peds Enabled/Disabled");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.Enable_BarPeds);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_BarPeds.set_Description("Disable/Enable Any Ped that is at the Bar Area");
      UIMenuItem uiMenuItem7 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem7);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_SlotPedsT = new UIMenuListItem("Slot Machine Peds Enabled : ", displayClass5800.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.Enable_SlotPedsT);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_SlotPeds = new UIMenuItem("Change Slot Machine Peds Enabled/Disabled");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.Enable_SlotPeds);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_SlotPeds.set_Description("Disable/Enable Any Ped that is using Slot Machine");
      UIMenuItem uiMenuItem8 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem8);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_MainPedsT = new UIMenuListItem("Main Peds Enabled : ", displayClass5800.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.Enable_MainPedsT);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_MainPeds = new UIMenuItem("Change Main Peds Enabled/Disabled");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.Enable_MainPeds);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_MainPeds.set_Description("Disable/Enable Any Ped that is related to the Diamond Casino Update");
      UIMenuItem uiMenuItem9 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem9);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_RandomWPedsT = new UIMenuListItem("Random Wander Peds Enabled : ", displayClass5800.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.Enable_RandomWPedsT);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_RandomWPeds = new UIMenuItem("Random Wander Main Peds Enabled/Disabled");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.Enable_RandomWPeds);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_RandomWPeds.set_Description("Disable/Enable Any Ped that is wandering around that is a random ped model");
      UIMenuItem uiMenuItem10 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem10);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_MWPedsT = new UIMenuListItem("Main Wander Peds Enabled : ", displayClass5800.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.Enable_MWPedsT);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_MWPeds = new UIMenuItem("Main Wander Main Peds Enabled/Disabled");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.Enable_MWPeds);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_MWPeds.set_Description("Disable/Enable Any Ped that is wandering around that is not a random ped model");
      UIMenuItem uiMenuItem11 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem11);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_McPedsT = new UIMenuListItem("Misc Peds Enabled : ", displayClass5800.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5800.Enable_McPedsT);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_McPeds = new UIMenuItem("Misc Peds Enabled/Disabled");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5800.Enable_McPeds);
      // ISSUE: reference to a compiler-generated field
      displayClass5800.Enable_MWPeds.set_Description("Disable/Enable Any Ped that is standing around in the Casino Interior");
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5800, __methodptr(\u003CMiscMenu\u003Eb__0)));
    }

    public void PenthouseOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass581_0 displayClass5810 = new Class1.\u003C\u003Ec__DisplayClass581_0();
      // ISSUE: reference to a compiler-generated field
      displayClass5810.\u003C\u003E4__this = this;
      this.LoadIniFile("scripts//DC&R//Casino.ini");
      this.SetupArtMenu();
      this.GrabArtWork2();
      this.GrabArtWork();
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Cost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5810.StyleCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5810.BarCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5810.SpaCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5810.MediaCost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5810.ExtraB_Cost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5810.PDcost = 0.0f;
      // ISSUE: reference to a compiler-generated field
      displayClass5810.TF = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5810.TF.Add((object) false);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.TF.Add((object) true);
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "Style 1");
      objectList1.Add((object) "Style 2");
      objectList1.Add((object) "Style 3");
      objectList1.Add((object) "Style 4");
      objectList1.Add((object) "Style 5");
      objectList1.Add((object) "Style 6");
      objectList1.Add((object) "Style 7");
      objectList1.Add((object) "Style 8");
      objectList1.Add((object) "Style 9");
      List<object> objectList2 = new List<object>();
      objectList2.Add((object) "No Bar");
      objectList2.Add((object) "Bar Included");
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) "No Spa");
      objectList3.Add((object) "Spa Included");
      List<object> objectList4 = new List<object>();
      objectList4.Add((object) "No Media Room");
      objectList4.Add((object) "Media Room Included");
      List<object> objectList5 = new List<object>();
      objectList5.Add((object) "No Extra Room");
      objectList5.Add((object) "Extra Room Included");
      List<object> objectList6 = new List<object>();
      objectList6.Add((object) "Bar Light 1");
      objectList6.Add((object) "Bar Light 2");
      objectList6.Add((object) "Bar Light 3");
      List<object> objectList7 = new List<object>();
      objectList7.Add((object) "No Poker/Blackjack Dealer");
      objectList7.Add((object) "Poker/Blackjack Dealer Included");
      List<object> objectList8 = new List<object>();
      objectList8.Add((object) "Retro Arcade");
      objectList8.Add((object) "Modern Arcade");
      List<object> objectList9 = new List<object>();
      objectList9.Add((object) "Multicolor");
      objectList9.Add((object) "Timeless");
      objectList9.Add((object) "Vibrent");
      objectList9.Add((object) "Sharp");
      this.submenu14s = this.modMenuPool.AddSubMenu(this.Pent_Menu, "Art Options");
      this.submenu13s = this.modMenuPool.AddSubMenu(this.submenu14s, "Sculpture Options");
      // ISSUE: reference to a compiler-generated field
      displayClass5810.s = new UIMenuListItem("Sculpture : ", this.SculptProp, 0);
      // ISSUE: reference to a compiler-generated field
      this.submenu13s.AddItem((UIMenuItem) displayClass5810.s);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.loc2 = new UIMenuListItem("Location : ", this.SculptLoc, 0);
      // ISSUE: reference to a compiler-generated field
      this.submenu13s.AddItem((UIMenuItem) displayClass5810.loc2);
      this.submenu13s.AddItem(new UIMenuItem("Rotate Object press ~INPUT_COVER~/~INPUT_CONTEXT~"));
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Buysculpt = new UIMenuItem("Place Scultpture : $100,000");
      // ISSUE: reference to a compiler-generated field
      this.submenu13s.AddItem(displayClass5810.Buysculpt);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.RES = new UIMenuItem("Remove All Scultpture ");
      // ISSUE: reference to a compiler-generated field
      this.submenu13s.AddItem(displayClass5810.RES);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.RES.set_Description("This May cause the game to freeze for a second, please be patient");
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Buysculpt.set_Description("Sculpture positions are Marked in Red");
      this.submenu13s.AddItem(new UIMenuItem("-----------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Pevart2 = new UIMenuListItem("Preview Design : ", displayClass5810.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.submenu13s.AddItem((UIMenuItem) displayClass5810.Pevart2);
      // ISSUE: method pointer
      this.submenu13s.add_OnListChange(new ListChangedEvent((object) displayClass5810, __methodptr(\u003CPenthouseOptions\u003Eb__0)));
      // ISSUE: method pointer
      this.submenu13s.add_OnItemSelect(new ItemSelectEvent((object) displayClass5810, __methodptr(\u003CPenthouseOptions\u003Eb__1)));
      this.submenu12s = this.modMenuPool.AddSubMenu(this.submenu14s, "Painting Options");
      this.submenu12s.AddItem(new UIMenuItem("-----------------------Paintings--------------------------"));
      // ISSUE: reference to a compiler-generated field
      displayClass5810.p = new UIMenuListItem("Painting : ", this.PaintProp, 0);
      // ISSUE: reference to a compiler-generated field
      this.submenu12s.AddItem((UIMenuItem) displayClass5810.p);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.loc = new UIMenuListItem("Location : ", this.PLocations, 0);
      // ISSUE: reference to a compiler-generated field
      this.submenu12s.AddItem((UIMenuItem) displayClass5810.loc);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Buyart = new UIMenuItem("Put up Artwork : $100,000");
      // ISSUE: reference to a compiler-generated field
      this.submenu12s.AddItem(displayClass5810.Buyart);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.REP = new UIMenuItem("Remove All Paintings ");
      // ISSUE: reference to a compiler-generated field
      this.submenu12s.AddItem(displayClass5810.REP);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.REP.set_Description("This May cause the game to freeze for a second, please be patient");
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Buyart.set_Description("Painting positions are Marked in Green");
      this.submenu12s.AddItem(new UIMenuItem("-----------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Pevart = new UIMenuListItem("Preview Design : ", displayClass5810.TF, 0);
      // ISSUE: reference to a compiler-generated field
      this.submenu12s.AddItem((UIMenuItem) displayClass5810.Pevart);
      // ISSUE: method pointer
      this.submenu12s.add_OnListChange(new ListChangedEvent((object) displayClass5810, __methodptr(\u003CPenthouseOptions\u003Eb__2)));
      // ISSUE: method pointer
      this.submenu12s.add_OnItemSelect(new ItemSelectEvent((object) displayClass5810, __methodptr(\u003CPenthouseOptions\u003Eb__3)));
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.Pent_Menu, "Penthouse");
      // ISSUE: reference to a compiler-generated field
      displayClass5810.S = new UIMenuListItem("Style : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.S);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.B = new UIMenuListItem("Bar : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.B);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Sp = new UIMenuListItem("Spa : ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.Sp);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.M = new UIMenuListItem("Media Room  : ", objectList4, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.M);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.EB = new UIMenuListItem("Extra Bedroom : ", objectList5, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.EB);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.BL = new UIMenuListItem("Bar Light : ", objectList6, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.BL);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.PD = new UIMenuListItem("Poker Dealer: ", objectList7, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.PD);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.A = new UIMenuListItem("Arcade : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.A);
      // ISSUE: reference to a compiler-generated field
      displayClass5810.C = new UIMenuListItem("Colour : ", objectList9, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.C);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Buy = new UIMenuItem("Buy " + displayClass5810.Cost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5810.Buy);
      UIMenuItem uiMenuItem = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5810.Pev = new UIMenuListItem("Preview Design : ", displayClass5810.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5810.Pev);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5810, __methodptr(\u003CPenthouseOptions\u003Eb__4)));
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass5810, __methodptr(\u003CPenthouseOptions\u003Eb__5)));
    }

    public void CasinoOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass582_0 displayClass5820 = new Class1.\u003C\u003Ec__DisplayClass582_0();
      // ISSUE: reference to a compiler-generated field
      displayClass5820.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.Casino_Menu, "Memberships");
      // ISSUE: reference to a compiler-generated field
      displayClass5820.Basic = new UIMenuItem("Basic Membership : $500");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5820.Basic);
      // ISSUE: reference to a compiler-generated field
      displayClass5820.Basic.set_Description("Basic Membership, No Penthouse, No rooftop access, No garage, no Busines access, used for playing the games");
      // ISSUE: reference to a compiler-generated field
      displayClass5820.Business = new UIMenuItem("Business Membership : $1,500,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5820.Business);
      // ISSUE: reference to a compiler-generated field
      displayClass5820.Business.set_Description("Business Membership, No Penthouse, No rooftop access, No garage, full Business access starting on business level 1");
      // ISSUE: reference to a compiler-generated field
      displayClass5820.Vip = new UIMenuItem("VIP Membership : $6,000,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5820.Vip);
      // ISSUE: reference to a compiler-generated field
      displayClass5820.Vip.set_Description("Vip Membership, Full Penthouse, Full rooftop access, 35 car garage, full Business access starting on business level 1");
      // ISSUE: reference to a compiler-generated field
      displayClass5820.VipPlus = new UIMenuItem("VIP+  Membership : $12,000,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5820.VipPlus);
      // ISSUE: reference to a compiler-generated field
      displayClass5820.VipPlus.set_Description("Vip Membership, Full Penthouse, Full rooftop access, 35 car garage, full Business access starting on business level 10");
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5820, __methodptr(\u003CCasinoOptions\u003Eb__0)));
    }

    public void ChipsOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass583_0 displayClass5830 = new Class1.\u003C\u003Ec__DisplayClass583_0()
      {
        \u003C\u003E4__this = this,
        Chips = 10f,
        Money = 10f,
        Cash = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 10);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 50);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 100);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 500);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 1000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 5000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 10000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 100000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Cash.Add((object) 1000000);
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.Chips_Menu, "Chips for Money");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Buy = new UIMenuItem("Buy : " + displayClass5830.Chips.ToString("N") + "c : $" + displayClass5830.Money.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5830.Buy);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5830.list = new UIMenuListItem("Chips Amount : ", displayClass5830.Cash, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5830.list);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 10);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 50);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 100);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 500);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 1000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 5000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 10000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 25000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 50000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 75000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 100000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 125000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 150000);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.Chip.Add((object) 300000);
      UIMenuItem uiMenuItem1 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5830.C4M = new UIMenuListItem("Amount : ", displayClass5830.Chip, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass5830.C4M);
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__583.\u003C\u003Ep__2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__583.\u003C\u003Ep__2 = CallSite<Func<CallSite, System.Type, object, UIMenuItem>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, System.Type, object, UIMenuItem> target1 = Class1.\u003C\u003Eo__583.\u003C\u003Ep__2.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, System.Type, object, UIMenuItem>> p2 = Class1.\u003C\u003Eo__583.\u003C\u003Ep__2;
      System.Type type = typeof (UIMenuItem);
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__583.\u003C\u003Ep__1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__583.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, string, object> target2 = Class1.\u003C\u003Eo__583.\u003C\u003Ep__1.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, string, object>> p1 = Class1.\u003C\u003Eo__583.\u003C\u003Ep__1;
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__583.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__583.\u003C\u003Ep__0 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj1 = Class1.\u003C\u003Eo__583.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__583.\u003C\u003Ep__0, "Exchange ", displayClass5830.Chip[displayClass5830.C4M.get_Index()]);
      object obj2 = target2((CallSite) p1, obj1, "c Chips for Money");
      UIMenuItem uiMenuItem2 = target1((CallSite) p2, type, obj2);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.C_C4M = uiMenuItem2;
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5830.C_C4M);
      // ISSUE: reference to a compiler-generated field
      displayClass5830.C_C4M2 = new UIMenuItem("Exchange " + (object) this.Chips_Amount + "c Chips for Money");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5830.C_C4M2);
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass5830, __methodptr(\u003CChipsOptions\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5830, __methodptr(\u003CChipsOptions\u003Eb__1)));
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass5830, __methodptr(\u003CChipsOptions\u003Eb__2)));
    }

    public void ShowIncrease()
    {
      UI.Notify("Level: " + (object) this.purchaselvl);
      UI.Notify("Max Stocks: " + (object) this.maxstocks);
      UI.Notify("Annual Gain: $" + this.increaseGain.ToString("N"));
      UI.Notify("Mission Gain: " + (object) this.profitMargin + "%");
      UI.Notify("Stock Value: $" + this.stocksvalue.ToString("N"));
    }

    public VehicleHash RandomVehicleFun()
    {
      int num = new Random().Next(1, 13);
      if (num == 1)
        this.RandomVehicle = (VehicleHash) -808831384;
      if (num == 2)
        this.RandomVehicle = (VehicleHash) 80636076;
      if (num == 3)
        this.RandomVehicle = (VehicleHash) 723973206;
      if (num == 4)
        this.RandomVehicle = (VehicleHash) -1045541610;
      if (num == 5)
        this.RandomVehicle = (VehicleHash) -1685021548;
      if (num == 6)
        this.RandomVehicle = (VehicleHash) -1255452397;
      if (num == 7)
        this.RandomVehicle = (VehicleHash) 1923400478;
      if (num == 8)
        this.RandomVehicle = (VehicleHash) 1951180813;
      if (num == 9)
        this.RandomVehicle = (VehicleHash) -1622444098;
      if (num == 10)
        this.RandomVehicle = (VehicleHash) 1203490606;
      if (num == 11)
        this.RandomVehicle = (VehicleHash) -140902153;
      if (num == 12)
        this.RandomVehicle = (VehicleHash) 970598228;
      if (num == 13)
        this.RandomVehicle = (VehicleHash) 788045382;
      if (num > 13)
        this.RandomVehicle = (VehicleHash) 349605904;
      return this.RandomVehicle;
    }

    public Vector3 Randomlocation()
    {
      Random random = new Random();
      int num = random.Next(1, 13);
      if (num == 1)
        this.VehicleSpawn = new Vector3(-1069.32f, -72.28f, 19f);
      if (num == 2)
        this.VehicleSpawn = new Vector3(-1579.93f, -155.28f, 55f);
      if (num == 3)
        this.VehicleSpawn = new Vector3(-711.74f, -28.28f, 37f);
      if (num == 4)
        this.VehicleSpawn = new Vector3(6f, 253.58f, 109f);
      if (num == 5)
        this.VehicleSpawn = new Vector3(703f, 32f, 84f);
      if (num == 6)
        this.VehicleSpawn = new Vector3(1197f, -421.5f, 68f);
      if (num == 7)
        this.VehicleSpawn = new Vector3(1257f, -1428f, 35f);
      if (num == 8)
        this.VehicleSpawn = new Vector3(1264f, -2039f, 45f);
      if (num == 9)
        this.VehicleSpawn = new Vector3(527f, -2052f, 28f);
      if (num == 10)
        this.VehicleSpawn = new Vector3(-161f, -2087.8f, 26f);
      if (random.Next(1, 13) == 11)
        this.VehicleSpawn = new Vector3(756f, -1723f, 30f);
      if (num == 12)
        this.VehicleSpawn = new Vector3(-816f, -2300f, 11f);
      if (num == 13)
        this.VehicleSpawn = new Vector3(-1839f, 136f, 78f);
      if (num > 13)
        this.VehicleSpawn = new Vector3(756f, -1723f, 30f);
      return this.VehicleSpawn;
    }

    public VehicleColor GetColor()
    {
      List<object> objectList = new List<object>();
      VehicleColor[] values = (VehicleColor[]) Enum.GetValues(typeof (VehicleColor));
      for (int index = 0; index < values.Length; ++index)
        objectList.Add((object) (VehicleColor) (int) values[index]);
      int index1 = new Random().Next(1, values.Length);
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__587.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__587.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, VehicleColor>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (VehicleColor), typeof (Class1)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return Class1.\u003C\u003Eo__587.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__587.\u003C\u003Ep__0, objectList[index1]);
    }

    public float GetTableHeight_Cards(int Table)
    {
      UI.Notify("T " + (object) Table);
      float num = 0.0f;
      if (Table < 4)
        num = 0.9f;
      if (Table == 4)
        num = 0.41f;
      return num;
    }

    public float GetTableHeight_Chips(int Table)
    {
      UI.Notify("T " + (object) Table);
      float num = 0.0f;
      if (Table < 4)
        num = 0.0f;
      if (Table == 4)
        num = 0.6f;
      return num;
    }

    private void SetupSpecialMissions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass590_0 displayClass5900 = new Class1.\u003C\u003Ec__DisplayClass590_0();
      // ISSUE: reference to a compiler-generated field
      displayClass5900.\u003C\u003E4__this = this;
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.SpecialMissions, "Normal Missions");
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(uiMenu1, "Property Investment");
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Pi1 = new UIMenuItem("Vinewood Hills");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5900.Pi1);
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Pi2 = new UIMenuItem("Sandy Shores");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5900.Pi2);
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Pi3 = new UIMenuItem("Paleto Bay");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5900.Pi3);
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass5900, __methodptr(\u003CSetupSpecialMissions\u003Eb__0)));
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(uiMenu1, "Going the Mile");
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Gtm1 = new UIMenuItem("LSIA");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass5900.Gtm1);
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Gtm2 = new UIMenuItem("Sandy Shores");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass5900.Gtm2);
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Gtm3 = new UIMenuItem("Paleto Bay");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass5900.Gtm3);
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass5900, __methodptr(\u003CSetupSpecialMissions\u003Eb__1)));
      this.modMenuPool.AddSubMenu(uiMenu1, "Mission 3");
      UIMenu uiMenu4 = this.modMenuPool.AddSubMenu(this.SpecialMissions, "Special Missions");
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Race1 = new UIMenuItem("Play To Win");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass5900.Race1);
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Race2 = new UIMenuItem("Bad Beaf ");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass5900.Race2);
      // ISSUE: reference to a compiler-generated field
      displayClass5900.Race3 = new UIMenuItem("Cashing Out");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass5900.Race3);
      UIMenuItem uiMenuItem = new UIMenuItem("One Armed Bandit (Comming Soon)");
      uiMenu4.AddItem(uiMenuItem);
      // ISSUE: method pointer
      uiMenu4.add_OnItemSelect(new ItemSelectEvent((object) displayClass5900, __methodptr(\u003CSetupSpecialMissions\u003Eb__2)));
    }

    private void ChooseVehicle(int i)
    {
      if (i == 1)
      {
        this.carid = "Mogul";
        this.VehicleMissioncar = World.CreateVehicle(new Model(-749299473), this.VehicleLocation);
        this.VehicleMissioncar.PlaceOnGround();
      }
      if (i == 2)
      {
        this.carid = "Cuban 800";
        this.VehicleMissioncar = World.CreateVehicle(Model.op_Implicit((VehicleHash) -644710429), this.VehicleLocation);
        this.VehicleMissioncar.PlaceOnGround();
      }
      if (i == 3)
      {
        this.carid = "Duster";
        this.VehicleMissioncar = World.CreateVehicle(Model.op_Implicit((VehicleHash) 970356638), this.VehicleLocation);
        this.VehicleMissioncar.PlaceOnGround();
      }
      if (i != 4)
        return;
      this.carid = "Mammatus";
      this.VehicleMissioncar = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1746576111), this.VehicleLocation);
      this.VehicleMissioncar.PlaceOnGround();
    }

    public void GetVehicle(Model V, Vector3 S, float R)
    {
      if (Entity.op_Inequality((Entity) this.AirVehicle, (Entity) null))
      {
        ((Entity) this.AirVehicle).Delete();
        this.AirVehicle = World.CreateVehicle(V, S, R);
        Model model1 = ((Entity) this.AirVehicle).get_Model();
        if (((Model) ref model1).get_IsCar())
        {
          UI.Notify(this.GetHostName() + " : your " + this.AirVehicle.get_FriendlyName() + " is located outside the casino enterance");
          ((Entity) this.AirVehicle).AddBlip();
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Sprite((BlipSprite) 326);
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Name(this.AirVehicle.get_FriendlyName());
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Color(this.Blip_Colour);
        }
        else
        {
          Model model2 = ((Entity) this.AirVehicle).get_Model();
          if (!((Model) ref model2).get_IsHelicopter())
            return;
          UI.Notify(this.GetHostName() + " : your " + this.AirVehicle.get_FriendlyName() + " is located on the Helipad");
          ((Entity) this.AirVehicle).AddBlip();
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Sprite((BlipSprite) 422);
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Name(this.AirVehicle.get_FriendlyName());
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Color(this.Blip_Colour);
        }
      }
      else
      {
        this.AirVehicle = World.CreateVehicle(V, S, R);
        Model model = ((Entity) this.AirVehicle).get_Model();
        if (((Model) ref model).get_IsCar())
        {
          UI.Notify(this.GetHostName() + " : your " + this.AirVehicle.get_FriendlyName() + " is located outside the casino enterance");
          ((Entity) this.AirVehicle).AddBlip();
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Sprite((BlipSprite) 326);
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Name(this.AirVehicle.get_FriendlyName());
          ((Entity) this.AirVehicle).get_CurrentBlip().set_Color(this.Blip_Colour);
        }
        else
        {
          model = ((Entity) this.AirVehicle).get_Model();
          if (((Model) ref model).get_IsHelicopter())
          {
            UI.Notify(this.GetHostName() + " : your " + this.AirVehicle.get_FriendlyName() + " is located on the Helipad");
            ((Entity) this.AirVehicle).AddBlip();
            ((Entity) this.AirVehicle).get_CurrentBlip().set_Sprite((BlipSprite) 422);
            ((Entity) this.AirVehicle).get_CurrentBlip().set_Name(this.AirVehicle.get_FriendlyName());
            ((Entity) this.AirVehicle).get_CurrentBlip().set_Color(this.Blip_Colour);
          }
        }
      }
    }

    private void SetupGarage()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass593_0 displayClass5930 = new Class1.\u003C\u003Ec__DisplayClass593_0()
      {
        \u003C\u003E4__this = this,
        Land = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Caracara2");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Drafter");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Dynasty");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Emurus");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Gauntlet3");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Gauntlet4");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Hellion");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Issi7");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Jugular");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Locust");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Nebula");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Neo");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Novak");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Paragon");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Paragon2");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Peyote2");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "RRocket");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "S80");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Thrax");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Zion3");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Land.Add((object) "Zorrusso");
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Air = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Air.Add((object) (VehicleHash) 745926877);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Air.Add((object) (VehicleHash) 1075432268);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Air.Add((object) (VehicleHash) 710198397);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Air.Add((object) (VehicleHash) -1671539132);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Air.Add((object) (VehicleHash) -1660661558);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.Air.Add((object) (VehicleHash) 744705981);
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.Garage, "Air Vehicles");
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.Garage, "Land Vehicles");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5930.AV = new UIMenuListItem("Vehicle: ", displayClass5930.Air, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass5930.AV);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.VehAV = new UIMenuItem("Attack Buzzard, unlocked onBusiness level 8");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5930.VehAV);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.GetAV = new UIMenuItem("Get Vehicle");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5930.GetAV);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5930.LV = new UIMenuListItem("Vehicle: ", displayClass5930.Land, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass5930.LV);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.VehLV = new UIMenuItem("Vapid Caracara 4x4, unlocked on Business level 5");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5930.VehLV);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.GetLV = new UIMenuItem("Get Vehicle");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5930.GetLV);
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(this.Garage, "Rent a vehicle : -$25000");
      List<object> objectList = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass5930.allvehiclehashes = (VehicleHash[]) Enum.GetValues(typeof (VehicleHash));
      // ISSUE: reference to a compiler-generated field
      for (int index = 0; index < displayClass5930.allvehiclehashes.Length; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        objectList.Add((object) (VehicleHash) (int) (uint) displayClass5930.allvehiclehashes[index]);
      }
      // ISSUE: reference to a compiler-generated field
      displayClass5930.list = new UIMenuListItem("Vehicle: ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5930.list);
      // ISSUE: reference to a compiler-generated field
      displayClass5930.getvehicle = new UIMenuItem("Rent Car: -$2500");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass5930.getvehicle);
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass5930, __methodptr(\u003CSetupGarage\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu1.add_OnListChange(new ListChangedEvent((object) displayClass5930, __methodptr(\u003CSetupGarage\u003Eb__1)));
      // ISSUE: method pointer
      uiMenu2.add_OnListChange(new ListChangedEvent((object) displayClass5930, __methodptr(\u003CSetupGarage\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass5930, __methodptr(\u003CSetupGarage\u003Eb__3)));
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass5930, __methodptr(\u003CSetupGarage\u003Eb__4)));
    }

    private void SetupProduct()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass594_0 displayClass5940 = new Class1.\u003C\u003Ec__DisplayClass594_0();
      // ISSUE: reference to a compiler-generated field
      displayClass5940.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.ProductStock, "Buy/Sell Product");
      // ISSUE: reference to a compiler-generated field
      displayClass5940.Buy2 = new UIMenuItem("Buy X10: -$" + (object) 500000);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5940.Buy2);
      // ISSUE: reference to a compiler-generated field
      displayClass5940.Buy = new UIMenuItem("Buy X1: -$" + (object) 100000);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5940.Buy);
      // ISSUE: reference to a compiler-generated field
      displayClass5940.Sell = new UIMenuItem("Sell - All Stocks (Low)");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5940.Sell);
      // ISSUE: reference to a compiler-generated field
      displayClass5940.Sell2 = new UIMenuItem("Sell - All Stocks (High)");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5940.Sell2);
      // ISSUE: reference to a compiler-generated field
      displayClass5940.Show = new UIMenuItem("Show Product Value/Count");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass5940.Show);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass5940, __methodptr(\u003CSetupProduct\u003Eb__0)));
    }

    private void Setupbuisness()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass595_0 displayClass5950 = new Class1.\u003C\u003Ec__DisplayClass595_0()
      {
        \u003C\u003E4__this = this,
        TF = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass5950.TF.Add((object) false);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.TF.Add((object) true);
      List<object> objectList = new List<object>();
      int num = 1;
      for (int index = 1; index < 100; ++index)
        objectList.Add((object) (num + index));
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.methgarage, "Expand Business ");
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.methgarage, "Card Deck Options");
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Def = new UIMenuItem("Use Default Card Deck");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5950.Def);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.P_E = new UIMenuItem("Purchase Elite Deck : $3,000,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5950.P_E);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.UseE = new UIMenuItem("Use Elite Deck");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass5950.UseE);
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass5950, __methodptr(\u003CSetupbuisness\u003Eb__0)));
      this.PlayerDeck = (int) this.Config.GetValue<int>("CardDeck", "PlayerDeck", (M0) this.PlayerDeck);
      this.EliteDeckUnlocked = (int) this.Config.GetValue<int>("CardDeck", "EliteDeckUnlocked", (M0) this.EliteDeckUnlocked);
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(uiMenu2, "The Master's Deck");
      // ISSUE: reference to a compiler-generated field
      displayClass5950.TMD = new UIMenuItem("Purchase The Master's Deck : $200,000,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass5950.TMD);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.UTMD = new UIMenuItem("Check for Discount");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass5950.UTMD);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.useTMD = new UIMenuItem("Use The Master's Deck ");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass5950.useTMD);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Normal = new UIMenuListItem("Use Default Deck Cards : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950.Normal);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Elite = new UIMenuListItem("Use Elite Deck Cards : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950.Elite);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Queen = new UIMenuListItem("Use Queen : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950.Queen);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950.King = new UIMenuListItem("Use King : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950.King);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Jack = new UIMenuListItem("Use Jack : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950.Jack);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Ace = new UIMenuListItem("Use Ace : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950.Ace);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._2 = new UIMenuListItem("Use 2  : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._2);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._3 = new UIMenuListItem("Use 3  : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._3);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._4 = new UIMenuListItem("Use 4  : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._4);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._5 = new UIMenuListItem("Use 5  : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._5);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._6 = new UIMenuListItem("Use 6  : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._6);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._7 = new UIMenuListItem("Use 7  : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._7);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._8 = new UIMenuListItem("Use 8  : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._8);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._9 = new UIMenuListItem("Use 9  : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._9);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass5950._10 = new UIMenuListItem("Use 10 : ", displayClass5950.TF, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass5950._10);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.SaveDeck = new UIMenuItem("Save Deck");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass5950.SaveDeck);
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass5950, __methodptr(\u003CSetupbuisness\u003Eb__1)));
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Update = new UIMenuItem("Update Stats");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5950.Update);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.BuyNewLevel = new UIMenuItem(" Buy Level ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5950.BuyNewLevel);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.list2 = new UIMenuListItem("Select Level: ", objectList, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass5950.list2);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Jump = new UIMenuItem("Jump Straight to Level");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5950.Jump);
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Show = new UIMenuItem("Show Level");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass5950.Show);
      UIMenu uiMenu4 = this.modMenuPool.AddSubMenu(this.methgarage, "Sell  Business");
      // ISSUE: reference to a compiler-generated field
      displayClass5950.Sell = new UIMenuItem("Sell");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass5950.Sell);
      // ISSUE: method pointer
      uiMenu4.add_OnItemSelect(new ItemSelectEvent((object) displayClass5950, __methodptr(\u003CSetupbuisness\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass5950, __methodptr(\u003CSetupbuisness\u003Eb__3)));
      this.PlayerDeck = (int) this.Config.GetValue<int>("CardDeck", "PlayerDeck", (M0) this.PlayerDeck);
      this.EliteDeckUnlocked = (int) this.Config.GetValue<int>("CardDeck", "EliteDeckUnlocked", (M0) this.EliteDeckUnlocked);
      this.TMDUnlocked = (int) this.Config.GetValue<int>("CardDeck -TMD", "TMDUnlocked", (M0) this.TMDUnlocked);
      this.TMD_UseNormalDeckCards = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseNormalDeckCards", (M0) (this.TMD_UseNormalDeckCards ? 1 : 0));
      this.TMD_UseEliteDeckCards = (bool) this.Config.GetValue<bool>("CardDeck - TMD", " TMD_UseEliteDeckCards", (M0) (this.TMD_UseEliteDeckCards ? 1 : 0));
      this.TMD_UseAce = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseAce", (M0) (this.TMD_UseAce ? 1 : 0));
      this.TMD_UseKing = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseKing", (M0) (this.TMD_UseKing ? 1 : 0));
      this.TMD_UseQueen = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseQueen", (M0) (this.TMD_UseQueen ? 1 : 0));
      this.TMD_UseJack = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_UseJack", (M0) (this.TMD_UseJack ? 1 : 0));
      this.TMD_Use02 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use02", (M0) (this.TMD_Use02 ? 1 : 0));
      this.TMD_Use03 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use03", (M0) (this.TMD_Use03 ? 1 : 0));
      this.TMD_Use04 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use04", (M0) (this.TMD_Use04 ? 1 : 0));
      this.TMD_Use05 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use05", (M0) (this.TMD_Use05 ? 1 : 0));
      this.TMD_Use06 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use06", (M0) (this.TMD_Use06 ? 1 : 0));
      this.TMD_Use07 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use07", (M0) (this.TMD_Use07 ? 1 : 0));
      this.TMD_Use08 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use08", (M0) (this.TMD_Use08 ? 1 : 0));
      this.TMD_Use09 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use09", (M0) (this.TMD_Use09 ? 1 : 0));
      this.TMD_Use10 = (bool) this.Config.GetValue<bool>("CardDeck - TMD", "TMD_Use10", (M0) (this.TMD_Use10 ? 1 : 0));
    }

    private void VehicleIdentiferfun2(VehicleHash v)
    {
      if (Blip.op_Inequality(this.VehicleMarker, (Blip) null))
        this.VehicleMarker.Remove();
      this.Vehicletoget = (Vehicle) null;
      Random random = new Random();
      if (random.Next(1, 13) == 1)
        this.VehicleSpawn = new Vector3(-1069.32f, -72.28f, 19f);
      if (random.Next(1, 13) == 2)
        this.VehicleSpawn = new Vector3(-1579.93f, -155.28f, 55f);
      if (random.Next(1, 13) == 3)
        this.VehicleSpawn = new Vector3(-711.74f, -28.28f, 37f);
      if (random.Next(1, 13) == 4)
        this.VehicleSpawn = new Vector3(6f, 253.58f, 109f);
      if (random.Next(1, 13) == 5)
        this.VehicleSpawn = new Vector3(703f, 32f, 84f);
      if (random.Next(1, 13) == 6)
        this.VehicleSpawn = new Vector3(1197f, -421.5f, 68f);
      if (random.Next(1, 13) == 7)
        this.VehicleSpawn = new Vector3(1257f, -1428f, 35f);
      if (random.Next(1, 13) == 8)
        this.VehicleSpawn = new Vector3(1264f, -2039f, 45f);
      if (random.Next(1, 13) == 9)
        this.VehicleSpawn = new Vector3(527f, -2052f, 28f);
      if (random.Next(1, 13) == 10)
        this.VehicleSpawn = new Vector3(-161f, -2087.8f, 26f);
      if (random.Next(1, 13) == 11)
        this.VehicleSpawn = new Vector3(756f, -1723f, 30f);
      if (random.Next(1, 13) == 12)
        this.VehicleSpawn = new Vector3(-816f, -2300f, 11f);
      if (random.Next(1, 13) == 13)
        this.VehicleSpawn = new Vector3(-1839f, 136f, 78f);
      this.Vehicletoget = World.CreateVehicle(Model.op_Implicit(v), this.VehicleSpawn);
      this.SourcedVehicle = this.Vehicletoget.get_DisplayName();
      ((Entity) this.Vehicletoget).Delete();
      this.NewVehicleSourcing = true;
      this.foundvehicleyet = true;
      this.SourcingCheckingforDamage = true;
    }

    private void VehicleIdentiferfun(VehicleHash v)
    {
      if (Blip.op_Inequality(this.VehicleMarker, (Blip) null))
        this.VehicleMarker.Remove();
      this.Vehicletoget = (Vehicle) null;
      Random random = new Random();
      if (random.Next(1, 13) == 1)
        this.VehicleSpawn = new Vector3(-1069.32f, -72.28f, 19f);
      if (random.Next(1, 13) == 2)
        this.VehicleSpawn = new Vector3(-1579.93f, -155.28f, 55f);
      if (random.Next(1, 13) == 3)
        this.VehicleSpawn = new Vector3(-711.74f, -28.28f, 37f);
      if (random.Next(1, 13) == 4)
        this.VehicleSpawn = new Vector3(6f, 253.58f, 109f);
      if (random.Next(1, 13) == 5)
        this.VehicleSpawn = new Vector3(703f, 32f, 84f);
      if (random.Next(1, 13) == 6)
        this.VehicleSpawn = new Vector3(1197f, -421.5f, 68f);
      if (random.Next(1, 13) == 7)
        this.VehicleSpawn = new Vector3(1257f, -1428f, 35f);
      if (random.Next(1, 13) == 8)
        this.VehicleSpawn = new Vector3(1264f, -2039f, 45f);
      if (random.Next(1, 13) == 9)
        this.VehicleSpawn = new Vector3(527f, -2052f, 28f);
      if (random.Next(1, 13) == 10)
        this.VehicleSpawn = new Vector3(-161f, -2087.8f, 26f);
      if (random.Next(1, 13) == 11)
        this.VehicleSpawn = new Vector3(756f, -1723f, 30f);
      if (random.Next(1, 13) == 12)
        this.VehicleSpawn = new Vector3(-816f, -2300f, 11f);
      if (random.Next(1, 13) == 13)
        this.VehicleSpawn = new Vector3(-1839f, 136f, 78f);
      this.Vehicletoget = World.CreateVehicle(Model.op_Implicit(v), this.VehicleSpawn);
      this.Vehicletoget.CreatePedOnSeat((VehicleSeat) -1, Model.op_Implicit((PedHash) -1382092357));
      this.Vehicletoget.GetPedOnSeat((VehicleSeat) -1).get_Task().FleeFrom(Game.get_Player().get_Character());
      this.Vehicleloc = ((Entity) this.Vehicletoget).get_Position();
      this.VehicleMarker = World.CreateBlip(this.Vehicleloc);
      this.VehicleMarker.set_Sprite((BlipSprite) 198);
      this.VehicleMarker.set_Color((BlipColor) 1);
      this.VehicleMarker.set_Name("Target Car");
      this.foundvehicleyet = true;
      this.SourcingCheckingforDamage = true;
    }

    public void SetupGames()
    {
      this.PokerTables.Add(new Vector3(1142.553f, 264.4609f, -52.5f));
      this.PokerTablesRot.Add(-118f);
      this.PokerTables.Add(new Vector3(1148.53f, 250.7988f, -51.7f));
      this.PokerTablesRot.Add(-19f);
      this.PokerTables.Add(new Vector3(1147.02f, 261.0965f, -52.5f));
      this.PokerTablesRot.Add(61f);
      this.PokerTables.Add(new Vector3(1133.591f, 265.9429f, -51.7f));
      this.PokerTablesRot.Add(-23f);
      this.PokerTables.Add(new Vector3(965.5583f, 29.85048f, 114.82f));
      this.PokerTablesRot.Add(-109f);
      this.RouletteTables.Add(new Vector3(1146.576f, 265.7215f, -52.7f));
      this.RouletteTablesRot.Add(-56f);
      this.RouletteTables.Add(new Vector3(1149f, 249.1302f, -51.7f));
      this.RouletteTablesRot.Add(-164f);
      this.RouletteTables.Add(new Vector3(1129.333f, 266.5558f, -51.7f));
      this.RouletteTablesRot.Add(4f);
      this.BlackJackTables.Add(new Vector3(1144.556f, 248.0103f, -51.7f));
      this.BlackJackRot.Add(172f);
      this.BlackJackTables.Add(new Vector3(1152.671f, 266.5922f, -52.5f));
      this.BlackJackRot.Add(67f);
      this.BlackJackTables.Add(new Vector3(1147.983f, 269.922f, -52.5f));
      this.BlackJackRot.Add(-112f);
      this.BlackJackTables.Add(new Vector3(1129.566f, 263.1441f, -51.7f));
      this.BlackJackRot.Add(151f);
      this.BlackJackTables.Add(new Vector3(967.4562f, 33.75568f, 114.82f));
      this.BlackJackRot.Add(-105f);
      this.SlotMachines.Add(new Vector3(1105.959f, 228.7872f, -49.8f));
      this.SlotMachinesRot.Add(35f);
      this.SlotMachines.Add(new Vector3(1106.344f, 230.4661f, -49.8f));
      this.SlotMachinesRot.Add(108f);
      this.SlotMachines.Add(new Vector3(1105.047f, 231.4999f, -49.8f));
      this.SlotMachinesRot.Add(178f);
      this.SlotMachines.Add(new Vector3(1103.892f, 230.5018f, -49.8f));
      this.SlotMachinesRot.Add(-107f);
      this.SlotMachines.Add(new Vector3(1101.564f, 230.6477f, -49.8f));
      this.SlotMachinesRot.Add(63f);
      this.SlotMachines.Add(new Vector3(1100.822f, 230.105f, -49.8f));
      this.SlotMachinesRot.Add(45f);
      this.SlotMachines.Add(new Vector3(1101.661f, 231.5672f, -49.8f));
      this.SlotMachinesRot.Add(73f);
      this.SlotMachines.Add(new Vector3(1101.94f, 232.4414f, -49.8f));
      this.SlotMachinesRot.Add(87f);
      this.SlotMachines.Add(new Vector3(1101.775f, 233.3168f, -49.8f));
      this.SlotMachinesRot.Add(101f);
      this.SlotMachines.Add(new Vector3(1107.15f, 234.9417f, -49.8f));
      this.SlotMachinesRot.Add(-111f);
      this.SlotMachines.Add(new Vector3(1107.558f, 233.311f, -49.8f));
      this.SlotMachinesRot.Add(-34f);
      this.SlotMachines.Add(new Vector3(1109.176f, 233.5511f, -49.8f));
      this.SlotMachinesRot.Add(32f);
      this.SlotMachines.Add(new Vector3(1109.793f, 234.9457f, -49.8f));
      this.SlotMachinesRot.Add(109f);
      this.SlotMachines.Add(new Vector3(1108.582f, 239.1074f, -49.8f));
      this.SlotMachinesRot.Add(-48f);
      this.SlotMachines.Add(new Vector3(1109.164f, 238.4004f, -49.8f));
      this.SlotMachinesRot.Add(-34f);
      this.SlotMachines.Add(new Vector3(1110.082f, 238.1253f, -49.8f));
      this.SlotMachinesRot.Add(-20f);
      this.SlotMachines.Add(new Vector3(1110.956f, 238.1476f, -49.8f));
      this.SlotMachinesRot.Add(-3f);
      this.SlotMachines.Add(new Vector3(1111.801f, 238.1584f, -49.8f));
      this.SlotMachinesRot.Add(25f);
      this.SlotMachines.Add(new Vector3(1112.645f, 238.5698f, -49.8f));
      this.SlotMachinesRot.Add(32f);
      this.SlotMachines.Add(new Vector3(1113.419f, 238.9962f, -49.8f));
      this.SlotMachinesRot.Add(46f);
      this.SlotMachines.Add(new Vector3(1115.422f, 234.7188f, -49.8f));
      this.SlotMachinesRot.Add(109f);
      this.SlotMachines.Add(new Vector3(1114.047f, 235.7146f, -49.8f));
      this.SlotMachinesRot.Add(-170f);
      this.SlotMachines.Add(new Vector3(1112.701f, 234.7498f, -49.8f));
      this.SlotMachinesRot.Add(-107f);
      this.SlotMachines.Add(new Vector3(1113.335f, 233.1384f, -49.8f));
      this.SlotMachinesRot.Add(-37f);
      this.SlotMachines.Add(new Vector3(1114.964f, 233.0724f, -49.8f));
      this.SlotMachinesRot.Add(25f);
      this.SlotMachines.Add(new Vector3(1116.269f, 228.2968f, -49.8f));
      this.SlotMachinesRot.Add(-39f);
      this.SlotMachines.Add(new Vector3(1117.877f, 2278.357f, -49.8f));
      this.SlotMachinesRot.Add(44f);
      this.SlotMachines.Add(new Vector3(1118.452f, 229.9547f, -49.8f));
      this.SlotMachinesRot.Add(103f);
      this.SlotMachines.Add(new Vector3(1117.169f, 230.8778f, -49.8f));
      this.SlotMachinesRot.Add(-175f);
      this.SlotMachines.Add(new Vector3(1117.169f, 230.8778f, -49.8f));
      this.SlotMachinesRot.Add(-175f);
      this.SlotMachines.Add(new Vector3(1129.584f, 250.9299f, -51.2f));
      this.SlotMachinesRot.Add(-173f);
      this.SlotMachines.Add(new Vector3(1130.55f, 251.0233f, -51.2f));
      this.SlotMachinesRot.Add(165f);
      this.SlotMachines.Add(new Vector3(1131.325f, 250.5148f, -51.2f));
      this.SlotMachinesRot.Add(154f);
      this.SlotMachines.Add(new Vector3(1132.006f, 249.9666f, -51.2f));
      this.SlotMachinesRot.Add(133f);
      this.SlotMachines.Add(new Vector3(1132.541f, 249.3008f, -51.2f));
      this.SlotMachinesRot.Add(119f);
      this.SlotMachines.Add(new Vector3(1132.924f, 248.4754f, -51.2f));
      this.SlotMachinesRot.Add(105f);
      this.SlotMachines.Add(new Vector3(1133.166f, 247.5615f, -51.2f));
      this.SlotMachinesRot.Add(84f);
      this.SlotMachines.Add(new Vector3(1137.762f, 251.4668f, -51.2f));
      this.SlotMachinesRot.Add(-44f);
      this.SlotMachines.Add(new Vector3(1139.381f, 251.0917f, -51.2f));
      this.SlotMachinesRot.Add(25f);
      this.SlotMachines.Add(new Vector3(1140.171f, 252.5691f, -51.2f));
      this.SlotMachinesRot.Add(102f);
      this.SlotMachines.Add(new Vector3(1138.972f, 253.6587f, -51.2f));
      this.SlotMachinesRot.Add(175f);
      this.SlotMachines.Add(new Vector3(1135.809f, 256.7634f, -51.2f));
      this.SlotMachinesRot.Add(98f);
      this.SlotMachines.Add(new Vector3(1134.669f, 257.789f, -51.2f));
      this.SlotMachinesRot.Add(168f);
      this.SlotMachines.Add(new Vector3(1133.367f, 257.0611f, -51.2f));
      this.SlotMachinesRot.Add(-117f);
    }

    public void CreatePeds()
    {
      this.Spawns.Add(new Vector3(1091f, 210f, -48f));
      this.Spawns.Add(new Vector3(1108f, 215f, -48f));
      this.Spawns.Add(new Vector3(1110.983f, 240f, -48f));
      this.Spawns.Add(new Vector3(1122f, 256f, -48f));
      this.Spawns.Add(new Vector3(1146f, 249f, -48f));
      Random random = new Random();
      Vector3 spawn1 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
      if (this.MainWanderPeds)
      {
        if (Model.op_Inequality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) -1692214353)))
        {
          random = new Random();
          Vector3 spawn2 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
          this.ped = World.CreatePed(this.RequestModel((PedHash) -1692214353), ((Vector3) ref spawn2).Around(10f));
          this.ped.get_Task().WanderAround();
          this.Peds.Add(this.ped);
        }
        if (Model.op_Inequality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) 225514697)))
        {
          random = new Random();
          Vector3 spawn2 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
          this.ped = World.CreatePed(this.RequestModel((PedHash) 225514697), ((Vector3) ref spawn2).Around(10f));
          this.ped.get_Task().WanderAround();
          this.Peds.Add(this.ped);
        }
        if (Model.op_Inequality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) -1686040670)))
        {
          random = new Random();
          Vector3 spawn2 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
          this.ped = World.CreatePed(this.RequestModel((PedHash) -1686040670), ((Vector3) ref spawn2).Around(10f));
          this.ped.get_Task().WanderAround();
          this.Peds.Add(this.ped);
        }
        Vector3 spawn3 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
        this.ped = World.CreatePed(this.RequestModel((PedHash) 1830688247), ((Vector3) ref spawn3).Around(10f));
        this.ped.get_Task().WanderAround();
        this.Peds.Add(this.ped);
        Vector3 spawn4 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
        this.ped = World.CreatePed(this.RequestModel((PedHash) -538688539), ((Vector3) ref spawn4).Around(10f));
        this.ped.get_Task().WanderAround();
        this.Peds.Add(this.ped);
        Vector3 spawn5 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
        this.ped = World.CreatePed(this.RequestModel((PedHash) 1706635382), ((Vector3) ref spawn5).Around(10f));
        this.ped.get_Task().WanderAround();
        this.Peds.Add(this.ped);
        Vector3 spawn6 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
        this.ped = World.CreatePed(this.RequestModel((PedHash) -872673803), ((Vector3) ref spawn6).Around(10f));
        this.ped.get_Task().WanderAround();
        this.Peds.Add(this.ped);
        Vector3 spawn7 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
        this.ped = World.CreatePed(this.RequestModel((PedHash) 365775923), ((Vector3) ref spawn7).Around(10f));
        this.ped.get_Task().WanderAround();
        this.Peds.Add(this.ped);
        spawn7 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
        this.ped = World.CreatePed(this.RequestModel((PedHash) -429715051), ((Vector3) ref spawn7).Around(10f));
        this.ped.get_Task().WanderAround();
        this.Peds.Add(this.ped);
        spawn7 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
        this.ped = World.CreatePed(this.RequestModel((PedHash) 2089096292), ((Vector3) ref spawn7).Around(10f));
        this.ped.get_Task().WanderAround();
        this.Peds.Add(this.ped);
      }
      using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null) && Entity.op_Inequality((Entity) this.Prizecar, (Entity) null) && (double) World.GetDistance(((Entity) current).get_Position(), ((Entity) this.Prizecar).get_Position()) < 4.0)
            ((Entity) current).Delete();
        }
      }
      using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
          {
            Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
            {
              InputArgument.op_Implicit(current),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
            {
              InputArgument.op_Implicit(current),
              InputArgument.op_Implicit(17),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
            {
              InputArgument.op_Implicit(current),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
            {
              InputArgument.op_Implicit(current),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
            {
              InputArgument.op_Implicit(current),
              InputArgument.op_Implicit(17),
              InputArgument.op_Implicit(1)
            });
            current.set_RelationshipGroup(1);
            current.set_AlwaysKeepTask(true);
          }
        }
      }
    }

    public Model RequestModel(string Prop)
    {
      Model model;
      ((Model) ref model).\u002Ector(Prop);
      ((Model) ref model).Request(250);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model RequestModel(VehicleHash Prop)
    {
      Model model;
      ((Model) ref model).\u002Ector(Prop);
      ((Model) ref model).Request(250);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model RequestModel(PedHash Prop)
    {
      Model model;
      ((Model) ref model).\u002Ector(Prop);
      ((Model) ref model).Request(250);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model SpawnProp(string Prop)
    {
      Model model;
      ((Model) ref model).\u002Ector(Prop);
      ((Model) ref model).Request(250);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public void SpawnProp(string Prop, Vector3 Pos, Vector3 Rot)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          this.Computer = World.CreateProp(model, Pos, Rot, true, false);
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public string GetRandomCardPlayer()
    {
      Random random = new Random();
      List<object> objectList = new List<object>();
      if (this.PlayerDeck == 1 || this.PlayerDeck == 0)
      {
        objectList.Add((object) "vw_prop_cas_card_club_02");
        objectList.Add((object) "vw_prop_cas_card_club_03");
        objectList.Add((object) "vw_prop_cas_card_club_04");
        objectList.Add((object) "vw_prop_cas_card_club_05");
        objectList.Add((object) "vw_prop_cas_card_club_06");
        objectList.Add((object) "vw_prop_cas_card_club_07");
        objectList.Add((object) "vw_prop_cas_card_club_08");
        objectList.Add((object) "vw_prop_cas_card_club_09");
        objectList.Add((object) "vw_prop_cas_card_club_10");
        objectList.Add((object) "vw_prop_cas_card_club_ace");
        objectList.Add((object) "vw_prop_cas_card_club_jack");
        objectList.Add((object) "vw_prop_cas_card_club_king");
        objectList.Add((object) "vw_prop_cas_card_club_queen");
        objectList.Add((object) "vw_prop_cas_card_spd_queen");
        objectList.Add((object) "vw_prop_cas_card_spd_king");
        objectList.Add((object) "vw_prop_cas_card_spd_jack");
        objectList.Add((object) "vw_prop_cas_card_spd_ace");
        objectList.Add((object) "vw_prop_cas_card_spd_10");
        objectList.Add((object) "vw_prop_cas_card_spd_09");
        objectList.Add((object) "vw_prop_cas_card_spd_08");
        objectList.Add((object) "vw_prop_cas_card_spd_07");
        objectList.Add((object) "vw_prop_cas_card_spd_06");
        objectList.Add((object) "vw_prop_cas_card_spd_05");
        objectList.Add((object) "vw_prop_cas_card_spd_04");
        objectList.Add((object) "vw_prop_cas_card_spd_03");
        objectList.Add((object) "vw_prop_cas_card_spd_02");
        objectList.Add((object) "vw_prop_cas_card_hrt_queen");
        objectList.Add((object) "vw_prop_cas_card_hrt_king");
        objectList.Add((object) "vw_prop_cas_card_hrt_jack");
        objectList.Add((object) "vw_prop_cas_card_hrt_ace");
        objectList.Add((object) "vw_prop_cas_card_hrt_10");
        objectList.Add((object) "vw_prop_cas_card_hrt_09");
        objectList.Add((object) "vw_prop_cas_card_hrt_08");
        objectList.Add((object) "vw_prop_cas_card_hrt_07");
        objectList.Add((object) "vw_prop_cas_card_hrt_06");
        objectList.Add((object) "vw_prop_cas_card_hrt_05");
        objectList.Add((object) "vw_prop_cas_card_hrt_04");
        objectList.Add((object) "vw_prop_cas_card_hrt_03");
        objectList.Add((object) "vw_prop_cas_card_hrt_02");
        objectList.Add((object) "vw_prop_cas_card_dia_queen");
        objectList.Add((object) "vw_prop_cas_card_dia_king");
        objectList.Add((object) "vw_prop_cas_card_dia_jack");
        objectList.Add((object) "vw_prop_cas_card_dia_ace");
        objectList.Add((object) "vw_prop_cas_card_dia_10");
        objectList.Add((object) "vw_prop_cas_card_dia_09");
        objectList.Add((object) "vw_prop_cas_card_dia_08");
        objectList.Add((object) "vw_prop_cas_card_dia_07");
        objectList.Add((object) "vw_prop_cas_card_dia_06");
        objectList.Add((object) "vw_prop_cas_card_dia_05");
        objectList.Add((object) "vw_prop_cas_card_dia_04");
        objectList.Add((object) "vw_prop_cas_card_dia_03");
        objectList.Add((object) "vw_prop_cas_card_dia_02");
      }
      if (this.PlayerDeck == 2)
      {
        objectList.Add((object) "vw_prop_vw_club_char_02a");
        objectList.Add((object) "vw_prop_vw_club_char_03a");
        objectList.Add((object) "vw_prop_vw_club_char_04a");
        objectList.Add((object) "vw_prop_vw_club_char_05a");
        objectList.Add((object) "vw_prop_vw_club_char_06a");
        objectList.Add((object) "vw_prop_vw_club_char_07a");
        objectList.Add((object) "vw_prop_vw_club_char_08a");
        objectList.Add((object) "vw_prop_vw_club_char_09a");
        objectList.Add((object) "vw_prop_vw_club_char_10a");
        objectList.Add((object) "vw_prop_vw_club_char_a_a");
        objectList.Add((object) "vw_prop_vw_club_char_j_a");
        objectList.Add((object) "vw_prop_vw_club_char_k_a");
        objectList.Add((object) "vw_prop_vw_club_char_q_a");
        objectList.Add((object) "vw_prop_vw_dia_char_02a");
        objectList.Add((object) "vw_prop_vw_dia_char_03a");
        objectList.Add((object) "vw_prop_vw_dia_char_04a");
        objectList.Add((object) "vw_prop_vw_dia_char_05a");
        objectList.Add((object) "vw_prop_vw_dia_char_06a");
        objectList.Add((object) "vw_prop_vw_dia_char_07a");
        objectList.Add((object) "vw_prop_vw_dia_char_08a");
        objectList.Add((object) "vw_prop_vw_dia_char_09a");
        objectList.Add((object) "vw_prop_vw_dia_char_10a");
        objectList.Add((object) "vw_prop_vw_dia_char_a_a");
        objectList.Add((object) "vw_prop_vw_dia_char_j_a");
        objectList.Add((object) "vw_prop_vw_dia_char_k_a");
        objectList.Add((object) "vw_prop_vw_dia_char_q_a");
        objectList.Add((object) "vw_prop_vw_hrt_char_02a");
        objectList.Add((object) "vw_prop_vw_hrt_char_03a");
        objectList.Add((object) "vw_prop_vw_hrt_char_04a");
        objectList.Add((object) "vw_prop_vw_hrt_char_05a");
        objectList.Add((object) "vw_prop_vw_hrt_char_06a");
        objectList.Add((object) "vw_prop_vw_hrt_char_07a");
        objectList.Add((object) "vw_prop_vw_hrt_char_08a");
        objectList.Add((object) "vw_prop_vw_hrt_char_09a");
        objectList.Add((object) "vw_prop_vw_hrt_char_10a");
        objectList.Add((object) "vw_prop_vw_hrt_char_a_a");
        objectList.Add((object) "vw_prop_vw_hrt_char_j_a");
        objectList.Add((object) "vw_prop_vw_hrt_char_k_a");
        objectList.Add((object) "vw_prop_vw_hrt_char_q_a");
        objectList.Add((object) "vw_prop_vw_spd_char_02a");
        objectList.Add((object) "vw_prop_vw_spd_char_03a");
        objectList.Add((object) "vw_prop_vw_spd_char_04a");
        objectList.Add((object) "vw_prop_vw_spd_char_05a");
        objectList.Add((object) "vw_prop_vw_spd_char_06a");
        objectList.Add((object) "vw_prop_vw_spd_char_07a");
        objectList.Add((object) "vw_prop_vw_spd_char_08a");
        objectList.Add((object) "vw_prop_vw_spd_char_09a");
        objectList.Add((object) "vw_prop_vw_spd_char_10a");
        objectList.Add((object) "vw_prop_vw_spd_char_a_a");
        objectList.Add((object) "vw_prop_vw_spd_char_j_a");
        objectList.Add((object) "vw_prop_vw_spd_char_k_a");
        objectList.Add((object) "vw_prop_vw_spd_char_q_a");
      }
      if (this.PlayerDeck == 3)
      {
        if (this.TMD_UseNormalDeckCards)
        {
          if (this.TMD_Use02)
            objectList.Add((object) "vw_prop_cas_card_club_02");
          if (this.TMD_Use03)
            objectList.Add((object) "vw_prop_cas_card_club_03");
          if (this.TMD_Use04)
            objectList.Add((object) "vw_prop_cas_card_club_04");
          if (this.TMD_Use05)
            objectList.Add((object) "vw_prop_cas_card_club_05");
          if (this.TMD_Use06)
            objectList.Add((object) "vw_prop_cas_card_club_06");
          if (this.TMD_Use07)
            objectList.Add((object) "vw_prop_cas_card_club_07");
          if (this.TMD_Use08)
            objectList.Add((object) "vw_prop_cas_card_club_08");
          if (this.TMD_Use09)
            objectList.Add((object) "vw_prop_cas_card_club_09");
          if (this.TMD_Use10)
            objectList.Add((object) "vw_prop_cas_card_club_10");
          if (this.TMD_UseAce)
            objectList.Add((object) "vw_prop_cas_card_club_ace");
          if (this.TMD_UseJack)
            objectList.Add((object) "vw_prop_cas_card_club_jack");
          if (this.TMD_UseKing)
            objectList.Add((object) "vw_prop_cas_card_club_king");
          if (this.TMD_UseQueen)
            objectList.Add((object) "vw_prop_cas_card_club_queen");
          if (this.TMD_UseQueen)
            objectList.Add((object) "vw_prop_cas_card_spd_queen");
          if (this.TMD_UseKing)
            objectList.Add((object) "vw_prop_cas_card_spd_king");
          if (this.TMD_UseJack)
            objectList.Add((object) "vw_prop_cas_card_spd_jack");
          if (this.TMD_UseAce)
            objectList.Add((object) "vw_prop_cas_card_spd_ace");
          if (this.TMD_Use10)
            objectList.Add((object) "vw_prop_cas_card_spd_10");
          if (this.TMD_Use09)
            objectList.Add((object) "vw_prop_cas_card_spd_09");
          if (this.TMD_Use08)
            objectList.Add((object) "vw_prop_cas_card_spd_08");
          if (this.TMD_Use07)
            objectList.Add((object) "vw_prop_cas_card_spd_07");
          if (this.TMD_Use06)
            objectList.Add((object) "vw_prop_cas_card_spd_06");
          if (this.TMD_Use05)
            objectList.Add((object) "vw_prop_cas_card_spd_05");
          if (this.TMD_Use04)
            objectList.Add((object) "vw_prop_cas_card_spd_04");
          if (this.TMD_Use03)
            objectList.Add((object) "vw_prop_cas_card_spd_03");
          if (this.TMD_Use02)
            objectList.Add((object) "vw_prop_cas_card_spd_02");
          if (this.TMD_UseQueen)
            objectList.Add((object) "vw_prop_cas_card_hrt_queen");
          if (this.TMD_UseKing)
            objectList.Add((object) "vw_prop_cas_card_hrt_king");
          if (this.TMD_UseJack)
            objectList.Add((object) "vw_prop_cas_card_hrt_jack");
          if (this.TMD_UseAce)
            objectList.Add((object) "vw_prop_cas_card_hrt_ace");
          if (this.TMD_Use10)
            objectList.Add((object) "vw_prop_cas_card_hrt_10");
          if (this.TMD_Use09)
            objectList.Add((object) "vw_prop_cas_card_hrt_09");
          if (this.TMD_Use08)
            objectList.Add((object) "vw_prop_cas_card_hrt_08");
          if (this.TMD_Use07)
            objectList.Add((object) "vw_prop_cas_card_hrt_07");
          if (this.TMD_Use06)
            objectList.Add((object) "vw_prop_cas_card_hrt_06");
          if (this.TMD_Use05)
            objectList.Add((object) "vw_prop_cas_card_hrt_05");
          if (this.TMD_Use04)
            objectList.Add((object) "vw_prop_cas_card_hrt_04");
          if (this.TMD_Use03)
            objectList.Add((object) "vw_prop_cas_card_hrt_03");
          if (this.TMD_Use02)
            objectList.Add((object) "vw_prop_cas_card_hrt_02");
          if (this.TMD_UseQueen)
            objectList.Add((object) "vw_prop_cas_card_dia_queen");
          if (this.TMD_UseKing)
            objectList.Add((object) "vw_prop_cas_card_dia_king");
          if (this.TMD_UseJack)
            objectList.Add((object) "vw_prop_cas_card_dia_jack");
          if (this.TMD_UseAce)
            objectList.Add((object) "vw_prop_cas_card_dia_ace");
          if (this.TMD_Use10)
            objectList.Add((object) "vw_prop_cas_card_dia_10");
          if (this.TMD_Use09)
            objectList.Add((object) "vw_prop_cas_card_dia_09");
          if (this.TMD_Use08)
            objectList.Add((object) "vw_prop_cas_card_dia_08");
          if (this.TMD_Use07)
            objectList.Add((object) "vw_prop_cas_card_dia_07");
          if (this.TMD_Use06)
            objectList.Add((object) "vw_prop_cas_card_dia_06");
          if (this.TMD_Use05)
            objectList.Add((object) "vw_prop_cas_card_dia_05");
          if (this.TMD_Use04)
            objectList.Add((object) "vw_prop_cas_card_dia_04");
          if (this.TMD_Use03)
            objectList.Add((object) "vw_prop_cas_card_dia_03");
          if (this.TMD_Use02)
            objectList.Add((object) "vw_prop_cas_card_dia_02");
        }
        if (this.TMD_UseEliteDeckCards)
        {
          if (this.TMD_Use02)
            objectList.Add((object) "vw_prop_vw_club_char_02a");
          if (this.TMD_Use03)
            objectList.Add((object) "vw_prop_vw_club_char_03a");
          if (this.TMD_Use04)
            objectList.Add((object) "vw_prop_vw_club_char_04a");
          if (this.TMD_Use05)
            objectList.Add((object) "vw_prop_vw_club_char_05a");
          if (this.TMD_Use06)
            objectList.Add((object) "vw_prop_vw_club_char_06a");
          if (this.TMD_Use07)
            objectList.Add((object) "vw_prop_vw_club_char_07a");
          if (this.TMD_Use08)
            objectList.Add((object) "vw_prop_vw_club_char_08a");
          if (this.TMD_Use09)
            objectList.Add((object) "vw_prop_vw_club_char_09a");
          if (this.TMD_Use10)
            objectList.Add((object) "vw_prop_vw_club_char_10a");
          if (this.TMD_UseAce)
            objectList.Add((object) "vw_prop_vw_club_char_a_a");
          if (this.TMD_UseJack)
            objectList.Add((object) "vw_prop_vw_club_char_j_a");
          if (this.TMD_UseKing)
            objectList.Add((object) "vw_prop_vw_club_char_k_a");
          if (this.TMD_UseQueen)
            objectList.Add((object) "vw_prop_vw_club_char_q_a");
          if (this.TMD_Use02)
            objectList.Add((object) "vw_prop_vw_dia_char_02a");
          if (this.TMD_Use03)
            objectList.Add((object) "vw_prop_vw_dia_char_03a");
          if (this.TMD_Use04)
            objectList.Add((object) "vw_prop_vw_dia_char_04a");
          if (this.TMD_Use05)
            objectList.Add((object) "vw_prop_vw_dia_char_05a");
          if (this.TMD_Use06)
            objectList.Add((object) "vw_prop_vw_dia_char_06a");
          if (this.TMD_Use07)
            objectList.Add((object) "vw_prop_vw_dia_char_07a");
          if (this.TMD_Use08)
            objectList.Add((object) "vw_prop_vw_dia_char_08a");
          if (this.TMD_Use09)
            objectList.Add((object) "vw_prop_vw_dia_char_09a");
          if (this.TMD_Use10)
            objectList.Add((object) "vw_prop_vw_dia_char_10a");
          if (this.TMD_UseAce)
            objectList.Add((object) "vw_prop_vw_dia_char_a_a");
          if (this.TMD_UseJack)
            objectList.Add((object) "vw_prop_vw_dia_char_j_a");
          if (this.TMD_UseKing)
            objectList.Add((object) "vw_prop_vw_dia_char_k_a");
          if (this.TMD_UseQueen)
            objectList.Add((object) "vw_prop_vw_dia_char_q_a");
          if (this.TMD_Use02)
            objectList.Add((object) "vw_prop_vw_hrt_char_02a");
          if (this.TMD_Use03)
            objectList.Add((object) "vw_prop_vw_hrt_char_03a");
          if (this.TMD_Use04)
            objectList.Add((object) "vw_prop_vw_hrt_char_04a");
          if (this.TMD_Use05)
            objectList.Add((object) "vw_prop_vw_hrt_char_05a");
          if (this.TMD_Use06)
            objectList.Add((object) "vw_prop_vw_hrt_char_06a");
          if (this.TMD_Use07)
            objectList.Add((object) "vw_prop_vw_hrt_char_07a");
          if (this.TMD_Use08)
            objectList.Add((object) "vw_prop_vw_hrt_char_08a");
          if (this.TMD_Use09)
            objectList.Add((object) "vw_prop_vw_hrt_char_09a");
          if (this.TMD_Use10)
            objectList.Add((object) "vw_prop_vw_hrt_char_10a");
          if (this.TMD_UseAce)
            objectList.Add((object) "vw_prop_vw_hrt_char_a_a");
          if (this.TMD_UseJack)
            objectList.Add((object) "vw_prop_vw_hrt_char_j_a");
          if (this.TMD_UseKing)
            objectList.Add((object) "vw_prop_vw_hrt_char_k_a");
          if (this.TMD_UseQueen)
            objectList.Add((object) "vw_prop_vw_hrt_char_q_a");
          if (this.TMD_Use02)
            objectList.Add((object) "vw_prop_vw_spd_char_02a");
          if (this.TMD_Use03)
            objectList.Add((object) "vw_prop_vw_spd_char_03a");
          if (this.TMD_Use04)
            objectList.Add((object) "vw_prop_vw_spd_char_04a");
          if (this.TMD_Use05)
            objectList.Add((object) "vw_prop_vw_spd_char_05a");
          if (this.TMD_Use06)
            objectList.Add((object) "vw_prop_vw_spd_char_06a");
          if (this.TMD_Use07)
            objectList.Add((object) "vw_prop_vw_spd_char_07a");
          if (this.TMD_Use08)
            objectList.Add((object) "vw_prop_vw_spd_char_08a");
          if (this.TMD_Use09)
            objectList.Add((object) "vw_prop_vw_spd_char_09a");
          if (this.TMD_Use10)
            objectList.Add((object) "vw_prop_vw_spd_char_10a");
          if (this.TMD_UseAce)
            objectList.Add((object) "vw_prop_vw_spd_char_a_a");
          if (this.TMD_UseJack)
            objectList.Add((object) "vw_prop_vw_spd_char_j_a");
          if (this.TMD_UseKing)
            objectList.Add((object) "vw_prop_vw_spd_char_k_a");
          if (this.TMD_UseQueen)
            objectList.Add((object) "vw_prop_vw_spd_char_q_a");
        }
      }
      int index = random.Next(0, objectList.Count - 1);
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__605.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__605.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Class1)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return Class1.\u003C\u003Eo__605.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__605.\u003C\u003Ep__0, objectList[index]);
    }

    public string GetRandomCardDealer()
    {
      Random random = new Random();
      List<object> objectList = new List<object>();
      if (this.PlayerDeck == 1 || this.PlayerDeck == 0)
      {
        objectList.Add((object) "vw_prop_cas_card_club_02");
        objectList.Add((object) "vw_prop_cas_card_club_03");
        objectList.Add((object) "vw_prop_cas_card_club_04");
        objectList.Add((object) "vw_prop_cas_card_club_05");
        objectList.Add((object) "vw_prop_cas_card_club_06");
        objectList.Add((object) "vw_prop_cas_card_club_07");
        objectList.Add((object) "vw_prop_cas_card_club_08");
        objectList.Add((object) "vw_prop_cas_card_club_09");
        objectList.Add((object) "vw_prop_cas_card_club_10");
        objectList.Add((object) "vw_prop_cas_card_club_ace");
        objectList.Add((object) "vw_prop_cas_card_club_jack");
        objectList.Add((object) "vw_prop_cas_card_club_king");
        objectList.Add((object) "vw_prop_cas_card_club_queen");
        objectList.Add((object) "vw_prop_cas_card_spd_queen");
        objectList.Add((object) "vw_prop_cas_card_spd_king");
        objectList.Add((object) "vw_prop_cas_card_spd_jack");
        objectList.Add((object) "vw_prop_cas_card_spd_ace");
        objectList.Add((object) "vw_prop_cas_card_spd_10");
        objectList.Add((object) "vw_prop_cas_card_spd_09");
        objectList.Add((object) "vw_prop_cas_card_spd_08");
        objectList.Add((object) "vw_prop_cas_card_spd_07");
        objectList.Add((object) "vw_prop_cas_card_spd_06");
        objectList.Add((object) "vw_prop_cas_card_spd_05");
        objectList.Add((object) "vw_prop_cas_card_spd_04");
        objectList.Add((object) "vw_prop_cas_card_spd_03");
        objectList.Add((object) "vw_prop_cas_card_spd_02");
        objectList.Add((object) "vw_prop_cas_card_hrt_queen");
        objectList.Add((object) "vw_prop_cas_card_hrt_king");
        objectList.Add((object) "vw_prop_cas_card_hrt_jack");
        objectList.Add((object) "vw_prop_cas_card_hrt_ace");
        objectList.Add((object) "vw_prop_cas_card_hrt_10");
        objectList.Add((object) "vw_prop_cas_card_hrt_09");
        objectList.Add((object) "vw_prop_cas_card_hrt_08");
        objectList.Add((object) "vw_prop_cas_card_hrt_07");
        objectList.Add((object) "vw_prop_cas_card_hrt_06");
        objectList.Add((object) "vw_prop_cas_card_hrt_05");
        objectList.Add((object) "vw_prop_cas_card_hrt_04");
        objectList.Add((object) "vw_prop_cas_card_hrt_03");
        objectList.Add((object) "vw_prop_cas_card_hrt_02");
        objectList.Add((object) "vw_prop_cas_card_dia_queen");
        objectList.Add((object) "vw_prop_cas_card_dia_king");
        objectList.Add((object) "vw_prop_cas_card_dia_jack");
        objectList.Add((object) "vw_prop_cas_card_dia_ace");
        objectList.Add((object) "vw_prop_cas_card_dia_10");
        objectList.Add((object) "vw_prop_cas_card_dia_09");
        objectList.Add((object) "vw_prop_cas_card_dia_08");
        objectList.Add((object) "vw_prop_cas_card_dia_07");
        objectList.Add((object) "vw_prop_cas_card_dia_06");
        objectList.Add((object) "vw_prop_cas_card_dia_05");
        objectList.Add((object) "vw_prop_cas_card_dia_04");
        objectList.Add((object) "vw_prop_cas_card_dia_03");
        objectList.Add((object) "vw_prop_cas_card_dia_02");
      }
      if (this.PlayerDeck == 2)
      {
        objectList.Add((object) "vw_prop_vw_club_char_02a");
        objectList.Add((object) "vw_prop_vw_club_char_03a");
        objectList.Add((object) "vw_prop_vw_club_char_04a");
        objectList.Add((object) "vw_prop_vw_club_char_05a");
        objectList.Add((object) "vw_prop_vw_club_char_06a");
        objectList.Add((object) "vw_prop_vw_club_char_07a");
        objectList.Add((object) "vw_prop_vw_club_char_08a");
        objectList.Add((object) "vw_prop_vw_club_char_09a");
        objectList.Add((object) "vw_prop_vw_club_char_10a");
        objectList.Add((object) "vw_prop_vw_club_char_a_a");
        objectList.Add((object) "vw_prop_vw_club_char_j_a");
        objectList.Add((object) "vw_prop_vw_club_char_k_a");
        objectList.Add((object) "vw_prop_vw_club_char_q_a");
        objectList.Add((object) "vw_prop_vw_dia_char_02a");
        objectList.Add((object) "vw_prop_vw_dia_char_03a");
        objectList.Add((object) "vw_prop_vw_dia_char_04a");
        objectList.Add((object) "vw_prop_vw_dia_char_05a");
        objectList.Add((object) "vw_prop_vw_dia_char_06a");
        objectList.Add((object) "vw_prop_vw_dia_char_07a");
        objectList.Add((object) "vw_prop_vw_dia_char_08a");
        objectList.Add((object) "vw_prop_vw_dia_char_09a");
        objectList.Add((object) "vw_prop_vw_dia_char_10a");
        objectList.Add((object) "vw_prop_vw_dia_char_a_a");
        objectList.Add((object) "vw_prop_vw_dia_char_j_a");
        objectList.Add((object) "vw_prop_vw_dia_char_k_a");
        objectList.Add((object) "vw_prop_vw_dia_char_q_a");
        objectList.Add((object) "vw_prop_vw_hrt_char_02a");
        objectList.Add((object) "vw_prop_vw_hrt_char_03a");
        objectList.Add((object) "vw_prop_vw_hrt_char_04a");
        objectList.Add((object) "vw_prop_vw_hrt_char_05a");
        objectList.Add((object) "vw_prop_vw_hrt_char_06a");
        objectList.Add((object) "vw_prop_vw_hrt_char_07a");
        objectList.Add((object) "vw_prop_vw_hrt_char_08a");
        objectList.Add((object) "vw_prop_vw_hrt_char_09a");
        objectList.Add((object) "vw_prop_vw_hrt_char_10a");
        objectList.Add((object) "vw_prop_vw_hrt_char_a_a");
        objectList.Add((object) "vw_prop_vw_hrt_char_j_a");
        objectList.Add((object) "vw_prop_vw_hrt_char_k_a");
        objectList.Add((object) "vw_prop_vw_hrt_char_q_a");
        objectList.Add((object) "vw_prop_vw_spd_char_02a");
        objectList.Add((object) "vw_prop_vw_spd_char_03a");
        objectList.Add((object) "vw_prop_vw_spd_char_04a");
        objectList.Add((object) "vw_prop_vw_spd_char_05a");
        objectList.Add((object) "vw_prop_vw_spd_char_06a");
        objectList.Add((object) "vw_prop_vw_spd_char_07a");
        objectList.Add((object) "vw_prop_vw_spd_char_08a");
        objectList.Add((object) "vw_prop_vw_spd_char_09a");
        objectList.Add((object) "vw_prop_vw_spd_char_10a");
        objectList.Add((object) "vw_prop_vw_spd_char_a_a");
        objectList.Add((object) "vw_prop_vw_spd_char_j_a");
        objectList.Add((object) "vw_prop_vw_spd_char_k_a");
        objectList.Add((object) "vw_prop_vw_spd_char_q_a");
      }
      if (this.PlayerDeck == 3)
      {
        if (this.TMD_Dealer)
        {
          if (this.PlayerDeck == 3)
          {
            if (this.TMD_UseNormalDeckCards)
            {
              if (this.TMD_Use02)
                objectList.Add((object) "vw_prop_cas_card_club_02");
              if (this.TMD_Use03)
                objectList.Add((object) "vw_prop_cas_card_club_03");
              if (this.TMD_Use04)
                objectList.Add((object) "vw_prop_cas_card_club_04");
              if (this.TMD_Use05)
                objectList.Add((object) "vw_prop_cas_card_club_05");
              if (this.TMD_Use06)
                objectList.Add((object) "vw_prop_cas_card_club_06");
              if (this.TMD_Use07)
                objectList.Add((object) "vw_prop_cas_card_club_07");
              if (this.TMD_Use08)
                objectList.Add((object) "vw_prop_cas_card_club_08");
              if (this.TMD_Use09)
                objectList.Add((object) "vw_prop_cas_card_club_09");
              if (this.TMD_Use10)
                objectList.Add((object) "vw_prop_cas_card_club_10");
              if (this.TMD_UseAce)
                objectList.Add((object) "vw_prop_cas_card_club_ace");
              if (this.TMD_UseJack)
                objectList.Add((object) "vw_prop_cas_card_club_jack");
              if (this.TMD_UseKing)
                objectList.Add((object) "vw_prop_cas_card_club_king");
              if (this.TMD_UseQueen)
                objectList.Add((object) "vw_prop_cas_card_club_queen");
              if (this.TMD_UseQueen)
                objectList.Add((object) "vw_prop_cas_card_spd_queen");
              if (this.TMD_UseKing)
                objectList.Add((object) "vw_prop_cas_card_spd_king");
              if (this.TMD_UseJack)
                objectList.Add((object) "vw_prop_cas_card_spd_jack");
              if (this.TMD_UseAce)
                objectList.Add((object) "vw_prop_cas_card_spd_ace");
              if (this.TMD_Use10)
                objectList.Add((object) "vw_prop_cas_card_spd_10");
              if (this.TMD_Use09)
                objectList.Add((object) "vw_prop_cas_card_spd_09");
              if (this.TMD_Use08)
                objectList.Add((object) "vw_prop_cas_card_spd_08");
              if (this.TMD_Use07)
                objectList.Add((object) "vw_prop_cas_card_spd_07");
              if (this.TMD_Use06)
                objectList.Add((object) "vw_prop_cas_card_spd_06");
              if (this.TMD_Use05)
                objectList.Add((object) "vw_prop_cas_card_spd_05");
              if (this.TMD_Use04)
                objectList.Add((object) "vw_prop_cas_card_spd_04");
              if (this.TMD_Use03)
                objectList.Add((object) "vw_prop_cas_card_spd_03");
              if (this.TMD_Use02)
                objectList.Add((object) "vw_prop_cas_card_spd_02");
              if (this.TMD_UseQueen)
                objectList.Add((object) "vw_prop_cas_card_hrt_queen");
              if (this.TMD_UseKing)
                objectList.Add((object) "vw_prop_cas_card_hrt_king");
              if (this.TMD_UseJack)
                objectList.Add((object) "vw_prop_cas_card_hrt_jack");
              if (this.TMD_UseAce)
                objectList.Add((object) "vw_prop_cas_card_hrt_ace");
              if (this.TMD_Use10)
                objectList.Add((object) "vw_prop_cas_card_hrt_10");
              if (this.TMD_Use09)
                objectList.Add((object) "vw_prop_cas_card_hrt_09");
              if (this.TMD_Use08)
                objectList.Add((object) "vw_prop_cas_card_hrt_08");
              if (this.TMD_Use07)
                objectList.Add((object) "vw_prop_cas_card_hrt_07");
              if (this.TMD_Use06)
                objectList.Add((object) "vw_prop_cas_card_hrt_06");
              if (this.TMD_Use05)
                objectList.Add((object) "vw_prop_cas_card_hrt_05");
              if (this.TMD_Use04)
                objectList.Add((object) "vw_prop_cas_card_hrt_04");
              if (this.TMD_Use03)
                objectList.Add((object) "vw_prop_cas_card_hrt_03");
              if (this.TMD_Use02)
                objectList.Add((object) "vw_prop_cas_card_hrt_02");
              if (this.TMD_UseQueen)
                objectList.Add((object) "vw_prop_cas_card_dia_queen");
              if (this.TMD_UseKing)
                objectList.Add((object) "vw_prop_cas_card_dia_king");
              if (this.TMD_UseJack)
                objectList.Add((object) "vw_prop_cas_card_dia_jack");
              if (this.TMD_UseAce)
                objectList.Add((object) "vw_prop_cas_card_dia_ace");
              if (this.TMD_Use10)
                objectList.Add((object) "vw_prop_cas_card_dia_10");
              if (this.TMD_Use09)
                objectList.Add((object) "vw_prop_cas_card_dia_09");
              if (this.TMD_Use08)
                objectList.Add((object) "vw_prop_cas_card_dia_08");
              if (this.TMD_Use07)
                objectList.Add((object) "vw_prop_cas_card_dia_07");
              if (this.TMD_Use06)
                objectList.Add((object) "vw_prop_cas_card_dia_06");
              if (this.TMD_Use05)
                objectList.Add((object) "vw_prop_cas_card_dia_05");
              if (this.TMD_Use04)
                objectList.Add((object) "vw_prop_cas_card_dia_04");
              if (this.TMD_Use03)
                objectList.Add((object) "vw_prop_cas_card_dia_03");
              if (this.TMD_Use02)
                objectList.Add((object) "vw_prop_cas_card_dia_02");
            }
            if (this.TMD_UseEliteDeckCards)
            {
              if (this.TMD_Use02)
                objectList.Add((object) "vw_prop_vw_club_char_02a");
              if (this.TMD_Use03)
                objectList.Add((object) "vw_prop_vw_club_char_03a");
              if (this.TMD_Use04)
                objectList.Add((object) "vw_prop_vw_club_char_04a");
              if (this.TMD_Use05)
                objectList.Add((object) "vw_prop_vw_club_char_05a");
              if (this.TMD_Use06)
                objectList.Add((object) "vw_prop_vw_club_char_06a");
              if (this.TMD_Use07)
                objectList.Add((object) "vw_prop_vw_club_char_07a");
              if (this.TMD_Use08)
                objectList.Add((object) "vw_prop_vw_club_char_08a");
              if (this.TMD_Use09)
                objectList.Add((object) "vw_prop_vw_club_char_09a");
              if (this.TMD_Use10)
                objectList.Add((object) "vw_prop_vw_club_char_10a");
              if (this.TMD_UseAce)
                objectList.Add((object) "vw_prop_vw_club_char_a_a");
              if (this.TMD_UseJack)
                objectList.Add((object) "vw_prop_vw_club_char_j_a");
              if (this.TMD_UseKing)
                objectList.Add((object) "vw_prop_vw_club_char_k_a");
              if (this.TMD_UseQueen)
                objectList.Add((object) "vw_prop_vw_club_char_q_a");
              if (this.TMD_Use02)
                objectList.Add((object) "vw_prop_vw_dia_char_02a");
              if (this.TMD_Use03)
                objectList.Add((object) "vw_prop_vw_dia_char_03a");
              if (this.TMD_Use04)
                objectList.Add((object) "vw_prop_vw_dia_char_04a");
              if (this.TMD_Use05)
                objectList.Add((object) "vw_prop_vw_dia_char_05a");
              if (this.TMD_Use06)
                objectList.Add((object) "vw_prop_vw_dia_char_06a");
              if (this.TMD_Use07)
                objectList.Add((object) "vw_prop_vw_dia_char_07a");
              if (this.TMD_Use08)
                objectList.Add((object) "vw_prop_vw_dia_char_08a");
              if (this.TMD_Use09)
                objectList.Add((object) "vw_prop_vw_dia_char_09a");
              if (this.TMD_Use10)
                objectList.Add((object) "vw_prop_vw_dia_char_10a");
              if (this.TMD_UseAce)
                objectList.Add((object) "vw_prop_vw_dia_char_a_a");
              if (this.TMD_UseJack)
                objectList.Add((object) "vw_prop_vw_dia_char_j_a");
              if (this.TMD_UseKing)
                objectList.Add((object) "vw_prop_vw_dia_char_k_a");
              if (this.TMD_UseQueen)
                objectList.Add((object) "vw_prop_vw_dia_char_q_a");
              if (this.TMD_Use02)
                objectList.Add((object) "vw_prop_vw_hrt_char_02a");
              if (this.TMD_Use03)
                objectList.Add((object) "vw_prop_vw_hrt_char_03a");
              if (this.TMD_Use04)
                objectList.Add((object) "vw_prop_vw_hrt_char_04a");
              if (this.TMD_Use05)
                objectList.Add((object) "vw_prop_vw_hrt_char_05a");
              if (this.TMD_Use06)
                objectList.Add((object) "vw_prop_vw_hrt_char_06a");
              if (this.TMD_Use07)
                objectList.Add((object) "vw_prop_vw_hrt_char_07a");
              if (this.TMD_Use08)
                objectList.Add((object) "vw_prop_vw_hrt_char_08a");
              if (this.TMD_Use09)
                objectList.Add((object) "vw_prop_vw_hrt_char_09a");
              if (this.TMD_Use10)
                objectList.Add((object) "vw_prop_vw_hrt_char_10a");
              if (this.TMD_UseAce)
                objectList.Add((object) "vw_prop_vw_hrt_char_a_a");
              if (this.TMD_UseJack)
                objectList.Add((object) "vw_prop_vw_hrt_char_j_a");
              if (this.TMD_UseKing)
                objectList.Add((object) "vw_prop_vw_hrt_char_k_a");
              if (this.TMD_UseQueen)
                objectList.Add((object) "vw_prop_vw_hrt_char_q_a");
              if (this.TMD_Use02)
                objectList.Add((object) "vw_prop_vw_spd_char_02a");
              if (this.TMD_Use03)
                objectList.Add((object) "vw_prop_vw_spd_char_03a");
              if (this.TMD_Use04)
                objectList.Add((object) "vw_prop_vw_spd_char_04a");
              if (this.TMD_Use05)
                objectList.Add((object) "vw_prop_vw_spd_char_05a");
              if (this.TMD_Use06)
                objectList.Add((object) "vw_prop_vw_spd_char_06a");
              if (this.TMD_Use07)
                objectList.Add((object) "vw_prop_vw_spd_char_07a");
              if (this.TMD_Use08)
                objectList.Add((object) "vw_prop_vw_spd_char_08a");
              if (this.TMD_Use09)
                objectList.Add((object) "vw_prop_vw_spd_char_09a");
              if (this.TMD_Use10)
                objectList.Add((object) "vw_prop_vw_spd_char_10a");
              if (this.TMD_UseAce)
                objectList.Add((object) "vw_prop_vw_spd_char_a_a");
              if (this.TMD_UseJack)
                objectList.Add((object) "vw_prop_vw_spd_char_j_a");
              if (this.TMD_UseKing)
                objectList.Add((object) "vw_prop_vw_spd_char_k_a");
              if (this.TMD_UseQueen)
                objectList.Add((object) "vw_prop_vw_spd_char_q_a");
            }
          }
        }
        else
        {
          if (this.TMD_UseNormalDeckCards)
          {
            objectList.Add((object) "vw_prop_vw_club_char_02a");
            objectList.Add((object) "vw_prop_vw_club_char_03a");
            objectList.Add((object) "vw_prop_vw_club_char_04a");
            objectList.Add((object) "vw_prop_vw_club_char_05a");
            objectList.Add((object) "vw_prop_vw_club_char_06a");
            objectList.Add((object) "vw_prop_vw_club_char_07a");
            objectList.Add((object) "vw_prop_vw_club_char_08a");
            objectList.Add((object) "vw_prop_vw_club_char_09a");
            objectList.Add((object) "vw_prop_vw_club_char_10a");
            objectList.Add((object) "vw_prop_vw_club_char_a_a");
            objectList.Add((object) "vw_prop_vw_club_char_j_a");
            objectList.Add((object) "vw_prop_vw_club_char_k_a");
            objectList.Add((object) "vw_prop_vw_club_char_q_a");
            objectList.Add((object) "vw_prop_vw_dia_char_02a");
            objectList.Add((object) "vw_prop_vw_dia_char_03a");
            objectList.Add((object) "vw_prop_vw_dia_char_04a");
            objectList.Add((object) "vw_prop_vw_dia_char_05a");
            objectList.Add((object) "vw_prop_vw_dia_char_06a");
            objectList.Add((object) "vw_prop_vw_dia_char_07a");
            objectList.Add((object) "vw_prop_vw_dia_char_08a");
            objectList.Add((object) "vw_prop_vw_dia_char_09a");
            objectList.Add((object) "vw_prop_vw_dia_char_10a");
            objectList.Add((object) "vw_prop_vw_dia_char_a_a");
            objectList.Add((object) "vw_prop_vw_dia_char_j_a");
            objectList.Add((object) "vw_prop_vw_dia_char_k_a");
            objectList.Add((object) "vw_prop_vw_dia_char_q_a");
            objectList.Add((object) "vw_prop_vw_hrt_char_02a");
            objectList.Add((object) "vw_prop_vw_hrt_char_03a");
            objectList.Add((object) "vw_prop_vw_hrt_char_04a");
            objectList.Add((object) "vw_prop_vw_hrt_char_05a");
            objectList.Add((object) "vw_prop_vw_hrt_char_06a");
            objectList.Add((object) "vw_prop_vw_hrt_char_07a");
            objectList.Add((object) "vw_prop_vw_hrt_char_08a");
            objectList.Add((object) "vw_prop_vw_hrt_char_09a");
            objectList.Add((object) "vw_prop_vw_hrt_char_10a");
            objectList.Add((object) "vw_prop_vw_hrt_char_a_a");
            objectList.Add((object) "vw_prop_vw_hrt_char_j_a");
            objectList.Add((object) "vw_prop_vw_hrt_char_k_a");
            objectList.Add((object) "vw_prop_vw_hrt_char_q_a");
            objectList.Add((object) "vw_prop_vw_spd_char_02a");
            objectList.Add((object) "vw_prop_vw_spd_char_03a");
            objectList.Add((object) "vw_prop_vw_spd_char_04a");
            objectList.Add((object) "vw_prop_vw_spd_char_05a");
            objectList.Add((object) "vw_prop_vw_spd_char_06a");
            objectList.Add((object) "vw_prop_vw_spd_char_07a");
            objectList.Add((object) "vw_prop_vw_spd_char_08a");
            objectList.Add((object) "vw_prop_vw_spd_char_09a");
            objectList.Add((object) "vw_prop_vw_spd_char_10a");
            objectList.Add((object) "vw_prop_vw_spd_char_a_a");
            objectList.Add((object) "vw_prop_vw_spd_char_j_a");
            objectList.Add((object) "vw_prop_vw_spd_char_k_a");
            objectList.Add((object) "vw_prop_vw_spd_char_q_a");
          }
          if (this.TMD_UseEliteDeckCards)
          {
            objectList.Add((object) "vw_prop_cas_card_club_02");
            objectList.Add((object) "vw_prop_cas_card_club_03");
            objectList.Add((object) "vw_prop_cas_card_club_04");
            objectList.Add((object) "vw_prop_cas_card_club_05");
            objectList.Add((object) "vw_prop_cas_card_club_06");
            objectList.Add((object) "vw_prop_cas_card_club_07");
            objectList.Add((object) "vw_prop_cas_card_club_08");
            objectList.Add((object) "vw_prop_cas_card_club_09");
            objectList.Add((object) "vw_prop_cas_card_club_10");
            objectList.Add((object) "vw_prop_cas_card_club_ace");
            objectList.Add((object) "vw_prop_cas_card_club_jack");
            objectList.Add((object) "vw_prop_cas_card_club_king");
            objectList.Add((object) "vw_prop_cas_card_club_queen");
            objectList.Add((object) "vw_prop_cas_card_spd_queen");
            objectList.Add((object) "vw_prop_cas_card_spd_king");
            objectList.Add((object) "vw_prop_cas_card_spd_jack");
            objectList.Add((object) "vw_prop_cas_card_spd_ace");
            objectList.Add((object) "vw_prop_cas_card_spd_10");
            objectList.Add((object) "vw_prop_cas_card_spd_09");
            objectList.Add((object) "vw_prop_cas_card_spd_08");
            objectList.Add((object) "vw_prop_cas_card_spd_07");
            objectList.Add((object) "vw_prop_cas_card_spd_06");
            objectList.Add((object) "vw_prop_cas_card_spd_05");
            objectList.Add((object) "vw_prop_cas_card_spd_04");
            objectList.Add((object) "vw_prop_cas_card_spd_03");
            objectList.Add((object) "vw_prop_cas_card_spd_02");
            objectList.Add((object) "vw_prop_cas_card_hrt_queen");
            objectList.Add((object) "vw_prop_cas_card_hrt_king");
            objectList.Add((object) "vw_prop_cas_card_hrt_jack");
            objectList.Add((object) "vw_prop_cas_card_hrt_ace");
            objectList.Add((object) "vw_prop_cas_card_hrt_10");
            objectList.Add((object) "vw_prop_cas_card_hrt_09");
            objectList.Add((object) "vw_prop_cas_card_hrt_08");
            objectList.Add((object) "vw_prop_cas_card_hrt_07");
            objectList.Add((object) "vw_prop_cas_card_hrt_06");
            objectList.Add((object) "vw_prop_cas_card_hrt_05");
            objectList.Add((object) "vw_prop_cas_card_hrt_04");
            objectList.Add((object) "vw_prop_cas_card_hrt_03");
            objectList.Add((object) "vw_prop_cas_card_hrt_02");
            objectList.Add((object) "vw_prop_cas_card_dia_queen");
            objectList.Add((object) "vw_prop_cas_card_dia_king");
            objectList.Add((object) "vw_prop_cas_card_dia_jack");
            objectList.Add((object) "vw_prop_cas_card_dia_ace");
            objectList.Add((object) "vw_prop_cas_card_dia_10");
            objectList.Add((object) "vw_prop_cas_card_dia_09");
            objectList.Add((object) "vw_prop_cas_card_dia_08");
            objectList.Add((object) "vw_prop_cas_card_dia_07");
            objectList.Add((object) "vw_prop_cas_card_dia_06");
            objectList.Add((object) "vw_prop_cas_card_dia_05");
            objectList.Add((object) "vw_prop_cas_card_dia_04");
            objectList.Add((object) "vw_prop_cas_card_dia_03");
            objectList.Add((object) "vw_prop_cas_card_dia_02");
          }
        }
      }
      int index = random.Next(0, objectList.Count - 1);
      // ISSUE: reference to a compiler-generated field
      if (Class1.\u003C\u003Eo__606.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class1.\u003C\u003Eo__606.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Class1)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return Class1.\u003C\u003Eo__606.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__606.\u003C\u003Ep__0, objectList[index]);
    }

    public void CalculateBlackJack()
    {
      float num1 = (float) (this.PlayerCard_1 + this.PlayerCard_2 + this.PlayerCard_3 + this.PlayerCard_4 + this.PlayerCard_5 + this.PlayerCard_6);
      float num2 = (float) (this.DealerCard_1 + this.DealerCard_2 + this.DealerCard_3 + this.DealerCard_4 + this.DealerCard_5 + this.DealerCard_6);
      Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "collect_chips", 8f, -1, true, -1f);
      UI.Notify("P " + (object) num1);
      UI.Notify("D " + (object) num2);
      this.Drawcards = false;
      if ((double) num2 == 21.0 && (double) num2 != 21.0)
      {
        this.Chips_Amount += (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_female@engaged@01b@reacts@v01", "reaction_terrible", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GamePassed("BlackJack", (int) this.Bet);
          Script.Wait(1);
        }
      }
      else if ((double) num2 > 21.0 && (double) num1 <= 21.0)
      {
        this.Chips_Amount += (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_female@engaged@01b@reacts@v01", "reaction_terrible", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GamePassed("BlackJack", (int) this.Bet);
          Script.Wait(1);
        }
      }
      else if ((double) num2 == (double) num1 && (double) num1 <= 21.0)
      {
        this.Chips_Amount += (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_female@engaged@01b@reacts@v01", "reaction_good_var01", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GamePassed("BlackJack", (int) this.Bet);
          Script.Wait(1);
        }
      }
      else if ((double) num1 > 21.0)
      {
        this.Chips_Amount -= (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_female@engaged@01b@reacts@v01", "reaction_terrible", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GameFail("You went over 21!", "BlackJack");
          Script.Wait(1);
        }
      }
      else if ((double) num1 < (double) num2 && (double) num2 <= 21.0)
      {
        this.Chips_Amount -= (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_female@engaged@01b@reacts@v01", "reaction_bad_var01", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GameFail("The Dealer had a higher Score!", "BlackJack");
          Script.Wait(1);
        }
      }
      else if ((double) num1 > (double) num2 && (double) num1 <= 21.0 || (double) num2 > 21.0)
      {
        this.Chips_Amount += (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_female@engaged@01b@reacts@v01", "reaction_good_var02", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GamePassed("BlackJack", (int) this.Bet);
          Script.Wait(1);
        }
      }
      else if ((double) num1 > (double) num2 && (double) num2 <= 21.0)
      {
        this.Chips_Amount -= (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_female@engaged@01b@reacts@v01", "reaction_bad_var02", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GameFail("The Dealer had a better Score!", "BlackJack");
          Script.Wait(1);
        }
      }
      else
      {
        Script.Wait(200);
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "collect_chips", 8f, -1, true, -1f);
        this.Playercards = 0;
        this.DealerCards = 0;
        this.PlayerCard_1 = 0;
        this.PlayerCard_2 = 0;
        this.PlayerCard_3 = 0;
        this.PlayerCard_4 = 0;
        this.PlayerCard_5 = 0;
        this.PlayerCard_6 = 0;
        this.Bet = 0.0f;
        this.DealerCard_1 = 0;
        this.DealerCard_2 = 0;
        this.DealerCard_3 = 0;
        this.DealerCard_4 = 0;
        this.DealerCard_5 = 0;
        this.DealerCard_6 = 0;
        this.Endgame = true;
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "collect_chips", 8f, -1, true, -1f);
      }
    }

    public void CalculatePoker()
    {
      float num1 = (float) (this.PlayerCard_1 * this.PlayerCard_2 * this.PlayerCard_3);
      float num2 = (float) (this.DealerCard_1 * this.DealerCard_2 * this.DealerCard_3);
      Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "collect_chips", 8f, -1, true, -1f);
      UI.Notify("P " + (object) num1);
      UI.Notify("D " + (object) num2);
      this.Drawcards = false;
      if ((double) num1 > (double) num2)
      {
        this.Chips_Amount += (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@threecardpoker@ped_male@engaged@01b@reacts@v01", "reaction_bad_var02", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GamePassed("3 Card Poker", (int) this.Bet);
          Script.Wait(1);
        }
      }
      if ((double) num1 < (double) num2)
      {
        this.Chips_Amount -= (int) this.Bet;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@threecardpoker@ped_male@engaged@01b@reacts@v01", "reaction_good_var02", 8f, -1, true, -1f);
        for (int index = 0; index < 100; ++index)
        {
          this.GameFail("The Dealer had a higher Score!", "3 Card Poker");
          Script.Wait(1);
        }
      }
      Script.Wait(200);
      Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "collect_chips", 8f, -1, true, -1f);
      this.Playercards = 0;
      this.DealerCards = 0;
      this.PlayerCard_1 = 0;
      this.PlayerCard_2 = 0;
      this.PlayerCard_3 = 0;
      this.PlayerCard_4 = 0;
      this.PlayerCard_5 = 0;
      this.PlayerCard_6 = 0;
      this.Bet = 0.0f;
      this.DealerCard_1 = 0;
      this.DealerCard_2 = 0;
      this.DealerCard_3 = 0;
      this.DealerCard_4 = 0;
      this.DealerCard_5 = 0;
      this.DealerCard_6 = 0;
      this.Endgame = true;
      Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "collect_chips", 8f, -1, true, -1f);
    }

    public int Set_PlayerCard(string CardId, int Cardnum)
    {
      string str = "num";
      int num = 0;
      if (CardId.Contains("queen") || CardId.Contains("q_a"))
      {
        str = "Queen";
        num = 10;
      }
      if (CardId.Contains("king") || CardId.Contains("k_a"))
      {
        str = "King";
        num = 10;
      }
      if (CardId.Contains("jack") || CardId.Contains("j_a"))
      {
        str = "Jack";
        num = 10;
      }
      if (CardId.Contains("ace") || CardId.Contains("a_a"))
      {
        str = "Ace";
        num = 1;
      }
      if (CardId.Contains("02"))
        num = 2;
      if (CardId.Contains("03"))
        num = 3;
      if (CardId.Contains("04"))
        num = 4;
      if (CardId.Contains("05"))
        num = 5;
      if (CardId.Contains("06"))
        num = 6;
      if (CardId.Contains("07"))
        num = 7;
      if (CardId.Contains("08"))
        num = 8;
      if (CardId.Contains("09"))
        num = 9;
      if (CardId.Contains("10"))
        num = 10;
      if (str.Equals("num"))
        UI.Notify("~g~Player~w~  got Card : " + (object) num);
      else
        UI.Notify("~g~Player~w~ got Card : " + str);
      return num;
    }

    public int Set_DealerCard(string CardId, int Cardnum)
    {
      string str = "num";
      int num = 0;
      if (CardId.Contains("queen") || CardId.Contains("q_a"))
      {
        str = "Queen";
        num = 10;
      }
      if (CardId.Contains("king") || CardId.Contains("k_a"))
      {
        str = "King";
        num = 10;
      }
      if (CardId.Contains("jack") || CardId.Contains("j_a"))
      {
        str = "Jack";
        num = 10;
      }
      if (CardId.Contains("ace") || CardId.Contains("a_a"))
      {
        str = "Ace";
        num = 1;
      }
      if (CardId.Contains("02"))
        num = 2;
      if (CardId.Contains("03"))
        num = 3;
      if (CardId.Contains("04"))
        num = 4;
      if (CardId.Contains("05"))
        num = 5;
      if (CardId.Contains("06"))
        num = 6;
      if (CardId.Contains("07"))
        num = 7;
      if (CardId.Contains("08"))
        num = 8;
      if (CardId.Contains("09"))
        num = 9;
      if (CardId.Contains("10"))
        num = 10;
      if (str.Equals("num"))
        UI.Notify("~p~Dealer~w~ got Card : " + (object) num);
      else
        UI.Notify("~p~Dealer~w~ got Card : " + str);
      return num;
    }

    public int Set_PlayerCardPoker(string CardId, int Cardnum)
    {
      string str = "num";
      int num = 0;
      if (CardId.Contains("queen") || CardId.Contains("q_a"))
      {
        str = "Queen";
        num = 13;
      }
      if (CardId.Contains("king") || CardId.Contains("k_a"))
      {
        str = "King";
        num = 14;
      }
      if (CardId.Contains("jack") || CardId.Contains("j_a"))
      {
        str = "Jack";
        num = 12;
      }
      if (CardId.Contains("ace") || CardId.Contains("a_a"))
      {
        str = "Ace";
        num = 11;
      }
      if (CardId.Contains("02"))
        num = 2;
      if (CardId.Contains("03"))
        num = 3;
      if (CardId.Contains("04"))
        num = 4;
      if (CardId.Contains("05"))
        num = 5;
      if (CardId.Contains("06"))
        num = 6;
      if (CardId.Contains("07"))
        num = 7;
      if (CardId.Contains("08"))
        num = 8;
      if (CardId.Contains("09"))
        num = 9;
      if (CardId.Contains("10"))
        num = 10;
      if (str.Equals("num"))
        UI.Notify("~g~Player~w~  got Card : " + (object) num);
      else
        UI.Notify("~g~Player~w~ got Card : " + str);
      return num;
    }

    public int Set_DealerCardPoker(string CardId, int Cardnum)
    {
      string str = "num";
      int num = 0;
      if (CardId.Contains("queen") || CardId.Contains("q_a"))
      {
        str = "Queen";
        num = 13;
      }
      if (CardId.Contains("king") || CardId.Contains("k_a"))
      {
        str = "King";
        num = 14;
      }
      if (CardId.Contains("jack") || CardId.Contains("j_a"))
      {
        str = "Jack";
        num = 12;
      }
      if (CardId.Contains("ace") || CardId.Contains("a_a"))
      {
        str = "Ace";
        num = 11;
      }
      if (CardId.Contains("02"))
        num = 2;
      if (CardId.Contains("03"))
        num = 3;
      if (CardId.Contains("04"))
        num = 4;
      if (CardId.Contains("05"))
        num = 5;
      if (CardId.Contains("06"))
        num = 6;
      if (CardId.Contains("07"))
        num = 7;
      if (CardId.Contains("08"))
        num = 8;
      if (CardId.Contains("09"))
        num = 9;
      if (CardId.Contains("10"))
        num = 10;
      return num;
    }

    public void UpgradeVehicle(Vehicle Car)
    {
      Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
      {
        InputArgument.op_Implicit(((Entity) Car).get_Handle()),
        InputArgument.op_Implicit(0)
      });
      List<object> objectList = new List<object>();
      VehicleMod[] values = (VehicleMod[]) Enum.GetValues(typeof (VehicleMod));
      for (int index = 0; index < values.Length; ++index)
      {
        int[] numArray = new int[Car.GetModCount((VehicleMod) (int) values[index])];
        int num = new Random().Next(-1, Car.GetModCount((VehicleMod) (int) values[index]));
        Car.SetMod((VehicleMod) (int) values[index], num, true);
      }
      Car.SetMod((VehicleMod) 12, 3, true);
      Car.SetMod((VehicleMod) 15, 3, true);
      Car.SetMod((VehicleMod) 13, 3, true);
      Car.SetMod((VehicleMod) 11, 3, true);
      Car.set_PrimaryColor(this.GetColor());
      Script.Wait(1);
      Car.set_SecondaryColor(this.GetColor());
      Script.Wait(1);
    }

    private void DisplayHelpTextThisFrameNoSound(string text)
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
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(-1)
      });
    }

    public void UpgradeVehicle2(Vehicle Car)
    {
      Car.SetMod((VehicleMod) 12, 3, true);
      Car.SetMod((VehicleMod) 15, 3, true);
      Car.SetMod((VehicleMod) 13, 3, true);
      Car.SetMod((VehicleMod) 11, 3, true);
    }

    public int GetCarStat(int pass, int L, int C, int CT)
    {
      pass = 0;
      this.StopCounter = true;
      int num = 0;
      if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleA))
      {
        int vehicleAStalltime = (int) this.VehicleA_stalltime;
        if ((double) vehicleAStalltime >= (double) this.VehicleA_stalltime)
          num = 1;
        if ((double) vehicleAStalltime < (double) this.VehicleB_stalltime)
          num = 0;
        if ((double) vehicleAStalltime < (double) this.VehicleC_stalltime)
          num = 0;
        if ((double) vehicleAStalltime < (double) this.VehicleD_stalltime)
          num = 0;
        if ((double) vehicleAStalltime < (double) this.VehicleE_stalltime)
          num = 0;
        if ((double) vehicleAStalltime < (double) this.VehicleF_stalltime)
          num = 0;
      }
      if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleB))
      {
        int vehicleBStalltime = (int) this.VehicleB_stalltime;
        if ((double) vehicleBStalltime >= (double) this.VehicleB_stalltime)
          num = 1;
        if ((double) vehicleBStalltime < (double) this.VehicleA_stalltime)
          num = 0;
        if ((double) vehicleBStalltime < (double) this.VehicleC_stalltime)
          num = 0;
        if ((double) vehicleBStalltime < (double) this.VehicleD_stalltime)
          num = 0;
        if ((double) vehicleBStalltime < (double) this.VehicleE_stalltime)
          num = 0;
        if ((double) vehicleBStalltime < (double) this.VehicleF_stalltime)
          num = 0;
      }
      if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleC))
      {
        int vehicleCStalltime = (int) this.VehicleC_stalltime;
        if ((double) vehicleCStalltime >= (double) this.VehicleC_stalltime)
          num = 1;
        if ((double) vehicleCStalltime < (double) this.VehicleA_stalltime)
          num = 0;
        if ((double) vehicleCStalltime < (double) this.VehicleB_stalltime)
          num = 0;
        if ((double) vehicleCStalltime < (double) this.VehicleD_stalltime)
          num = 0;
        if ((double) vehicleCStalltime < (double) this.VehicleE_stalltime)
          num = 0;
        if ((double) vehicleCStalltime < (double) this.VehicleF_stalltime)
          num = 0;
      }
      if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleD))
      {
        int vehicleDStalltime = (int) this.VehicleD_stalltime;
        if ((double) vehicleDStalltime >= (double) this.VehicleD_stalltime)
          num = 1;
        if ((double) vehicleDStalltime < (double) this.VehicleA_stalltime)
          num = 0;
        if ((double) vehicleDStalltime < (double) this.VehicleB_stalltime)
          num = 0;
        if ((double) vehicleDStalltime < (double) this.VehicleC_stalltime)
          num = 0;
        if ((double) vehicleDStalltime < (double) this.VehicleE_stalltime)
          num = 0;
        if ((double) vehicleDStalltime < (double) this.VehicleF_stalltime)
          num = 0;
      }
      if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleE))
      {
        int vehicleEStalltime = (int) this.VehicleE_stalltime;
        if ((double) vehicleEStalltime >= (double) this.VehicleE_stalltime)
          num = 1;
        if ((double) vehicleEStalltime < (double) this.VehicleA_stalltime)
          num = 0;
        if ((double) vehicleEStalltime < (double) this.VehicleB_stalltime)
          num = 0;
        if ((double) vehicleEStalltime < (double) this.VehicleC_stalltime)
          num = 0;
        if ((double) vehicleEStalltime < (double) this.VehicleD_stalltime)
          num = 0;
        if ((double) vehicleEStalltime < (double) this.VehicleF_stalltime)
          num = 0;
      }
      if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleF))
      {
        int vehicleFStalltime = (int) this.VehicleF_stalltime;
        if ((double) vehicleFStalltime >= (double) this.VehicleF_stalltime)
          num = 1;
        if ((double) vehicleFStalltime < (double) this.VehicleA_stalltime)
          num = 0;
        if ((double) vehicleFStalltime < (double) this.VehicleB_stalltime)
          num = 0;
        if ((double) vehicleFStalltime < (double) this.VehicleC_stalltime)
          num = 0;
        if ((double) vehicleFStalltime < (double) this.VehicleD_stalltime)
          num = 0;
        if ((double) vehicleFStalltime < (double) this.VehicleE_stalltime)
          num = 0;
      }
      List<object> objectList = new List<object>();
      try
      {
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
        this.IsInbettingRace = false;
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
        this.IsinInterior = true;
      }
      catch (Exception ex)
      {
        UI.Notify("~b~ error");
      }
      pass = num;
      UI.Notify("Place" + (object) pass);
      return pass;
    }

    public void EndRace()
    {
      if (Camera.op_Inequality(this.RaceCam, (Camera) null))
      {
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.RaceCam.set_IsActive(false);
        this.RaceCam.Destroy();
      }
      this.IsInbettingRace = false;
      this.modMenuPool.CloseAllMenus();
      ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
      this.IsinInterior = true;
      this.StartR = false;
      this.inRace = false;
      if (Entity.op_Inequality((Entity) this.VehicleA, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleA).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleB, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleB).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleC, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleC).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleD, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleD).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleE, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleE.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleE).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleF, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleF).Delete();
      }
      this.StartedRace = false;
      this.FinishedRace = true;
      this.CheckpointRace = false;
      this.Race = 0;
      this.CarsFinished = 0;
      using (List<Blip>.Enumerator enumerator = this.CheckPointBlips.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Blip current = enumerator.Current;
          if (Blip.op_Inequality(current, (Blip) null))
            current.Remove();
        }
      }
      this.Race = 0;
    }

    public void RunCutscene()
    {
      ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(3000f, 1000f, 2000f));
      Script.Wait(10);
      ((Entity) Game.get_Player().get_Character()).set_Position(this.MarkerExit);
      if (Camera.op_Inequality(this.RaceCam, (Camera) null))
      {
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.RaceCam.set_IsActive(false);
        this.RaceCam.Destroy();
      }
      this.RaceCam = World.CreateCamera(new Vector3(1091.11f, 208.4143f, -47f), new Vector3(0.0f, 0.0f, -37f), 100f);
      this.RaceCam.set_IsActive(true);
      this.RaceCam.set_FarClip(2000f);
      ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
      Function.Call((Hash) 569060033405794044L, new InputArgument[5]
      {
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(3000),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(0)
      });
      World.set_RenderingCamera(this.RaceCam);
      this.DisplayHelpTextThisFrame("Welcome to the Diamond Resort & Casino, We hope you enjoy your stay");
      Script.Wait(2500);
      this.RaceCam.set_Position(new Vector3(1110.61f, 217.7732f, -49.5f));
      this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, -70f));
      ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
      this.DisplayHelpTextThisFrame("Relax and stay, buy some chips from out modest dealers");
      Script.Wait(3500);
      this.RaceCam.set_Position(new Vector3(1101.68f, 254.4349f, -49.5f));
      this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, 25f));
      ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
      this.DisplayHelpTextThisFrame("Partake in Ai races to Win big or lose everything");
      Script.Wait(3500);
      this.RaceCam.set_Position(new Vector3(1137.425f, 255.1735f, -49.5f));
      this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, -47f));
      ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
      this.DisplayHelpTextThisFrame("Challenge out dealers to Poker, Blackjack or Roulette, maybe you could win");
      if (this.Casino_level >= 2)
      {
        Script.Wait(3500);
        this.RaceCam.set_Position(new Vector3(1128.999f, 264.5784f, -49.5f));
        this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, 87f));
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
        this.DisplayHelpTextThisFrame("Through these doors you wil find everything you need to manage your business");
        Script.Wait(3500);
        this.RaceCam.set_Position(new Vector3(1111.129f, 248.7507f, -46f));
        this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, 179f));
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
        this.DisplayHelpTextThisFrame("Here in your luxury office, make your losses turn in to profits, with your very own laptop");
      }
      if (this.Casino_level >= 3)
      {
        Script.Wait(3500);
        this.RaceCam.set_Position(new Vector3(959.316f, 62.11246f, 113f));
        this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, -123f));
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
        this.DisplayHelpTextThisFrame("Purchased a VIP membership?, return to the casino at any time through these doors");
        Script.Wait(3500);
        this.RaceCam.set_Position(new Vector3(962.3069f, 66.97023f, 113f));
        this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, -120f));
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
        this.DisplayHelpTextThisFrame("Or go up to your very own penthouse and relax in style");
      }
      ((Entity) Game.get_Player().get_Character()).set_Position(this.MarkerExit);
      Script.Wait(3500);
      this.RaceCam.set_Position(new Vector3(1089.484f, 217.054f, -48f));
      this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, 18f));
      ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
      this.DisplayHelpTextThisFrame("Feel like changing your Membership? Come see me at the desk");
      Script.Wait(3500);
      this.RaceCam.set_Position(new Vector3(1107.477f, 218.1732f, -49f));
      this.RaceCam.set_Rotation(new Vector3(0.0f, 0.0f, 74f));
      ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceCam.get_Position());
      this.DisplayHelpTextThisFrame("We hope you enjoy your stay at the Diamond, mabye you could win the Thrax?");
      Script.Wait(3500);
      if (Camera.op_Inequality(this.RaceCam, (Camera) null))
      {
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.RaceCam.set_IsActive(false);
        this.RaceCam.Destroy();
      }
      ((Entity) Game.get_Player().get_Character()).set_Position(this.MarkerExit);
      this.IsinInterior = true;
    }

    public Vector3 GetLocation(int Mission)
    {
      Vector3 vector3;
      ((Vector3) ref vector3).\u002Ector(0.0f, 0.0f, 0.0f);
      if (Mission == 1)
      {
        Random random = new Random();
        if (random.Next(1, 200) < 10)
          ((Vector3) ref vector3).\u002Ector(435.9571f, 260.3132f, 102f);
        if (random.Next(1, 200) > 10 && random.Next(1, 200) < 20)
          ((Vector3) ref vector3).\u002Ector(371.5314f, 294.3582f, 102f);
        if (random.Next(1, 200) > 20 && random.Next(1, 200) < 30)
          ((Vector3) ref vector3).\u002Ector(291.3882f, 349.5207f, 112f);
        if (random.Next(1, 200) > 30 && random.Next(1, 200) < 40)
          ((Vector3) ref vector3).\u002Ector(207.7685f, 194.7988f, 105f);
        if (random.Next(1, 200) > 40 && random.Next(1, 200) < 50)
          ((Vector3) ref vector3).\u002Ector(363.2462f, 137.2167f, 102f);
        if (random.Next(1, 200) > 50 && random.Next(1, 200) < 60)
          ((Vector3) ref vector3).\u002Ector(515.3366f, 83.74969f, 98f);
        if (random.Next(1, 200) > 60 && random.Next(1, 200) < 70)
          ((Vector3) ref vector3).\u002Ector(395.6515f, -128.3656f, 64f);
        if (random.Next(1, 200) > 70 && random.Next(1, 200) < 80)
          ((Vector3) ref vector3).\u002Ector(282.9732f, -85.08146f, 69f);
        if (random.Next(1, 200) > 80 && random.Next(1, 200) < 90)
          ((Vector3) ref vector3).\u002Ector(33.23817f, 252.1784f, 109f);
        if (random.Next(1, 200) > 90 && random.Next(1, 200) < 100)
          this.MissionMarker = new Vector3(-45.15516f, 35.39776f, 71f);
        if (random.Next(1, 200) > 100 && random.Next(1, 200) < 110)
          ((Vector3) ref vector3).\u002Ector(-130.8487f, 79.86409f, 70f);
        if (random.Next(1, 200) > 110 && random.Next(1, 200) < 120)
          ((Vector3) ref vector3).\u002Ector(-110.6155f, 250.7008f, 97f);
        if (random.Next(1, 200) > 120 && random.Next(1, 200) < 130)
          ((Vector3) ref vector3).\u002Ector(-109.4533f, 421.206f, 112f);
        if (random.Next(1, 200) > 130 && random.Next(1, 200) < 140)
          ((Vector3) ref vector3).\u002Ector(75.76485f, 335.261f, 111f);
        if (random.Next(1, 200) > 140 && random.Next(1, 200) < 150)
          ((Vector3) ref vector3).\u002Ector(241.6325f, 442.4417f, 120f);
        if (random.Next(1, 200) > 150 && random.Next(1, 200) < 160)
          ((Vector3) ref vector3).\u002Ector(260.3799f, 341.4453f, 105f);
        if (random.Next(1, 200) > 160 && random.Next(1, 200) < 170)
          ((Vector3) ref vector3).\u002Ector(419.9864f, 296.8545f, 102f);
        if (random.Next(1, 200) > 170 && random.Next(1, 200) < 180)
          ((Vector3) ref vector3).\u002Ector(568.1128f, 243.1724f, 102f);
        if (random.Next(1, 200) > 180 && random.Next(1, 200) < 190)
          ((Vector3) ref vector3).\u002Ector(670.9814f, 342.4697f, 110f);
        if (random.Next(1, 200) > 180 && random.Next(1, 200) < 190)
          ((Vector3) ref vector3).\u002Ector(690.9128f, 8.269f, 83f);
        if (random.Next(1, 200) > 190 && random.Next(1, 200) < 200)
          ((Vector3) ref vector3).\u002Ector(789.4373f, 154.8878f, 80f);
      }
      if (Mission == 2)
      {
        float num = (float) new Random().Next(1, 100);
        if ((double) num < 10.0)
          ((Vector3) ref vector3).\u002Ector(1728.874f, 3617.781f, 34f);
        if ((double) num > 10.0 && (double) num < 20.0)
          ((Vector3) ref vector3).\u002Ector(1647.997f, 3731.329f, 33f);
        if ((double) num > 20.0 && (double) num < 30.0)
          ((Vector3) ref vector3).\u002Ector(1576.907f, 3716.953f, 34f);
        if ((double) num > 30.0 && (double) num < 40.0)
          ((Vector3) ref vector3).\u002Ector(1670.406f, 3850.05f, 34f);
        if ((double) num > 40.0 && (double) num < 50.0)
          ((Vector3) ref vector3).\u002Ector(1885.984f, 3708f, 32f);
        if ((double) num > 50.0 && (double) num < 60.0)
          ((Vector3) ref vector3).\u002Ector(1986.129f, 3763.462f, 41f);
        if ((double) num > 60.0 && (double) num < 70.0)
          ((Vector3) ref vector3).\u002Ector(1968.089f, 3884.853f, 31f);
        if ((double) num > 70.0 && (double) num < 80.0)
          ((Vector3) ref vector3).\u002Ector(2503.986f, 4119.693f, 38f);
        if ((double) num > 80.0 && (double) num < 90.0)
          ((Vector3) ref vector3).\u002Ector(1399.522f, 3591.993f, 34f);
        if ((double) num > 90.0 && (double) num < 100.0)
          this.MissionMarker = new Vector3(1790.059f, 3333.841f, 40f);
      }
      if (Mission == 3)
      {
        float num = (float) new Random().Next(1, 100);
        if ((double) num < 10.0)
          ((Vector3) ref vector3).\u002Ector(196.0224f, 6578.627f, 31.3f);
        if ((double) num > 10.0 && (double) num < 20.0)
          ((Vector3) ref vector3).\u002Ector(40.91859f, 6374.68f, 30f);
        if ((double) num > 20.0 && (double) num < 30.0)
          ((Vector3) ref vector3).\u002Ector(-94.41034f, 6284.533f, 30f);
        if ((double) num > 30.0 && (double) num < 40.0)
          ((Vector3) ref vector3).\u002Ector(-176.123f, 6360.864f, 31f);
        if ((double) num > 40.0 && (double) num < 50.0)
          ((Vector3) ref vector3).\u002Ector(-303.5739f, 6230.992f, 30f);
        if ((double) num > 50.0 && (double) num < 60.0)
          ((Vector3) ref vector3).\u002Ector(-475.8935f, 5988.419f, 30f);
        if ((double) num > 60.0 && (double) num < 70.0)
          ((Vector3) ref vector3).\u002Ector(-287.9956f, 6046.651f, 30f);
        if ((double) num > 70.0 && (double) num < 80.0)
          ((Vector3) ref vector3).\u002Ector(-287.2152f, 6129.283f, 30f);
        if ((double) num > 80.0 && (double) num < 90.0)
          ((Vector3) ref vector3).\u002Ector(-762.4106f, 5537.076f, 33f);
        if ((double) num > 90.0 && (double) num < 100.0)
          ((Vector3) ref vector3).\u002Ector(-268.1988f, 6638.472f, 6.9f);
      }
      return vector3;
    }

    public void ShowRouletteOptions(Prop Table)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) "Quit Roulette"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) ("|   AVL Chips " + (object) this.Chips_Amount + "    |     Confirm Move")
      });
      if (this.RouletteBetsPlaced == 2)
        scaleform.CallFunction("SET_DATA_SLOT", new object[2]
        {
          (object) 3,
          (object) ("--" + this.BetPos + "--")
        });
      if (this.RouletteBetsPlaced < 2)
      {
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 4,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(58),
            InputArgument.op_Implicit(0)
          }),
          (object) ""
        });
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 5,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(80),
            InputArgument.op_Implicit(0)
          }),
          (object) " Change Marker Pos"
        });
      }
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void ShowRouletteOptionsMid(Prop Table)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) "Quit Roulette"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) "Procced"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 2,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(80),
          InputArgument.op_Implicit(0)
        }),
        (object) (" Set Green Bet " + (object) this.RouletteBet1 + "c -->")
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 3,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(58),
          InputArgument.op_Implicit(0)
        }),
        (object) (" Set Blue Bet " + (object) this.RouletteBet2 + "c -->")
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 4,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(75),
          InputArgument.op_Implicit(0)
        }),
        (object) (" Set Red Bet " + (object) this.RouletteBet3 + "c -->")
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void ShowRouletteOptionsEnd(Prop Table)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) "Quit Roulette"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) "Spin wheel"
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void ShowRouletteOptionsEndGame(Prop Table)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) "Quit Roulette"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(58),
          InputArgument.op_Implicit(0)
        }),
        (object) "Play Again"
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void SetVictory1() => this.Vic1 = 1;

    public void SetVictory2() => this.Vic2 = 1;

    public void SetVictory3() => this.Vic3 = 1;

    public void Roulette_Choose_Num()
    {
      this.Vic1 = 0;
      this.Vic2 = 0;
      this.Vic3 = 0;
      Random random = new Random();
      List<object> objectList = new List<object>();
      objectList.Add((object) "0");
      objectList.Add((object) "00");
      objectList.Add((object) "Red, 1");
      objectList.Add((object) "Black, 2");
      objectList.Add((object) "Red, 3");
      objectList.Add((object) "Black, 4");
      objectList.Add((object) "Red, 5");
      objectList.Add((object) "Black, 6");
      objectList.Add((object) "Red, 7");
      objectList.Add((object) "Black, 8");
      objectList.Add((object) "Red, 9");
      objectList.Add((object) "Black, 10");
      objectList.Add((object) "Black, 11");
      objectList.Add((object) "Red, 12");
      objectList.Add((object) "Black, 13");
      objectList.Add((object) "Red, 14");
      objectList.Add((object) "Black, 15");
      objectList.Add((object) "Red, 16");
      objectList.Add((object) "Black, 17");
      objectList.Add((object) "Red, 18");
      objectList.Add((object) "Red, 19");
      objectList.Add((object) "Black, 20");
      objectList.Add((object) "Red, 21");
      objectList.Add((object) "Black, 22");
      objectList.Add((object) "Red, 23");
      objectList.Add((object) "Black, 24");
      objectList.Add((object) "Red, 25");
      objectList.Add((object) "Black, 26");
      objectList.Add((object) "Red, 27");
      objectList.Add((object) "Black, 28");
      objectList.Add((object) "Black, 29");
      objectList.Add((object) "Red, 30");
      objectList.Add((object) "Black, 31");
      objectList.Add((object) "Red, 32");
      objectList.Add((object) "Black, 33");
      objectList.Add((object) "Red, 34");
      objectList.Add((object) "Black, 35");
      objectList.Add((object) "Red, 36");
      string str1 = "";
      float num1 = 0.0f;
      for (int index1 = 0; index1 < random.Next(10, 100); ++index1)
      {
        for (int index2 = 0; index2 < objectList.Count; ++index2)
        {
          Script.Wait(1);
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__627.\u003C\u003Ep__0 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__627.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Class1)));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          str1 = Class1.\u003C\u003Eo__627.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__627.\u003C\u003Ep__0, objectList[index1]);
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__627.\u003C\u003Ep__2 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__627.\u003C\u003Ep__2 = CallSite<Action<CallSite, Class1, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "DisplayHelpTextThisFrameNoSound", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Action<CallSite, Class1, object> target = Class1.\u003C\u003Eo__627.\u003C\u003Ep__2.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Action<CallSite, Class1, object>> p2 = Class1.\u003C\u003Eo__627.\u003C\u003Ep__2;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__627.\u003C\u003Ep__1 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__627.\u003C\u003Ep__1 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj = Class1.\u003C\u003Eo__627.\u003C\u003Ep__1.Target((CallSite) Class1.\u003C\u003Eo__627.\u003C\u003Ep__1, "Rolling... ", objectList[index1]);
          target((CallSite) p2, this, obj);
          num1 += 0.25f;
          float num2 = (float) random.Next(70, 100);
          if ((double) num1 > (double) num2)
          {
            UI.Notify("RETURN");
            break;
          }
        }
      }
      this.DisplayHelpTextThisFrameNoSound("Number : " + str1);
      string str2 = "";
      int num3 = 0;
      if (str1.Contains(","))
      {
        try
        {
          string[] strArray = str1.Split(',');
          str2 = strArray[0];
          num3 = int.Parse(strArray[1]);
        }
        catch
        {
          UI.Notify("error");
        }
      }
      UI.Notify("Current " + str1);
      string rouletteP1 = this.RouletteP1;
      string str3 = str2;
      int num4 = num3;
      UI.Notify("Num " + (object) num4);
      UI.Notify("Prize : " + rouletteP1);
      if (rouletteP1.Equals("Black") || rouletteP1.Equals("Red"))
      {
        if (str1.Contains(rouletteP1))
          this.SetVictory1();
      }
      else if (rouletteP1.Equals("Odd"))
      {
        if (num4 % 2 != 0)
          this.SetVictory1();
      }
      else if (rouletteP1.Equals("Even"))
      {
        if (num4 % 2 == 0)
          this.SetVictory1();
      }
      else if (rouletteP1.Equals("1st Column"))
      {
        if (num4 == 1 || num4 == 4 || (num4 == 7 || num4 == 10) || (num4 == 13 || num4 == 16 || (num4 == 19 || num4 == 22)) || (num4 == 25 || num4 == 28 || num4 == 31) || num4 == 34)
          this.SetVictory1();
      }
      else if (rouletteP1.Equals("2nd Column"))
      {
        if (num4 == 3 || num4 == 6 || (num4 == 9 || num4 == 12) || (num4 == 15 || num4 == 18 || (num4 == 21 || num4 == 24)) || (num4 == 27 || num4 == 30 || num4 == 33) || num4 == 36)
          this.SetVictory1();
      }
      else if (rouletteP1.Equals("3rd Column"))
      {
        if (num4 == 2 || num4 == 5 || (num4 == 8 || num4 == 11) || (num4 == 14 || num4 == 17 || (num4 == 20 || num4 == 23)) || (num4 == 26 || num4 == 29 || num4 == 32) || num4 == 35)
          this.SetVictory1();
      }
      else if (rouletteP1.Equals("1st 12"))
      {
        for (int index = 1; index < 13; ++index)
        {
          if (num4 == index)
            this.SetVictory1();
        }
      }
      else if (rouletteP1.Equals("2nd 12"))
      {
        for (int index = 13; index < 25; ++index)
        {
          if (num4 == index)
            this.SetVictory1();
        }
      }
      else if (rouletteP1.Equals("3rd 12"))
      {
        for (int index = 25; index < 37; ++index)
        {
          if (num4 == index)
            this.SetVictory1();
        }
      }
      else if (rouletteP1.Equals("1 to 18"))
      {
        for (int index = 1; index < 19; ++index)
        {
          if (num4 == index)
            this.SetVictory1();
        }
      }
      if (rouletteP1.Equals("19 to 36"))
      {
        for (int index = 19; index < 37; ++index)
        {
          if (num4 == index)
            this.SetVictory1();
        }
      }
      UI.Notify("V1 : " + (object) this.Vic1);
      string rouletteP2_1 = this.RouletteP2;
      str3 = str2;
      int num5 = num3;
      UI.Notify("Num " + (object) num5);
      UI.Notify("Prize : " + rouletteP2_1);
      if (rouletteP2_1.Equals("Black") || rouletteP2_1.Equals("Red"))
      {
        if (str1.Contains(rouletteP2_1))
          this.SetVictory2();
      }
      else if (rouletteP2_1.Equals("Odd"))
      {
        if (num5 % 2 != 0)
          this.SetVictory2();
      }
      else if (rouletteP2_1.Equals("Even"))
      {
        if (num5 % 2 == 0)
          this.SetVictory2();
      }
      else if (rouletteP2_1.Equals("1st Column"))
      {
        if (num5 == 1 || num5 == 4 || (num5 == 7 || num5 == 10) || (num5 == 13 || num5 == 16 || (num5 == 19 || num5 == 22)) || (num5 == 25 || num5 == 28 || num5 == 31) || num5 == 34)
          this.SetVictory2();
      }
      else if (rouletteP2_1.Equals("2nd Column"))
      {
        if (num5 == 3 || num5 == 6 || (num5 == 9 || num5 == 12) || (num5 == 15 || num5 == 18 || (num5 == 21 || num5 == 24)) || (num5 == 27 || num5 == 30 || num5 == 33) || num5 == 36)
          this.SetVictory2();
      }
      else if (rouletteP2_1.Equals("3rd Column"))
      {
        if (num5 == 2 || num5 == 5 || (num5 == 8 || num5 == 11) || (num5 == 14 || num5 == 17 || (num5 == 20 || num5 == 23)) || (num5 == 26 || num5 == 29 || num5 == 32) || num5 == 35)
          this.SetVictory2();
      }
      else if (rouletteP2_1.Equals("1st 12"))
      {
        for (int index = 1; index < 13; ++index)
        {
          if (num5 == index)
            this.SetVictory2();
        }
      }
      else if (rouletteP2_1.Equals("2nd 12"))
      {
        for (int index = 13; index < 25; ++index)
        {
          if (num5 == index)
            this.SetVictory2();
        }
      }
      else if (rouletteP2_1.Equals("3rd 12"))
      {
        for (int index = 25; index < 37; ++index)
        {
          if (num5 == index)
            this.SetVictory2();
        }
      }
      else if (rouletteP2_1.Equals("1 to 18"))
      {
        for (int index = 1; index < 19; ++index)
        {
          if (num5 == index)
            this.SetVictory2();
        }
      }
      if (rouletteP2_1.Equals("19 to 36"))
      {
        for (int index = 19; index < 37; ++index)
        {
          if (num5 == index)
            this.SetVictory2();
        }
      }
      UI.Notify("V2 : " + (object) this.Vic2);
      string rouletteP2_2 = this.RouletteP2;
      str3 = str2;
      int num6 = num3;
      UI.Notify("Num " + (object) num6);
      UI.Notify("Prize : " + rouletteP2_2);
      if (rouletteP2_2.Equals("Black") || rouletteP2_2.Equals("Red"))
      {
        if (str1.Contains(rouletteP2_2))
          this.SetVictory3();
      }
      else if (rouletteP2_2.Equals("Odd"))
      {
        if (num6 % 2 != 0)
          this.SetVictory3();
      }
      else if (rouletteP2_2.Equals("Even"))
      {
        if (num6 % 2 == 0)
          this.SetVictory3();
      }
      else if (rouletteP2_2.Equals("1st Column"))
      {
        if (num6 == 1 || num6 == 4 || (num6 == 7 || num6 == 10) || (num6 == 13 || num6 == 16 || (num6 == 19 || num6 == 22)) || (num6 == 25 || num6 == 28 || num6 == 31) || num6 == 34)
          this.SetVictory3();
      }
      else if (rouletteP2_2.Equals("2nd Column"))
      {
        if (num6 == 3 || num6 == 6 || (num6 == 9 || num6 == 12) || (num6 == 15 || num6 == 18 || (num6 == 21 || num6 == 24)) || (num6 == 27 || num6 == 30 || num6 == 33) || num6 == 36)
          this.SetVictory3();
      }
      else if (rouletteP2_2.Equals("3rd Column"))
      {
        if (num6 == 2 || num6 == 5 || (num6 == 8 || num6 == 11) || (num6 == 14 || num6 == 17 || (num6 == 20 || num6 == 23)) || (num6 == 26 || num6 == 29 || num6 == 32) || num6 == 35)
          this.SetVictory3();
      }
      else if (rouletteP2_2.Equals("1st 12"))
      {
        for (int index = 1; index < 13; ++index)
        {
          if (num6 == index)
            this.SetVictory3();
        }
      }
      else if (rouletteP2_2.Equals("2nd 12"))
      {
        for (int index = 13; index < 25; ++index)
        {
          if (num6 == index)
            this.SetVictory3();
        }
      }
      else if (rouletteP2_2.Equals("3rd 12"))
      {
        for (int index = 25; index < 37; ++index)
        {
          if (num6 == index)
            this.SetVictory3();
        }
      }
      else if (rouletteP2_2.Equals("1 to 18"))
      {
        for (int index = 1; index < 19; ++index)
        {
          if (num6 == index)
            this.SetVictory3();
        }
      }
      if (rouletteP2_2.Equals("19 to 36"))
      {
        for (int index = 19; index < 37; ++index)
        {
          if (num6 == index)
            this.SetVictory3();
        }
      }
      UI.Notify("V3 : " + (object) this.Vic3);
      float num7 = (float) (this.Vic1 + this.Vic2 + this.Vic3);
      float num8 = 0.0f;
      float num9 = 0.0f;
      if (this.Vic1 == 1)
        num8 += this.RouletteBet1;
      if (this.Vic2 == 1)
        num8 += this.RouletteBet2;
      if (this.Vic3 == 1)
        num8 += this.RouletteBet3;
      if (this.Vic1 == 0)
        num9 += this.RouletteBet1;
      if (this.Vic2 == 0)
        num9 += this.RouletteBet2;
      if (this.Vic3 == 0)
        num9 += this.RouletteBet3;
      if ((double) num7 == 0.0)
      {
        for (int index = 0; index < 100; ++index)
        {
          Script.Wait(1);
          this.Roulette_GameFail("You lost All bets!", "Major Defeat", "Roulette", (int) num9);
        }
        this.Chips_Amount -= (int) num9;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
      }
      if ((double) num7 == 1.0)
      {
        for (int index = 0; index < 100; ++index)
        {
          Script.Wait(1);
          this.Roulette_GameFail("You lost 2/3", "Minor Defeat", "Roulette ", (int) num9);
        }
        this.Chips_Amount -= (int) num9;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
      }
      if ((double) num7 == 2.0)
      {
        for (int index = 0; index < 100; ++index)
        {
          Script.Wait(1);
          this.Roulette_GamePassed("Roulette ", "Minor Victory", (int) num8, (int) num9);
        }
        this.Chips_Amount += (int) num8;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
      }
      if ((double) num7 == 3.0)
      {
        for (int index = 0; index < 100; ++index)
        {
          Script.Wait(1);
          this.Roulette_GamePassed("Roulette ", "Major Victory", (int) num8, (int) num9);
        }
        this.Chips_Amount += (int) num8;
        this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
        this.Config.Save();
      }
      ++this.MarkerNum;
    }

    public void Roulette_GamePassed(string MissionName, string vic, int Payout, int loss)
    {
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 700), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(vic, new Point(int32, 200), 1.5f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Payout : " + Payout.ToString("N") + "c", new Point(int32, 300), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Loss : " + loss.ToString("N") + "c", new Point(int32, 380), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      new Scaleform(0).Render2D();
    }

    public void Roulette_GameFail(string Reason, string vic, string MissionName, int Payout)
    {
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 30), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 700), 0.0f, Color.FromArgb(230, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 148, 27, 46), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(vic, new Point(int32, 200), 1.5f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Reason : " + Reason, new Point(int32, 280), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Loss : " + Payout.ToString("N") + "c", new Point(int32, 340), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      new Scaleform(0).Render2D();
    }

    public void PlayDealerAnim(Ped ped)
    {
      Random random = new Random();
      float num = (float) random.Next(1, 27);
      ped.set_BlockPermanentEvents(true);
      if ((double) num < 2.0)
      {
        Prop prop = World.CreateProp(this.RequestModel("vw_prop_casino_cards_01"), ped.GetBoneCoord((Bone) 28422, new Vector3(0.0f, 0.0f, 0.0f)), true, false);
        this.Card_Deck.Add(prop);
        Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
        {
          InputArgument.op_Implicit(prop),
          InputArgument.op_Implicit(ped),
          InputArgument.op_Implicit(ped.GetBoneIndex((Bone) 6286)),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(1)
        });
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@threecardpoker@dealer", "deck_shuffle", (float) random.Next(64, 320), -1, true, -1f);
      }
      if ((double) num >= 2.0 && (double) num < 5.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@dealer_female", "dealer_idle", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 5.0 && (double) num < 7.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@dealer_female", "dealer_focus_player_01_idle", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 7.0 && (double) num < 10.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@shared@dealer@", "female_idle_var_01", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 10.0 && (double) num < 12.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@shared@dealer@", "female_idle_var_02", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 12.0 && (double) num < 14.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@shared@dealer@", "female_idle_var_03", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 14.0 && (double) num < 17.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@shared@dealer@", "female_idle_var_04", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 17.0 && (double) num < 20.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@shared@dealer@", "female_idle_var_05", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 20.0 && (double) num < 23.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@shared@dealer@", "female_idle_var_06", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 23.0 && (double) num < 25.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@shared@dealer@", "female_idle_var_07", (float) random.Next(64, 320), -1, true, -1f);
      if ((double) num >= 25.0 && (double) num < 28.0)
        ped.get_Task().PlayAnimation("anim_casino_b@amb@casino@games@shared@dealer@", "female_idle_var_08", (float) random.Next(64, 320), -1, true, -1f);
      ped.set_AlwaysKeepTask(true);
    }

    public Color GetRandomMultiColour()
    {
      Color color = Color.Beige;
      int num = new Random().Next(1, 200);
      if (num > 0 && num < 10)
        color = Color.Blue;
      if (num > 10 && num < 20)
        color = Color.Yellow;
      if (num > 20 && num < 30)
        color = Color.Lime;
      if (num > 30 && num < 40)
        color = Color.Red;
      if (num > 40 && num < 50)
        color = Color.Orange;
      if (num > 50 && num < 60)
        color = Color.Pink;
      if (num > 60 && num < 70)
        color = Color.White;
      if (num > 70 && num < 80)
        color = Color.LightBlue;
      if (num > 80 && num < 90)
        color = Color.Magenta;
      if (num > 90 && num < 100)
        color = Color.OrangeRed;
      if (num > 100 && num < 110)
        color = Color.Green;
      if (num > 110 && num < 120)
        color = Color.YellowGreen;
      if (num > 120 && num < 130)
        color = Color.Violet;
      if (num > 130 && num < 140)
        color = Color.Cyan;
      if (num > 140 && num < 150)
        color = Color.SkyBlue;
      if (num > 150 && num < 160)
        color = Color.Silver;
      if (num > 160 && num < 170)
        color = Color.HotPink;
      if (num > 170 && num < 180)
        color = Color.DarkBlue;
      if (num > 180 && num < 190)
        color = Color.DarkRed;
      if (num > 190 && num < 200)
        color = Color.MidnightBlue;
      return color;
    }

    public void Show_RQE(string R, string Q, string E)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) E
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) Q
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 2,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(80),
          InputArgument.op_Implicit(0)
        }),
        (object) R
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void Show_EGQ(string E, string G, string Q)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) E
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(58),
          InputArgument.op_Implicit(0)
        }),
        (object) G
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 2,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) Q
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void Show_GQ(string G, string Q)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(58),
          InputArgument.op_Implicit(0)
        }),
        (object) G
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) Q
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void Show_EQ(string E, string Q)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) E
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) Q
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void Show_EQ_Chips(string E, string Q)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) ("AVL Chips " + (object) this.Chips_Amount + "  |  " + E)
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) Q
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void Show_EG(string E, string G)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(51),
          InputArgument.op_Implicit(0)
        }),
        (object) E
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(58),
          InputArgument.op_Implicit(0)
        }),
        (object) G
      });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    private void OnTick(object sender, EventArgs e)
    {
      this.OnKeyDown();
      if (this.modMenuPool != null && this.modMenuPool.IsAnyMenuOpen())
        this.modMenuPool.ProcessMenus();
      if (this.Casino_level >= 3 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WherehouseMarker) < 60.0)
        World.DrawMarker((MarkerType) 1, this.WherehouseMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(3f, 3f, 1f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(967.5843f, 53.32793f, 116f)) < 2.0 || (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(967.5843f, 53.32793f, 116f)) <= 2.0)
        ;
      if (Entity.op_Inequality((Entity) this.CurrentArtProp, (Entity) null))
      {
        if (Game.IsControlPressed(2, (Control) 44))
          ((Entity) this.CurrentArtProp).set_Rotation(new Vector3(0.0f, 0.0f, (float) (((Entity) this.CurrentArtProp).get_Rotation().Z + 1.0)));
        if (Game.IsControlPressed(2, (Control) 51))
          ((Entity) this.CurrentArtProp).set_Rotation(new Vector3(0.0f, 0.0f, (float) (((Entity) this.CurrentArtProp).get_Rotation().Z - 1.0)));
      }
      for (int index = 0; index < this.SculptLoc.Count; ++index)
      {
        if (this.modMenuPool.IsAnyMenuOpen() && (this.submenu12s.get_Visible() || this.submenu13s.get_Visible() || this.submenu14s.get_Visible()))
        {
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__2 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, bool> target1 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__2.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, bool>> p2 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__2;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__1 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, float, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThan, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, float, object> target2 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__1.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, float, object>> p1 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__1;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__0 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__0 = CallSite<Func<CallSite, System.Type, Vector3, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetDistance", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[3]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj1 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__638.\u003C\u003Ep__0, typeof (World), ((Entity) Game.get_Player().get_Character()).get_Position(), this.SculptLoc[index]);
          object obj2 = target2((CallSite) p1, obj1, 0.5f);
          if (target1((CallSite) p2, obj2))
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__638.\u003C\u003Ep__4 = CallSite<Action<CallSite, System.Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Notify", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            Action<CallSite, System.Type, object> target3 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__4.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Action<CallSite, System.Type, object>> p4 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__4;
            System.Type type = typeof (UI);
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__638.\u003C\u003Ep__3 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj3 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__3.Target((CallSite) Class1.\u003C\u003Eo__638.\u003C\u003Ep__3, "p ", this.SculptLoc[index]);
            target3((CallSite) p4, type, obj3);
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__5 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__638.\u003C\u003Ep__5 = CallSite<Action<CallSite, System.Type, MarkerType, object, Vector3, Vector3, Vector3, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "DrawMarker", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__5.Target((CallSite) Class1.\u003C\u003Eo__638.\u003C\u003Ep__5, typeof (World), (MarkerType) 28, this.SculptLoc[index], new Vector3(0.0f, 0.0f, 0.0f), Vector3.get_Zero(), new Vector3(0.1f, 0.1f, 0.1f), Color.Red);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__6 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__638.\u003C\u003Ep__6 = CallSite<Action<CallSite, System.Type, MarkerType, object, Vector3, Vector3, Vector3, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "DrawMarker", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__6.Target((CallSite) Class1.\u003C\u003Eo__638.\u003C\u003Ep__6, typeof (World), (MarkerType) 28, this.SculptLoc[index], new Vector3(0.0f, 0.0f, 0.0f), Vector3.get_Zero(), new Vector3(0.1f, 0.1f, 0.1f), Color.Blue);
          }
        }
      }
      if (!this.modMenuPool.IsAnyMenuOpen() && !this.CheckpointRace && this.CamActive)
      {
        this.CamActive = false;
        if (Camera.op_Inequality(this.ArtPropCam, (Camera) null))
        {
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          this.ArtPropCam.set_IsActive(false);
          this.ArtPropCam.Destroy();
        }
      }
      if (this.mainMenu.get_Visible())
        this.modMenuPool.CloseAllMenus();
      if (!this.modMenuPool.IsAnyMenuOpen() && Entity.op_Inequality((Entity) this.CurrentArtProp, (Entity) null))
        ((Entity) this.CurrentArtProp).Delete();
      for (int index = 0; index < this.PLocations.Count; ++index)
      {
        if (this.modMenuPool.IsAnyMenuOpen() && (this.submenu12s.get_Visible() || this.submenu13s.get_Visible() || this.submenu14s.get_Visible()))
        {
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__9 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__9 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, bool> target1 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__9.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, bool>> p9 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__9;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__8 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__8 = CallSite<Func<CallSite, object, float, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThan, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, float, object> target2 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__8.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, float, object>> p8 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__8;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__7 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__7 = CallSite<Func<CallSite, System.Type, Vector3, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetDistance", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[3]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj1 = Class1.\u003C\u003Eo__638.\u003C\u003Ep__7.Target((CallSite) Class1.\u003C\u003Eo__638.\u003C\u003Ep__7, typeof (World), ((Entity) Game.get_Player().get_Character()).get_Position(), this.PLocations[index]);
          object obj2 = target2((CallSite) p8, obj1, 0.5f);
          if (target1((CallSite) p9, obj2))
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__10 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__638.\u003C\u003Ep__10 = CallSite<Action<CallSite, System.Type, MarkerType, object, Vector3, Vector3, Vector3, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "DrawMarker", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__10.Target((CallSite) Class1.\u003C\u003Eo__638.\u003C\u003Ep__10, typeof (World), (MarkerType) 28, this.PLocations[index], new Vector3(0.0f, 0.0f, 0.0f), Vector3.get_Zero(), new Vector3(0.1f, 0.1f, 0.1f), Color.Green);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__638.\u003C\u003Ep__11 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__638.\u003C\u003Ep__11 = CallSite<Action<CallSite, System.Type, MarkerType, object, Vector3, Vector3, Vector3, Color>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "DrawMarker", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__638.\u003C\u003Ep__11.Target((CallSite) Class1.\u003C\u003Eo__638.\u003C\u003Ep__11, typeof (World), (MarkerType) 28, this.PLocations[index], new Vector3(0.0f, 0.0f, 0.0f), Vector3.get_Zero(), new Vector3(0.1f, 0.1f, 0.1f), Color.Blue);
          }
        }
      }
      if (!this.modMenuPool.IsAnyMenuOpen() && Camera.op_Inequality(this.RaceCam, (Camera) null) && (this.RaceCam.get_IsActive() && !this.IsInbettingRace))
      {
        if (Camera.op_Inequality(this.RaceCam, (Camera) null))
        {
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          this.RaceCam.set_IsActive(false);
          this.RaceCam.Destroy();
        }
        this.IsInbettingRace = false;
        this.modMenuPool.CloseAllMenus();
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
        this.IsinInterior = true;
        this.StartR = false;
        this.inRace = false;
        if (Entity.op_Inequality((Entity) this.VehicleA, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleA).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleB, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleB).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleC, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleC).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleD, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleD).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleE, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleE.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleE).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleF, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleF).Delete();
        }
        this.StartedRace = false;
        this.FinishedRace = true;
        this.CheckpointRace = false;
        this.Race = 0;
        this.CarsFinished = 0;
        using (List<Blip>.Enumerator enumerator = this.CheckPointBlips.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            Blip current = enumerator.Current;
            if (Blip.op_Inequality(current, (Blip) null))
              current.Remove();
          }
        }
        this.Race = 0;
        this.EndRace();
      }
      if (this.ActiveInt && !this.Pent_Menu.get_Visible())
      {
        this.ActiveInt = false;
        this.DeletePentInterior();
        this.RefreshPenthouse();
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(3000f, 1000f, 2000f)) < 3.0)
        this.ReReadIni();
      if (Entity.op_Equality((Entity) this.VIPBlocker, (Entity) null) && this.Casino_level < 2)
      {
        this.VIPBlocker = World.CreateProp(Model.op_Implicit("prop_ch2_09c_garage_door"), new Vector3(1122.447f, 264.3859f, -53f), false, false);
        ((Entity) this.VIPBlocker).set_FreezePosition(true);
        ((Entity) this.VIPBlocker).set_HasCollision(true);
        ((Entity) this.VIPBlocker).set_Rotation(new Vector3(0.0f, 0.0f, -90f));
        ((Entity) this.VIPBlocker).set_IsVisible(false);
      }
      if (Entity.op_Inequality((Entity) this.VIPBlocker, (Entity) null) && this.Casino_level >= 2)
        ((Entity) this.VIPBlocker).Delete();
      if (this.IsInbettingRace && Entity.op_Inequality((Entity) this.SpectateCar, (Entity) null))
      {
        if ((double) World.GetDistance(((Entity) this.VehicleA).get_Position(), this.CheckpointPos[0]) < 5.0 && ((Entity) this.VehicleA).get_Alpha() == (int) byte.MaxValue)
        {
          Vehicle vehicleA = this.VehicleA;
          ((Entity) vehicleA).set_Alpha(((Entity) vehicleA).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleA_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleA_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleA_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleA_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleA_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleA_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleA).get_Position(), this.CheckpointPos[1]) < 5.0 && ((Entity) this.VehicleA).get_Alpha() == 254)
        {
          Vehicle vehicleA = this.VehicleA;
          ((Entity) vehicleA).set_Alpha(((Entity) vehicleA).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleA_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleA_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleA_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleA_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleA_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleA_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleA).get_Position(), this.CheckpointPos[2]) < 5.0 && ((Entity) this.VehicleA).get_Alpha() == 253)
        {
          ((Entity) this.VehicleA).set_Alpha((int) byte.MaxValue);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleA_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleA_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleA_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleA_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleA_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleA_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleB).get_Position(), this.CheckpointPos[0]) < 5.0 && ((Entity) this.VehicleB).get_Alpha() == (int) byte.MaxValue)
        {
          Vehicle vehicleB = this.VehicleB;
          ((Entity) vehicleB).set_Alpha(((Entity) vehicleB).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleB_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleB_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleB_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleB_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleB_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleB_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleB).get_Position(), this.CheckpointPos[1]) < 5.0 && ((Entity) this.VehicleB).get_Alpha() == 254)
        {
          Vehicle vehicleB = this.VehicleB;
          ((Entity) vehicleB).set_Alpha(((Entity) vehicleB).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleB_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleB_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleB_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleB_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleB_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleB_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleB).get_Position(), this.CheckpointPos[2]) < 5.0 && ((Entity) this.VehicleB).get_Alpha() == 253)
        {
          ((Entity) this.VehicleB).set_Alpha((int) byte.MaxValue);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleB_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleB_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleB_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleB_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleB_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleB_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleC).get_Position(), this.CheckpointPos[0]) < 5.0 && ((Entity) this.VehicleC).get_Alpha() == (int) byte.MaxValue)
        {
          Vehicle vehicleC = this.VehicleC;
          ((Entity) vehicleC).set_Alpha(((Entity) vehicleC).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleC_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleC_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleC_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleC_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleC_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleC_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleC).get_Position(), this.CheckpointPos[1]) < 5.0 && ((Entity) this.VehicleC).get_Alpha() == 254)
        {
          Vehicle vehicleC = this.VehicleC;
          ((Entity) vehicleC).set_Alpha(((Entity) vehicleC).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleC_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleC_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleC_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleC_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleC_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleC_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleC).get_Position(), this.CheckpointPos[2]) < 5.0 && ((Entity) this.VehicleC).get_Alpha() == 253)
        {
          ((Entity) this.VehicleC).set_Alpha((int) byte.MaxValue);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleC_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleC_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleC_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleC_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleC_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleC_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleD).get_Position(), this.CheckpointPos[0]) < 5.0 && ((Entity) this.VehicleD).get_Alpha() == (int) byte.MaxValue)
        {
          Vehicle vehicleD = this.VehicleD;
          ((Entity) vehicleD).set_Alpha(((Entity) vehicleD).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleD_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleD_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleD_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleD_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleD_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleD_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleD).get_Position(), this.CheckpointPos[1]) < 5.0 && ((Entity) this.VehicleD).get_Alpha() == 254)
        {
          Vehicle vehicleD = this.VehicleD;
          ((Entity) vehicleD).set_Alpha(((Entity) vehicleD).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleD_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleD_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleD_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleD_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleD_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleD_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleD).get_Position(), this.CheckpointPos[2]) < 5.0 && ((Entity) this.VehicleD).get_Alpha() == 253)
        {
          ((Entity) this.VehicleD).set_Alpha((int) byte.MaxValue);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleD_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleD_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleD_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleD_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleD_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleD_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleE).get_Position(), this.CheckpointPos[0]) < 5.0 && ((Entity) this.VehicleE).get_Alpha() == (int) byte.MaxValue)
        {
          Vehicle vehicleE = this.VehicleE;
          ((Entity) vehicleE).set_Alpha(((Entity) vehicleE).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleE_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleE_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleE_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleE_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleE_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleE_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleE).get_Position(), this.CheckpointPos[1]) < 5.0 && ((Entity) this.VehicleE).get_Alpha() == 254)
        {
          Vehicle vehicleE = this.VehicleE;
          ((Entity) vehicleE).set_Alpha(((Entity) vehicleE).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleE_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleE_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleE_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleE_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleE_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleE_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleE).get_Position(), this.CheckpointPos[2]) < 5.0 && ((Entity) this.VehicleE).get_Alpha() == 253)
        {
          ((Entity) this.VehicleE).set_Alpha((int) byte.MaxValue);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleE_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleE_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleE_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleE_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleE_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleE_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleF).get_Position(), this.CheckpointPos[0]) < 5.0 && ((Entity) this.VehicleF).get_Alpha() == (int) byte.MaxValue)
        {
          Vehicle vehicleF = this.VehicleF;
          ((Entity) vehicleF).set_Alpha(((Entity) vehicleF).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleF_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleF_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleF_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleF_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleF_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleF_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleF).get_Position(), this.CheckpointPos[1]) < 5.0 && ((Entity) this.VehicleF).get_Alpha() == 254)
        {
          Vehicle vehicleF = this.VehicleF;
          ((Entity) vehicleF).set_Alpha(((Entity) vehicleF).get_Alpha() - 1);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleF_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleF_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleF_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleF_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleF_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleF_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if ((double) World.GetDistance(((Entity) this.VehicleF).get_Position(), this.CheckpointPos[2]) < 5.0 && ((Entity) this.VehicleF).get_Alpha() == 253)
        {
          ((Entity) this.VehicleF).set_Alpha((int) byte.MaxValue);
          ++this.CarsCounted;
          if (this.CarsCounted == 1)
            this.VehicleF_stalltime += 300f;
          if (this.CarsCounted == 2)
            this.VehicleF_stalltime += 250f;
          if (this.CarsCounted == 3)
            this.VehicleF_stalltime += 200f;
          if (this.CarsCounted == 4)
            this.VehicleF_stalltime += 150f;
          if (this.CarsCounted == 5)
            this.VehicleF_stalltime += 100f;
          if (this.CarsCounted == 6)
          {
            this.VehicleF_stalltime += 50f;
            this.CarsCounted = 0;
          }
        }
        if (!this.CamActive)
        {
          Vector3 vector3;
          ((Vector3) ref vector3).\u002Ector((float) ((Entity) this.SpectateCar).get_Position().X, (float) ((Entity) this.SpectateCar).get_Position().Y, (float) (((Entity) this.SpectateCar).get_Position().Z + 1.0));
          World.DrawMarker((MarkerType) 0, vector3, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        }
        if (this.CamActive)
        {
          Vector3 vector3;
          ((Vector3) ref vector3).\u002Ector((float) ((Entity) this.SpectateCar).get_Position().X, (float) ((Entity) this.SpectateCar).get_Position().Y, (float) (((Entity) this.SpectateCar).get_Position().Z + 5.0));
          if (Camera.op_Inequality(this.RaceCam, (Camera) null))
          {
            if (!this.StopCounter)
            {
              if (((Entity) this.VehicleA).get_FreezePosition())
                ++this.VehicleA_stalltime;
              if (((Entity) this.VehicleB).get_FreezePosition())
                ++this.VehicleB_stalltime;
              if (((Entity) this.VehicleC).get_FreezePosition())
                ++this.VehicleC_stalltime;
              if (((Entity) this.VehicleD).get_FreezePosition())
                ++this.VehicleD_stalltime;
              if (((Entity) this.VehicleE).get_FreezePosition())
                ++this.VehicleE_stalltime;
              if (((Entity) this.VehicleF).get_FreezePosition())
                ++this.VehicleF_stalltime;
            }
            if (!this.VehicleA.get_IsDriveable())
            {
              ((Entity) this.VehicleA).set_FreezePosition(true);
              this.VehicleA.set_Speed(0.0f);
            }
            if (!this.VehicleB.get_IsDriveable())
            {
              ((Entity) this.VehicleB).set_FreezePosition(true);
              this.VehicleB.set_Speed(0.0f);
            }
            if (!this.VehicleC.get_IsDriveable())
            {
              ((Entity) this.VehicleC).set_FreezePosition(true);
              this.VehicleC.set_Speed(0.0f);
            }
            if (!this.VehicleD.get_IsDriveable())
            {
              ((Entity) this.VehicleD).set_FreezePosition(true);
              this.VehicleD.set_Speed(0.0f);
            }
            if (!this.VehicleE.get_IsDriveable())
            {
              ((Entity) this.VehicleE).set_FreezePosition(true);
              this.VehicleE.set_Speed(0.0f);
            }
            if (!this.VehicleF.get_IsDriveable())
            {
              ((Entity) this.VehicleF).set_FreezePosition(true);
              this.VehicleF.set_Speed(0.0f);
            }
            this.DisplayHelpTextThisFrameNoSound("Time A " + (object) this.VehicleA_stalltime + "   || B " + (object) this.VehicleB_stalltime + "    || C " + (object) this.VehicleC_stalltime + "   || D " + (object) this.VehicleD_stalltime + "   || E " + (object) this.VehicleE_stalltime + "   || F " + (object) this.VehicleF_stalltime);
            if ((double) this.VehicleA_stalltime >= 120.0 && ((Entity) this.VehicleA).get_FreezePosition())
            {
              ((Entity) this.VehicleA).set_FreezePosition(false);
              this.VehicleA.set_IsDriveable(true);
              UI.Notify(this.GetHostName() + " : Vehicle A has been repaired");
            }
            if ((double) this.VehicleB_stalltime >= 140.0 && ((Entity) this.VehicleB).get_FreezePosition())
            {
              ((Entity) this.VehicleB).set_FreezePosition(false);
              this.VehicleB.set_IsDriveable(true);
              UI.Notify(this.GetHostName() + " : Vehicle B has been repaired");
            }
            if ((double) this.VehicleC_stalltime >= 160.0 && ((Entity) this.VehicleC).get_FreezePosition())
            {
              ((Entity) this.VehicleC).set_FreezePosition(false);
              this.VehicleC.set_IsDriveable(true);
              UI.Notify(this.GetHostName() + " : Vehicle C has been repaired");
            }
            if ((double) this.VehicleD_stalltime >= 180.0 && ((Entity) this.VehicleD).get_FreezePosition())
            {
              ((Entity) this.VehicleD).set_FreezePosition(false);
              this.VehicleD.set_IsDriveable(true);
              UI.Notify(this.GetHostName() + " : Vehicle D has been repaired");
            }
            if ((double) this.VehicleE_stalltime >= 200.0 && ((Entity) this.VehicleE).get_FreezePosition())
            {
              ((Entity) this.VehicleE).set_FreezePosition(false);
              this.VehicleE.set_IsDriveable(true);
              UI.Notify(this.GetHostName() + " : Vehicle E has been repaired");
            }
            if ((double) this.VehicleF_stalltime >= 220.0 && ((Entity) this.VehicleF).get_FreezePosition())
            {
              this.VehicleF.set_IsDriveable(true);
              UI.Notify(this.GetHostName() + " : Vehicle F has been repaired");
            }
            int L = 0;
            if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleA))
            {
              L = this.Alap;
              int acheck = this.ACheck;
              if (L >= 4)
              {
                int carStat = this.GetCarStat(0, L, acheck, 1);
                if (carStat == 1)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GamePassed("Inside Track", (int) this.RaceBet * this.MpValue);
                  }
                  this.Chips_Amount += (int) this.Bet * this.MpValue;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
                if (carStat == 0)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GameFail("Your Car was beaten!", "Inside Track");
                  }
                  this.Chips_Amount -= (int) this.Bet;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
              }
            }
            if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleB))
            {
              L = this.Blap;
              int bcheck = this.BCheck;
              if (L >= 4)
              {
                int carStat = this.GetCarStat(0, L, bcheck, 2);
                if (carStat == 1)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GamePassed("Inside Track", (int) this.RaceBet * this.MpValue);
                  }
                  this.Chips_Amount += (int) this.Bet * this.MpValue;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
                if (carStat == 0)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GameFail("Your Car was beaten!", "Inside Track");
                  }
                  this.Chips_Amount -= (int) this.Bet;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
              }
            }
            if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleC))
            {
              L = this.Clap;
              int ccheck = this.CCheck;
              if (L >= 4)
              {
                int carStat = this.GetCarStat(0, L, ccheck, 3);
                if (carStat == 1)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GamePassed("Inside Track", (int) this.RaceBet * this.MpValue);
                  }
                  this.Chips_Amount += (int) this.Bet * this.MpValue;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
                if (carStat == 0)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GameFail("Your Car was beaten!", "Inside Track");
                  }
                  this.Chips_Amount -= (int) this.Bet;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
              }
            }
            if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleD))
            {
              L = this.Dlap;
              int dcheck = this.DCheck;
              if (L >= 4)
              {
                int carStat = this.GetCarStat(0, L, dcheck, 4);
                if (carStat == 1)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GamePassed("Inside Track", (int) this.RaceBet * this.MpValue);
                  }
                  this.Chips_Amount += (int) this.Bet * this.MpValue;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
                if (carStat == 0)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GameFail("Your Car was beaten!", "Inside Track");
                  }
                  this.Chips_Amount -= (int) this.Bet;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
              }
            }
            if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleE))
            {
              L = this.Elap;
              int echeck = this.ECheck;
              if (L >= 4)
              {
                int carStat = this.GetCarStat(0, L, echeck, 5);
                if (carStat == 1)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GamePassed("Inside Track", (int) this.RaceBet * this.MpValue);
                  }
                  this.Chips_Amount += (int) this.Bet * this.MpValue;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
                if (carStat == 0)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GameFail("Your Car was beaten!", "Inside Track");
                  }
                  this.Chips_Amount -= (int) this.Bet;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
              }
            }
            if (Entity.op_Equality((Entity) this.SpectateCar, (Entity) this.VehicleF))
            {
              L = this.Flap;
              int fcheck = this.FCheck;
              if (L >= 4)
              {
                int carStat = this.GetCarStat(0, L, fcheck, 6);
                if (carStat == 1)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GamePassed("Inside Track", (int) this.RaceBet * this.MpValue);
                  }
                  this.Chips_Amount += (int) this.Bet * this.MpValue;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
                if (carStat == 0)
                {
                  for (int index = 0; index < 100; ++index)
                  {
                    Script.Wait(1);
                    this.GameFail("Your Car was beaten!", "Inside Track");
                  }
                  this.Chips_Amount -= (int) this.Bet;
                  this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                  this.Config.Save();
                  this.EndRace();
                  ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
                  this.IsInbettingRace = false;
                  ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
                  this.IsinInterior = true;
                }
              }
            }
            this.ShowRaceOptions(L);
            ((Entity) Game.get_Player().get_Character()).set_Position(vector3);
            this.RaceCam.set_Position(vector3);
            if (Game.IsControlJustPressed(2, (Control) 132) && L < 3)
              this.RaceBet -= 100f;
            if (Game.IsControlJustPressed(2, (Control) 21) && L < 3)
              this.RaceBet += 100f;
            if (Game.IsControlJustPressed(2, (Control) 44))
            {
              if (Camera.op_Inequality(this.RaceCam, (Camera) null))
              {
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                this.RaceCam.set_IsActive(false);
                this.RaceCam.Destroy();
              }
              this.IsInbettingRace = false;
              this.modMenuPool.CloseAllMenus();
              ((Entity) Game.get_Player().get_Character()).set_Position(this.RaceSTMarker);
              this.IsinInterior = true;
              this.StartR = false;
              this.inRace = false;
              if (Entity.op_Inequality((Entity) this.VehicleA, (Entity) null))
              {
                if (Entity.op_Inequality((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
                  ((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1)).Delete();
                ((Entity) this.VehicleA).Delete();
              }
              if (Entity.op_Inequality((Entity) this.VehicleB, (Entity) null))
              {
                if (Entity.op_Inequality((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
                  ((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1)).Delete();
                ((Entity) this.VehicleB).Delete();
              }
              if (Entity.op_Inequality((Entity) this.VehicleC, (Entity) null))
              {
                if (Entity.op_Inequality((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
                  ((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1)).Delete();
                ((Entity) this.VehicleC).Delete();
              }
              if (Entity.op_Inequality((Entity) this.VehicleD, (Entity) null))
              {
                if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
                  ((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1)).Delete();
                ((Entity) this.VehicleD).Delete();
              }
              if (Entity.op_Inequality((Entity) this.VehicleE, (Entity) null))
              {
                if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
                  ((Entity) this.VehicleE.GetPedOnSeat((VehicleSeat) -1)).Delete();
                ((Entity) this.VehicleE).Delete();
              }
              if (Entity.op_Inequality((Entity) this.VehicleF, (Entity) null))
              {
                if (Entity.op_Inequality((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
                  ((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1)).Delete();
                ((Entity) this.VehicleF).Delete();
              }
              this.StartedRace = false;
              this.FinishedRace = true;
              this.CheckpointRace = false;
              this.Race = 0;
              this.CarsFinished = 0;
              using (List<Blip>.Enumerator enumerator = this.CheckPointBlips.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  Blip current = enumerator.Current;
                  if (Blip.op_Inequality(current, (Blip) null))
                    current.Remove();
                }
              }
              this.Race = 0;
            }
          }
        }
      }
      if (this.CheckpointRace && this.Race == 1)
      {
        if (!this.StartedRace && this.StartR)
        {
          if (Blip.op_Inequality(this.RaceBlip, (Blip) null))
            this.RaceBlip.Remove();
          if (this.StartR)
          {
            this.StartedRace = true;
            this.FinishedRace = false;
            UI.Notify("~G~ Started Race");
          }
        }
        if (this.inRace)
        {
          if (!this.IsLeading)
            ;
          if (this.StartedRace)
          {
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.VehicleA).get_Position()) >= 60.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.VehicleA).get_Position()) >= 60.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.VehicleB).get_Position()) >= 60.0)
              ;
            using (List<Vector3>.Enumerator enumerator = this.CheckpointPos.GetEnumerator())
            {
              while (enumerator.MoveNext())
                World.DrawMarker((MarkerType) 1, enumerator.Current, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(6f, 6f, 2f), this.MarkerColor);
            }
            Random random = new Random();
            float num1 = 500f;
            Function.Call((Hash) 6673073222263625992L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleA.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 4632614851719509830L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleA.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 6673073222263625992L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleB.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 4632614851719509830L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleB.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 6673073222263625992L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleC.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 4632614851719509830L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleC.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 6673073222263625992L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleD.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 4632614851719509830L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleD.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 6673073222263625992L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleE.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 4632614851719509830L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleE.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 6673073222263625992L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleF.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Function.Call((Hash) 4632614851719509830L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.VehicleF.GetPedOnSeat((VehicleSeat) -1)),
              InputArgument.op_Implicit(num1)
            });
            Vehicle vehicleA1 = this.VehicleA;
            Vehicle vehicleA2 = this.VehicleA;
            if (vehicleA2.get_ClassType() == 7)
            {
              if ((double) vehicleA2.get_Speed() * 4.0 < 10.0)
              {
                this.Multiplyer = 1;
                float num2 = 1f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleA2.get_Speed() * 4.0 > 10.0 && (double) vehicleA2.get_Speed() * 4.0 < 25.0)
              {
                this.Multiplyer = 3;
                float num2 = 2.5f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleA2.get_Speed() * 4.0 > 25.0 && (double) vehicleA2.get_Speed() * 4.0 < 50.0)
              {
                this.Multiplyer = 7;
                float num2 = 5f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleA2.get_Speed() * 4.0 > 50.0 && (double) vehicleA2.get_Speed() * 4.0 < 75.0)
              {
                this.Multiplyer = 10;
                float num2 = 4.5f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleA2.get_Speed() * 4.0 > 75.0 && (double) vehicleA2.get_Speed() * 4.0 < 125.0)
              {
                this.Multiplyer = 17;
                float num2 = 7f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleA2.get_Speed() * 4.0 > 125.0 && (double) vehicleA2.get_Speed() * 4.0 < 150.0)
              {
                this.Multiplyer = 40;
                float num2 = 9f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleA2.get_Speed() * 4.0 > 150.0 && (double) vehicleA2.get_Speed() * 4.0 < 200.0)
              {
                this.Multiplyer = 75;
                float num2 = 15f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleA2.get_Speed() * 4.0 > 200.0 && (double) vehicleA2.get_Speed() * 4.0 < 250.0)
              {
                this.Multiplyer = 100;
                float num2 = 20f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleA2.get_Speed() * 4.0 > 250.0)
              {
                this.Multiplyer = 125;
                float num2 = 25f;
                vehicleA2.set_EngineTorqueMultiplier(num2);
                vehicleA2.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
            }
            if ((double) World.GetDistance(((Entity) this.VehicleA).get_Position(), this.CheckpointPos[0]) < 20.0 && this.ACheck == 0)
            {
              this.VehicleA.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleA, this.CheckpointPos[1], 20f, (float) this.VehicleA_max, 1074528293);
              this.ACheck = 1;
              if (!this.StopCounter)
                this.VehicleA_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleA).get_Position(), this.CheckpointPos[1]) < 20.0 && this.ACheck == 1)
            {
              this.VehicleA.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleA, this.CheckpointPos[2], 20f, (float) this.VehicleA_max, 1074528293);
              this.ACheck = 2;
              if (!this.StopCounter)
                this.VehicleA_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleA).get_Position(), this.CheckpointPos[2]) < 20.0 && this.ACheck == 2)
            {
              this.VehicleA.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleA, this.CheckpointPos[0], 20f, (float) this.VehicleA_max, 1074528293);
              this.ACheck = 0;
              if (!this.StopCounter)
                this.VehicleA_stalltime += 100f;
              ++this.Alap;
            }
            Vehicle vehicleB = this.VehicleB;
            if (vehicleB.get_ClassType() == 7)
            {
              if ((double) vehicleB.get_Speed() * 4.0 < 10.0)
              {
                this.Multiplyer = 1;
                float num2 = 1f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleB.get_Speed() * 4.0 > 10.0 && (double) vehicleB.get_Speed() * 4.0 < 25.0)
              {
                this.Multiplyer = 3;
                float num2 = 2.5f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleB.get_Speed() * 4.0 > 25.0 && (double) vehicleB.get_Speed() * 4.0 < 50.0)
              {
                this.Multiplyer = 7;
                float num2 = 5f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleB.get_Speed() * 4.0 > 50.0 && (double) vehicleB.get_Speed() * 4.0 < 75.0)
              {
                this.Multiplyer = 10;
                float num2 = 4.5f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleB.get_Speed() * 4.0 > 75.0 && (double) vehicleB.get_Speed() * 4.0 < 125.0)
              {
                this.Multiplyer = 17;
                float num2 = 7f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleB.get_Speed() * 4.0 > 125.0 && (double) vehicleB.get_Speed() * 4.0 < 150.0)
              {
                this.Multiplyer = 40;
                float num2 = 9f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleB.get_Speed() * 4.0 > 150.0 && (double) vehicleB.get_Speed() * 4.0 < 200.0)
              {
                this.Multiplyer = 75;
                float num2 = 15f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleB.get_Speed() * 4.0 > 200.0 && (double) vehicleB.get_Speed() * 4.0 < 250.0)
              {
                this.Multiplyer = 100;
                float num2 = 20f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleB.get_Speed() * 4.0 > 250.0)
              {
                this.Multiplyer = 125;
                float num2 = 25f;
                vehicleB.set_EngineTorqueMultiplier(num2);
                vehicleB.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
            }
            if ((double) World.GetDistance(((Entity) this.VehicleB).get_Position(), this.CheckpointPos[0]) < 20.0 && this.BCheck == 0)
            {
              this.VehicleB.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleB, this.CheckpointPos[1], 20f, (float) this.VehicleB_max, 1074528293);
              this.BCheck = 1;
              if (!this.StopCounter)
                this.VehicleB_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleB).get_Position(), this.CheckpointPos[1]) < 20.0 && this.BCheck == 1)
            {
              this.VehicleB.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleB, this.CheckpointPos[2], 20f, (float) this.VehicleB_max, 1074528293);
              this.BCheck = 2;
              if (!this.StopCounter)
                this.VehicleB_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleB).get_Position(), this.CheckpointPos[2]) < 20.0 && this.BCheck == 2)
            {
              this.VehicleB.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleB, this.CheckpointPos[0], 20f, (float) this.VehicleB_max, 1074528293);
              this.BCheck = 0;
              this.VehicleB_stalltime += 100f;
              ++this.Blap;
              if (this.Blap == 4)
                this.StopCounter = true;
            }
            Vehicle vehicleC = this.VehicleC;
            if (vehicleC.get_ClassType() == 7)
            {
              if ((double) vehicleC.get_Speed() * 4.0 < 10.0)
              {
                this.Multiplyer = 1;
                float num2 = 1f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleC.get_Speed() * 4.0 > 10.0 && (double) vehicleC.get_Speed() * 4.0 < 25.0)
              {
                this.Multiplyer = 3;
                float num2 = 2.5f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleC.get_Speed() * 4.0 > 25.0 && (double) vehicleC.get_Speed() * 4.0 < 50.0)
              {
                this.Multiplyer = 7;
                float num2 = 5f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleC.get_Speed() * 4.0 > 50.0 && (double) vehicleC.get_Speed() * 4.0 < 75.0)
              {
                this.Multiplyer = 10;
                float num2 = 4.5f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleC.get_Speed() * 4.0 > 75.0 && (double) vehicleC.get_Speed() * 4.0 < 125.0)
              {
                this.Multiplyer = 17;
                float num2 = 7f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleC.get_Speed() * 4.0 > 125.0 && (double) vehicleC.get_Speed() * 4.0 < 150.0)
              {
                this.Multiplyer = 40;
                float num2 = 9f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleC.get_Speed() * 4.0 > 150.0 && (double) vehicleC.get_Speed() * 4.0 < 200.0)
              {
                this.Multiplyer = 75;
                float num2 = 15f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleC.get_Speed() * 4.0 > 200.0 && (double) vehicleC.get_Speed() * 4.0 < 250.0)
              {
                this.Multiplyer = 100;
                float num2 = 20f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleC.get_Speed() * 4.0 > 250.0)
              {
                this.Multiplyer = 125;
                float num2 = 25f;
                vehicleC.set_EngineTorqueMultiplier(num2);
                vehicleC.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
            }
            if ((double) World.GetDistance(((Entity) this.VehicleC).get_Position(), this.CheckpointPos[0]) < 20.0 && this.CCheck == 0)
            {
              this.VehicleC.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleC, this.CheckpointPos[1], 20f, (float) this.VehicleC_max, 1074528293);
              this.CCheck = 1;
              if (!this.StopCounter)
                this.VehicleC_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleC).get_Position(), this.CheckpointPos[1]) < 20.0 && this.CCheck == 1)
            {
              this.VehicleC.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleC, this.CheckpointPos[2], 20f, (float) this.VehicleC_max, 1074528293);
              this.CCheck = 2;
              if (!this.StopCounter)
                this.VehicleC_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleC).get_Position(), this.CheckpointPos[2]) < 20.0 && this.CCheck == 2)
            {
              this.VehicleC.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleC, this.CheckpointPos[0], 20f, (float) this.VehicleC_max, 1074528293);
              if (!this.StopCounter)
                this.VehicleC_stalltime += 100f;
              this.CCheck = 0;
              ++this.Clap;
              if (this.Clap == 4)
                this.StopCounter = true;
            }
            Vehicle vehicleD = this.VehicleD;
            if (vehicleD.get_ClassType() == 7)
            {
              if ((double) vehicleD.get_Speed() * 4.0 < 10.0)
              {
                this.Multiplyer = 1;
                float num2 = 1f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleD.get_Speed() * 4.0 > 10.0 && (double) vehicleD.get_Speed() * 4.0 < 25.0)
              {
                this.Multiplyer = 3;
                float num2 = 2.5f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleD.get_Speed() * 4.0 > 25.0 && (double) vehicleD.get_Speed() * 4.0 < 50.0)
              {
                this.Multiplyer = 7;
                float num2 = 5f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleD.get_Speed() * 4.0 > 50.0 && (double) vehicleD.get_Speed() * 4.0 < 75.0)
              {
                this.Multiplyer = 10;
                float num2 = 4.5f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleD.get_Speed() * 4.0 > 75.0 && (double) vehicleD.get_Speed() * 4.0 < 125.0)
              {
                this.Multiplyer = 17;
                float num2 = 7f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleD.get_Speed() * 4.0 > 125.0 && (double) vehicleD.get_Speed() * 4.0 < 150.0)
              {
                this.Multiplyer = 40;
                float num2 = 9f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleD.get_Speed() * 4.0 > 150.0 && (double) vehicleD.get_Speed() * 4.0 < 200.0)
              {
                this.Multiplyer = 75;
                float num2 = 15f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleD.get_Speed() * 4.0 > 200.0 && (double) vehicleD.get_Speed() * 4.0 < 250.0)
              {
                this.Multiplyer = 100;
                float num2 = 20f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleD.get_Speed() * 4.0 > 250.0)
              {
                this.Multiplyer = 125;
                float num2 = 25f;
                vehicleD.set_EngineTorqueMultiplier(num2);
                vehicleD.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
            }
            if ((double) World.GetDistance(((Entity) this.VehicleD).get_Position(), this.CheckpointPos[0]) < 20.0 && this.DCheck == 0)
            {
              this.VehicleD.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleD, this.CheckpointPos[1], 20f, (float) this.VehicleD_max, 1074528293);
              this.DCheck = 1;
              if (!this.StopCounter)
                this.VehicleD_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleD).get_Position(), this.CheckpointPos[1]) < 20.0 && this.DCheck == 1)
            {
              this.VehicleD.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleD, this.CheckpointPos[2], 20f, (float) this.VehicleD_max, 1074528293);
              this.DCheck = 2;
              if (!this.StopCounter)
                this.VehicleD_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleD).get_Position(), this.CheckpointPos[2]) < 20.0 && this.DCheck == 2)
            {
              this.VehicleD.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleD, this.CheckpointPos[0], 20f, (float) this.VehicleD_max, 1074528293);
              this.DCheck = 0;
              if (!this.StopCounter)
                this.VehicleD_stalltime += 100f;
              ++this.Dlap;
              if (this.Dlap == 4)
                this.StopCounter = true;
            }
            Vehicle vehicleE = this.VehicleE;
            if (vehicleE.get_ClassType() == 7)
            {
              if ((double) vehicleE.get_Speed() * 4.0 < 10.0)
              {
                this.Multiplyer = 1;
                float num2 = 1f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleE.get_Speed() * 4.0 > 10.0 && (double) vehicleE.get_Speed() * 4.0 < 25.0)
              {
                this.Multiplyer = 3;
                float num2 = 2.5f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleE.get_Speed() * 4.0 > 25.0 && (double) vehicleE.get_Speed() * 4.0 < 50.0)
              {
                this.Multiplyer = 7;
                float num2 = 5f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleE.get_Speed() * 4.0 > 50.0 && (double) vehicleE.get_Speed() * 4.0 < 75.0)
              {
                this.Multiplyer = 10;
                float num2 = 4.5f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleE.get_Speed() * 4.0 > 75.0 && (double) vehicleE.get_Speed() * 4.0 < 125.0)
              {
                this.Multiplyer = 17;
                float num2 = 7f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleE.get_Speed() * 4.0 > 125.0 && (double) vehicleE.get_Speed() * 4.0 < 150.0)
              {
                this.Multiplyer = 40;
                float num2 = 9f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleE.get_Speed() * 4.0 > 150.0 && (double) vehicleE.get_Speed() * 4.0 < 200.0)
              {
                this.Multiplyer = 75;
                float num2 = 15f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleE.get_Speed() * 4.0 > 200.0 && (double) vehicleE.get_Speed() * 4.0 < 250.0)
              {
                this.Multiplyer = 100;
                float num2 = 20f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleE.get_Speed() * 4.0 > 250.0)
              {
                this.Multiplyer = 125;
                float num2 = 25f;
                vehicleE.set_EngineTorqueMultiplier(num2);
                vehicleE.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
            }
            if ((double) World.GetDistance(((Entity) this.VehicleE).get_Position(), this.CheckpointPos[0]) < 20.0 && this.ECheck == 0)
            {
              this.VehicleE.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleE, this.CheckpointPos[1], 20f, (float) this.VehicleE_max, 1074528293);
              this.ECheck = 1;
              if (!this.StopCounter)
                this.VehicleE_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleE).get_Position(), this.CheckpointPos[1]) < 20.0 && this.ECheck == 1)
            {
              this.VehicleE.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleE, this.CheckpointPos[2], 20f, (float) this.VehicleE_max, 1074528293);
              this.ECheck = 2;
              if (!this.StopCounter)
                this.VehicleE_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleE).get_Position(), this.CheckpointPos[2]) < 20.0 && this.ECheck == 2)
            {
              this.VehicleE.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleE, this.CheckpointPos[0], 20f, (float) this.VehicleE_max, 1074528293);
              this.ECheck = 0;
              if (!this.StopCounter)
                this.VehicleE_stalltime += 100f;
              ++this.Elap;
              if (this.Elap == 4)
                this.StopCounter = true;
            }
            Vehicle vehicleF = this.VehicleF;
            if (vehicleF.get_ClassType() == 7)
            {
              if ((double) vehicleF.get_Speed() * 4.0 < 10.0)
              {
                this.Multiplyer = 1;
                float num2 = 1f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleF.get_Speed() * 4.0 > 10.0 && (double) vehicleF.get_Speed() * 4.0 < 25.0)
              {
                this.Multiplyer = 3;
                float num2 = 2.5f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleF.get_Speed() * 4.0 > 25.0 && (double) vehicleF.get_Speed() * 4.0 < 50.0)
              {
                this.Multiplyer = 7;
                float num2 = 5f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleF.get_Speed() * 4.0 > 50.0 && (double) vehicleF.get_Speed() * 4.0 < 75.0)
              {
                this.Multiplyer = 10;
                float num2 = 4.5f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleF.get_Speed() * 4.0 > 75.0 && (double) vehicleF.get_Speed() * 4.0 < 125.0)
              {
                this.Multiplyer = 17;
                float num2 = 7f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleF.get_Speed() * 4.0 > 125.0 && (double) vehicleF.get_Speed() * 4.0 < 150.0)
              {
                this.Multiplyer = 40;
                float num2 = 9f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleF.get_Speed() * 4.0 > 150.0 && (double) vehicleF.get_Speed() * 4.0 < 200.0)
              {
                this.Multiplyer = 75;
                float num2 = 15f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleF.get_Speed() * 4.0 > 200.0 && (double) vehicleF.get_Speed() * 4.0 < 250.0)
              {
                this.Multiplyer = 100;
                float num2 = 20f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
              if ((double) vehicleF.get_Speed() * 4.0 > 250.0)
              {
                this.Multiplyer = 125;
                float num2 = 25f;
                vehicleF.set_EngineTorqueMultiplier(num2);
                vehicleF.set_EnginePowerMultiplier((float) this.Multiplyer);
              }
            }
            if ((double) World.GetDistance(((Entity) this.VehicleF).get_Position(), this.CheckpointPos[0]) < 20.0 && this.FCheck == 0)
            {
              this.VehicleF.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleF, this.CheckpointPos[1], 20f, (float) this.VehicleF_max, 1074528293);
              this.FCheck = 1;
              if (!this.StopCounter)
                this.VehicleF_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleF).get_Position(), this.CheckpointPos[1]) < 20.0 && this.FCheck == 1)
            {
              this.VehicleF.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleF, this.CheckpointPos[2], 20f, (float) this.VehicleF_max, 1074528293);
              this.FCheck = 2;
              if (!this.StopCounter)
                this.VehicleF_stalltime += 25f;
            }
            if ((double) World.GetDistance(((Entity) this.VehicleF).get_Position(), this.CheckpointPos[2]) < 20.0 && this.FCheck == 2)
            {
              this.VehicleF.GetPedOnSeat((VehicleSeat) -1).get_Task().DriveTo(this.VehicleF, this.CheckpointPos[0], 20f, (float) this.VehicleF_max, 1074528293);
              this.FCheck = 0;
              if (!this.StopCounter)
                this.VehicleF_stalltime += 100f;
              ++this.Flap;
              if (this.Flap == 4)
                this.StopCounter = true;
            }
          }
        }
      }
      if (this.firstTime)
      {
        UI.Notify("~" + this.Uicolour + "~ DC&R ~w~ : Loading in interior Peds, please be patient");
        this.firstTime = false;
        try
        {
          this.WheelProp = World.CreateProp(this.SpawnProp("vw_prop_vw_luckywheel_02a"), new Vector3((float) this.LuckyWheel.X, (float) (this.LuckyWheel.Y + 1.16999995708466), (float) (this.LuckyWheel.Z + 0.119999997317791)), true, false);
          ((Entity) this.WheelProp).set_FreezePosition(true);
          ((Entity) this.WheelProp).set_Rotation(new Vector3(0.0f, -10f, 0.0f));
          this.WheelProp2 = World.CreateProp(this.SpawnProp("vw_prop_vw_luckywheel_02a"), new Vector3(1110.771f, 223.5515f, -50f), true, false);
          ((Entity) this.WheelProp2).set_Rotation(new Vector3(0.0f, -90f, 0.0f));
          ((Entity) this.WheelProp2).set_FreezePosition(true);
          ((Entity) this.WheelProp2).set_Rotation(new Vector3(0.0f, -10f, 0.0f));
          ((Entity) this.WheelProp2).set_IsVisible(false);
          ((Entity) this.WheelProp2).set_HasCollision(false);
          Vector3 thraxPos = this.ThraxPos;
          ((Vector3) ref thraxPos).\u002Ector((float) thraxPos.X, (float) thraxPos.Y, (float) (thraxPos.Z - 5.09999990463257));
          this.BasePlate = World.CreateProp(this.SpawnProp("xs_prop_arena_flipper_small_01a_sf"), thraxPos, true, false);
          ((Entity) this.BasePlate).set_Rotation(new Vector3(0.0f, 0.0f, 0.0f));
          ((Entity) this.BasePlate).set_FreezePosition(true);
          ((Entity) this.BasePlate).set_IsVisible(false);
          ((Entity) this.BasePlate).set_HasCollision(true);
        }
        catch (Exception ex)
        {
          UI.Notify("~r~Error 3~");
        }
        try
        {
          this.WheelWinMarker = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.18f, -0.3f, 1.15f)), true, false);
          Prop prop1 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop1).AttachTo((Entity) this.WheelProp, 0, new Vector3(0.0f, -0.3f, 1.15f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop1);
          Prop prop2 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop2).AttachTo((Entity) this.WheelProp, 0, new Vector3(0.4f, -0.3f, 1.1f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop2);
          Prop prop3 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop3).AttachTo((Entity) this.WheelProp, 0, new Vector3(0.7f, -0.3f, 0.9f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop3);
          Prop prop4 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop4).AttachTo((Entity) this.WheelProp, 0, new Vector3(0.95f, -0.3f, 0.6f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop4);
          Prop prop5 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop5).AttachTo((Entity) this.WheelProp, 0, new Vector3(1.1f, -0.3f, 0.3f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop5);
          Prop prop6 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop6).AttachTo((Entity) this.WheelProp, 0, new Vector3(1.15f, -0.3f, 0.0f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop6);
          Prop prop7 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop7).AttachTo((Entity) this.WheelProp, 0, new Vector3(1.1f, -0.3f, -0.3f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop7);
          Prop prop8 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop8).AttachTo((Entity) this.WheelProp, 0, new Vector3(0.95f, -0.3f, -0.6f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop8);
          Prop prop9 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop9).AttachTo((Entity) this.WheelProp, 0, new Vector3(0.7f, -0.3f, -0.9f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop9);
          Prop prop10 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop10).AttachTo((Entity) this.WheelProp, 0, new Vector3(0.35f, -0.3f, -1.1f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop10);
          Prop prop11 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop11).AttachTo((Entity) this.WheelProp, 0, new Vector3(0.0f, -0.3f, -1.15f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop11);
          Prop prop12 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop12).AttachTo((Entity) this.WheelProp, 0, new Vector3(-0.35f, -0.3f, -1.1f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop12);
          Prop prop13 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop13).AttachTo((Entity) this.WheelProp, 0, new Vector3(-0.7f, -0.3f, 0.9f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop13);
          Prop prop14 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop14).AttachTo((Entity) this.WheelProp, 0, new Vector3(-0.95f, -0.3f, 0.6f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop14);
          Prop prop15 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop15).AttachTo((Entity) this.WheelProp, 0, new Vector3(-1.1f, -0.3f, 0.3f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop15);
          Prop prop16 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop16).AttachTo((Entity) this.WheelProp, 0, new Vector3(-1.15f, -0.3f, 0.0f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop16);
          Prop prop17 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop17).AttachTo((Entity) this.WheelProp, 0, new Vector3(-1.1f, -0.3f, -0.3f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop17);
          Prop prop18 = World.CreateProp(Model.op_Implicit("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop18).AttachTo((Entity) this.WheelProp, 0, new Vector3(-0.95f, -0.3f, -0.6f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop18);
          Prop prop19 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop19).AttachTo((Entity) this.WheelProp, 0, new Vector3(-0.7f, -0.3f, -0.9f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop19);
          Prop prop20 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop20).AttachTo((Entity) this.WheelProp, 0, new Vector3(-0.4f, -0.3f, -1.1f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop20);
          Prop prop21 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), ((Entity) this.WheelProp).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), true, false);
          ((Entity) prop21).AttachTo((Entity) this.WheelProp, 0, new Vector3(-0.4f, -0.3f, 1.1f), new Vector3(90f, 0.0f, 0.0f));
          this.WheelMarkers.Add(prop21);
          using (List<Prop>.Enumerator enumerator = this.WheelMarkers.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Prop current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).set_IsVisible(false);
            }
          }
        }
        catch (Exception ex)
        {
          UI.Notify("~r~Prize Wheel Markers failed to spawn~");
        }
        try
        {
          if (this.MainPeds)
          {
            this.Vendor1 = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(967.0132f, 29.35624f, 115f), 56f);
            this.Vendor2 = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(969.15f, 33.19205f, 115f), 56f);
            this.SetPedOutfit(this.Vendor1);
            this.PlayDealerAnim(this.Vendor1);
            this.SetPedOutfit(this.Vendor2);
            this.PlayDealerAnim(this.Vendor2);
            this.MainPed.Add(this.Vendor1);
            this.MainPed.Add(this.Vendor2);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1118.256f, 219.4535f, -49.5f), 103f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            Vector3 position1 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position1.X, (float) position1.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1101.027f, 195.2306f, -49.5f), -48f);
            this.SetPedOutfit(this.ped);
            Vector3 position2 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position2.X, (float) position2.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.MainPed.Add(this.ped);
            this.ped = World.CreatePed(this.RequestModel("ig_tomcasino"), new Vector3(1087.711f, 221.1435f, -49.5f), 177f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1145.633f, 261.8369f, -49.5f), -136f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            Vector3 position3 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position3.X, (float) position3.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1151.171f, 267.3671f, -49.5f), -136f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            Vector3 position4 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position4.X, (float) position4.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1149.443f, 269.1333f, -49.5f), 39f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            Vector3 position5 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position5.X, (float) position5.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1144.041f, 263.6831f, -49.5f), 48f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            Vector3 position6 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position6.X, (float) position6.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1149.349f, 252.3492f, -49.5f), 137f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            Vector3 position7 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position7.X, (float) position7.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1143.853f, 246.481f, -49.5f), -38f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            Vector3 position8 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position8.X, (float) position8.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1110.818f, 209.2807f, -49.5f), 34f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.ped.get_Task().PlayAnimation("anim@amb@casino@mini@drinking@bar@drink_v2@heels@idle_a", "idle_a_bartender", 8f, -1, true, -1f);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1113.457f, 208.9917f, -49.5f), -63f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.ped.get_Task().PlayAnimation("anim@amb@casino@mini@drinking@bar@drink_v2@heels@idle_a", "idle_a_bartender", 8f, -1, true, -1f);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1112.64f, 206.597f, -49.5f), -178f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.ped.get_Task().PlayAnimation("anim@amb@casino@mini@drinking@bar@drink_v2@heels@idle_a", "idle_a_bartender", 8f, -1, true, -1f);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1148.878f, 264.5572f, -49.5f), 44f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1147.896f, 246.8535f, -49.5f), -51f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1134.328f, 267.3924f, -49.5f), 134f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(958.8818f, 71.53243f, 111f), 154f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.ped.get_Task().PlayAnimation("anim@amb@casino@mini@drinking@bar@drink_v2@heels@idle_a", "idle_a_bartender", 8f, -1, true, -1f);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1128.806f, 261.6401f, -50f), -42f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel((PedHash) -597926235), new Vector3(1113.545f, 249.2349f, -46f), -179f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.ped.get_Task().PlayAnimation("move_drunk_m", "idle", 1900f, -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreatePed(this.RequestModel((PedHash) 2089096292), new Vector3(1113.671f, 247.5057f, -46f), -32f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.ped.get_Task().StartScenario("WORLD_HUMAN_MOBILE_FILM_SHOCKING", ((Entity) this.ped).get_Position());
            this.SetPedOutfit(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1131.212f, 268.1662f, -50f), 111f);
            this.MainPed.Add(this.ped);
            Vector3 position9 = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3((float) position9.X, (float) position9.Y, -52f));
            this.PlayDealerAnim(this.ped);
            this.ped = World.CreatePed(this.RequestModel("s_f_y_casino_01"), new Vector3(1128.704f, 211f, -49f), -43f);
            this.SetPedOutfit(this.ped);
            this.MainPed.Add(this.ped);
            this.SetPedOutfit(this.ped);
            this.ped = World.CreatePed(Model.op_Implicit("s_f_y_casino_01"), new Vector3(945.3591f, 13.48792f, 115f), 52f);
            this.ped.get_Task().PlayAnimation("anim@amb@casino@mini@drinking@bar@drink_v2@heels@idle_a", "idle_a_bartender", 8f, -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreatePed(this.RequestModel("csb_agatha"), new Vector3(1114.801f, 253.6271f, -46.4f), -90f);
            this.ped.set_AlwaysKeepTask(true);
            this.MainPed.Add(this.ped);
            this.ped.get_Task().PlayAnimation("anim@amb@office@pa@female@", "pa_base", 8f, -1, true, -1f);
            this.ped = World.CreateRandomPed(new Vector3(1134.131f, 278.7511f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1134.131f, 278.7511f, -52.1f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, -90f));
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().PlayAnimation("missfam5_blackout", "vomit", 128f, -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1135.075f, 280.4876f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1134.134f, 280.4636f, -52.1f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, 90f));
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().PlayAnimation("switch@trevor@on_toilet", "trev_on_toilet_loop", 8f, -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1134.012f, 282.1808f, -52.1f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, 90f));
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().PlayAnimation("switch@trevor@puking_into_fountain", "trev_fountain_puke_loop", 128f, -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1133.018f, 276.7346f, -52f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, -90f));
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().PlayAnimation("switch@michael@wash_face", "loop_michael", 128f, -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50.5f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1105.535f, 217.0142f, -49.9f));
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, 62f));
            this.ped.get_Task().StartScenario("WORLD_HUMAN_PAPARAZZI", ((Entity) this.ped).get_Position());
            this.MiscPed.Add(this.ped);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, 62f));
            this.ped.get_Task().StartScenario("WORLD_HUMAN_TOURIST_MOBILE", ((Entity) this.ped).get_Position());
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50.5f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1104.666f, 215.5959f, -49.9f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Heading(38f);
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().StartScenario("WORLD_HUMAN_PAPARAZZI", ((Entity) this.ped).get_Position());
            this.MiscPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -49.8f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1106.087f, 218.7728f, -49.9f));
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, 82f));
            this.ped.get_Task().StartScenario("WORLD_HUMAN_PAPARAZZI", ((Entity) this.ped).get_Position());
            this.MiscPed.Add(this.ped);
            ((Entity) this.ped).set_Heading(82f);
            this.ped.get_Task().StartScenario("WORLD_HUMAN_TOURIST_MOBILE", ((Entity) this.ped).get_Position());
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1102.207f, 200.4515f, -50.4f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Heading(136f);
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().StartScenario("WORLD_HUMAN_TOURIST_MOBILE", ((Entity) this.ped).get_Position());
            this.MiscPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1103.912f, 197.4887f, -50.4f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Heading(-81f);
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().StartScenario("WORLD_HUMAN_AA_COFFEE", ((Entity) this.ped).get_Position());
            this.MiscPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1096.842f, 208.2964f, -50f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Heading(75f);
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().StartScenario("WORLD_HUMAN_AA_COFFEE", ((Entity) this.ped).get_Position());
            this.MiscPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1094.77f, 208.3848f, -50f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, -90f));
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().StartScenario("WORLD_HUMAN_HANG_OUT_STREET", ((Entity) this.ped).get_Position());
            this.MiscPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1096.422f, 209.5439f, -50f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Heading(146f);
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().StartScenario("WORLD_HUMAN_HANG_OUT_STREET", ((Entity) this.ped).get_Position());
            this.MiscPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1134.012f, 282.1808f, -50f));
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1106.37f, 212.0176f, -50.3f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, 146f));
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().PlayAnimation("amb@world_human_sunbathe@female@back@base", "base", 8f, -1, true, -1f);
            this.MiscPed.Add(this.ped);
            this.ped = World.CreatePed(Model.op_Implicit((PedHash) -1286380898), new Vector3(1134.012f, 282.1808f, -51f), 1f);
            ((Entity) this.ped).set_Position(this.MarkerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(new Vector3(1106.548f, 211.8759f, -50.3f));
            ((Entity) this.ped).set_FreezePosition(true);
            ((Entity) this.ped).set_Rotation(new Vector3(0.0f, 0.0f, 122f));
            this.ped.set_AlwaysKeepTask(true);
            this.ped.get_Task().PlayAnimation("missheistfbi3b_ig8_2", "cpr_loop_paramedic", 8f, -1, true, -1f);
            this.MiscPed.Add(this.ped);
            using (List<Ped>.Enumerator enumerator = this.MiscPed.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Ped current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                {
                  Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0)
                  });
                  Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(17),
                    InputArgument.op_Implicit(1)
                  });
                  Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(1)
                  });
                  Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0)
                  });
                  Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(17),
                    InputArgument.op_Implicit(1)
                  });
                  current.set_RelationshipGroup(1);
                  current.set_AlwaysKeepTask(true);
                }
              }
            }
          }
          if (this.BarPeds)
          {
            Random random = new Random();
            Vector3 markerEnter = this.MarkerEnter;
            Vector3 position;
            ((Vector3) ref position).\u002Ector(0.0f, 0.0f, 0.0f);
            this.ped = World.CreateRandomPed(new Vector3(1111.493f, 211.5376f, -51.5f));
            ((Entity) this.ped).set_Heading(-174f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1110.145f, 210.9409f, -51.5f));
            ((Entity) this.ped).set_Heading(-147f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1109.086f, 209.9584f, -51.5f));
            ((Entity) this.ped).set_Heading(-122f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1108.59f, 206.8573f, -51.5f));
            ((Entity) this.ped).set_Heading(-73f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1109.433f, 205.567f, -51.5f));
            ((Entity) this.ped).set_Heading(-38f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1110.84f, 204.7336f, -51.5f));
            ((Entity) this.ped).set_Heading(-28f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1112.326f, 204.5824f, -51.5f));
            ((Entity) this.ped).set_Heading(-3f);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1114.798f, 206.2514f, -51.5f));
            ((Entity) this.ped).set_Heading(45f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
            this.ped = World.CreateRandomPed(new Vector3(1115.477f, 20.6416f, -51.5f));
            ((Entity) this.ped).set_Heading(45f);
            ((Entity) this.ped).set_FreezePosition(true);
            this.ped.set_AlwaysKeepTask(true);
            ((Entity) this.ped).set_IsPersistent(true);
            position = ((Entity) this.ped).get_Position();
            Script.Wait(1);
            ((Entity) this.ped).set_Position(markerEnter);
            Script.Wait(1);
            ((Entity) this.ped).set_Position(position);
            Script.Wait(1);
            this.ped.get_Task().PlayAnimation("anim@special_peds@casino@bar@ped_male@sit_withdrink@01a@base", "base", (float) random.Next(162, 1000), -1, true, -1f);
            this.MainPed.Add(this.ped);
          }
          using (List<Ped>.Enumerator enumerator = this.MainPed.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Ped current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
              {
                Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(17),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(17),
                  InputArgument.op_Implicit(1)
                });
                current.set_RelationshipGroup(1);
                current.set_AlwaysKeepTask(true);
              }
            }
          }
        }
        catch (Exception ex)
        {
          UI.Notify("~r~ Error ");
        }
        try
        {
        }
        catch (Exception ex)
        {
          UI.Notify("~r~ Error 4");
        }
        try
        {
          try
          {
            foreach (Prop nearbyProp in World.GetNearbyProps(this.MarkerExit, 3000f, this.RequestModel("vw_prop_casino_3cardpoker_01")))
            {
              if (Entity.op_Inequality((Entity) nearbyProp, (Entity) null))
                this.Tables.Add(nearbyProp);
            }
            foreach (Prop nearbyProp in World.GetNearbyProps(this.MarkerExit, 3000f, this.RequestModel("vw_prop_casino_3cardpoker_01b")))
            {
              if (Entity.op_Inequality((Entity) nearbyProp, (Entity) null))
                this.Tables.Add(nearbyProp);
            }
            foreach (Prop nearbyProp in World.GetNearbyProps(this.MarkerExit, 3000f, this.RequestModel("vw_prop_casino_blckjack_01")))
            {
              if (Entity.op_Inequality((Entity) nearbyProp, (Entity) null))
                this.Tables.Add(nearbyProp);
            }
            foreach (Prop nearbyProp in World.GetNearbyProps(this.MarkerExit, 3000f, this.RequestModel("vw_prop_casino_blckjack_01b")))
            {
              if (Entity.op_Inequality((Entity) nearbyProp, (Entity) null))
                this.Tables.Add(nearbyProp);
            }
          }
          catch
          {
            UI.Notify("~r~ Error 10");
          }
          this.Chair = World.CreateProp(this.SpawnProp("vw_prop_vw_offchair_02"), new Vector3(977.4432f, 48.20891f, 115.25f), true, false);
          ((Entity) this.Chair).set_Heading(-4f);
          ((Entity) this.Chair).set_FreezePosition(true);
          Prop prop1 = World.CreateProp(this.SpawnProp("vw_prop_casino_blckjack_01b"), new Vector3(968.2f, 33.75655f, 115f), true, false);
          ((Entity) prop1).set_Rotation(new Vector3(0.0f, 0.0f, -124f));
          this.Tables.Add(prop1);
          Prop prop2 = World.CreateProp(this.SpawnProp("vw_prop_casino_3cardpoker_01b"), new Vector3(966.2f, 29.93874f, 115f), true, false);
          ((Entity) prop2).set_Rotation(new Vector3(0.0f, 0.0f, -124f));
          this.Tables.Add(prop2);
          Prop prop3 = World.CreateProp(this.SpawnProp("vw_prop_casino_roulette_01"), new Vector3(1147.584f, 265.6707f, -52.8f), true, false);
          this.RouletteTableA = prop3;
          ((Entity) prop3).set_Rotation(new Vector3(0.0f, 0.0f, 133f));
          this.Tables2.Add(prop3);
          Prop prop4 = World.CreateProp(this.SpawnProp("vw_prop_casino_roulette_01b"), new Vector3(1148.889f, 248.0665f, -52f), true, false);
          this.RouletteTableB = prop4;
          ((Entity) prop4).set_Rotation(new Vector3(0.0f, 0.0f, 43f));
          this.Tables2.Add(prop4);
          Prop prop5 = World.CreateProp(this.SpawnProp("vw_prop_casino_roulette_01b"), new Vector3(1129.883f, 267.433f, -52f), true, false);
          this.RouletteTableC = prop5;
          ((Entity) prop5).set_Rotation(new Vector3(0.0f, 0.0f, -159f));
          this.Tables2.Add(prop5);
        }
        catch (Exception ex)
        {
          UI.Notify("~r~ Error 5");
        }
        if (this.SlotPeds)
        {
          try
          {
            for (int index = 0; index < this.SlotMachines.Count; ++index)
            {
              Random random = new Random();
              int num1 = random.Next(0, 100);
              int num2 = random.Next(1, 6);
              if (num1 <= 100)
              {
                Ped randomPed = World.CreateRandomPed(this.SlotMachines[index]);
                ((Entity) randomPed).set_Heading(this.SlotMachinesRot[index]);
                ((Entity) randomPed).set_FreezePosition(true);
                randomPed.set_AlwaysKeepTask(true);
                ((Entity) randomPed).set_IsPersistent(true);
                this.SMPed.Add(randomPed);
                if (num2 == 1)
                  randomPed.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_a", 16f, -1, true, -1f);
                if (num2 == 2)
                  randomPed.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_b", 16f, -1, true, -1f);
                if (num2 == 3)
                  randomPed.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_c", 16f, -1, true, -1f);
                if (num2 == 4)
                  randomPed.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_d", 16f, -1, true, -1f);
                if (num2 == 5)
                  randomPed.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_e", 16f, -1, true, -1f);
                if (num2 == 6)
                  randomPed.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_f", 16f, -1, true, -1f);
                if (num2 > 6)
                  randomPed.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_b", 16f, -1, true, -1f);
                if (num2 < 0)
                  randomPed.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_e", 16f, -1, true, -1f);
              }
            }
            for (int index = 0; index < this.SlotMachines.Count; ++index)
            {
              if (Entity.op_Inequality((Entity) this.SMPed[index], (Entity) null))
              {
                Vector3 position = ((Entity) this.SMPed[index]).get_Position();
                ((Vector3) ref position).\u002Ector((float) position.X, (float) position.Y, (float) (position.Z - 2.29999995231628));
                ((Entity) this.SMPed[index]).set_Position(this.MarkerEnter);
                ((Entity) this.SMPed[index]).get_Position();
                ((Entity) this.SMPed[index]).set_Position(position);
                Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(this.SMPed[index]),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(this.SMPed[index]),
                  InputArgument.op_Implicit(17),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.SMPed[index]),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(this.SMPed[index]),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(this.SMPed[index]),
                  InputArgument.op_Implicit(17),
                  InputArgument.op_Implicit(1)
                });
                this.SMPed[index].set_RelationshipGroup(1);
                this.SMPed[index].set_AlwaysKeepTask(true);
              }
            }
            using (List<Ped>.Enumerator enumerator = this.SMPed.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Ped current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                {
                  Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0)
                  });
                  Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(17),
                    InputArgument.op_Implicit(1)
                  });
                  Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(1)
                  });
                  Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0)
                  });
                  Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                  {
                    InputArgument.op_Implicit(current),
                    InputArgument.op_Implicit(17),
                    InputArgument.op_Implicit(1)
                  });
                  current.set_RelationshipGroup(1);
                  current.set_AlwaysKeepTask(true);
                }
              }
            }
          }
          catch (Exception ex)
          {
            UI.Notify("~r~Error 2~");
          }
        }
        try
        {
          this.Prizecar = World.CreateVehicle(this.RequestModel("thrax"), this.ThraxPos, 9.5f);
          ((Entity) this.Prizecar).set_IsPersistent(true);
        }
        catch (Exception ex)
        {
          UI.Notify("~r~Error 4~");
        }
        this.RefreshPenthouse();
        UI.Notify("~" + this.Uicolour + "~ DC&R ~w~ : Loading Complete");
      }
      if (this.IsDrinking && Entity.op_Inequality((Entity) this.Champaine, (Entity) null))
      {
        if (this.Effect == 6)
        {
          Ped character = Game.get_Player().get_Character();
          ((Entity) character).set_Health(((Entity) character).get_Health() + 10);
        }
        if (this.Effect == 5)
        {
          Ped character = Game.get_Player().get_Character();
          ((Entity) character).set_Health(((Entity) character).get_Health() + 5);
        }
        if (this.Effect == 4)
        {
          Ped character = Game.get_Player().get_Character();
          ((Entity) character).set_Health(((Entity) character).get_Health() + 2);
        }
        if (this.Effect == 3 && ((Entity) Game.get_Player().get_Character()).get_Health() > 10)
        {
          Ped character = Game.get_Player().get_Character();
          ((Entity) character).set_Health(((Entity) character).get_Health() - 1);
        }
        if (this.Effect == 2)
          ((Entity) Game.get_Player().get_Character()).set_HasGravity(false);
        if (this.Effect != 1)
          ;
        if (this.Effect != 0)
          ;
        if (this.Effect != -1)
          ;
        ++this.DrinkTimer;
        if (this.DrinkTimer < 100)
          ;
      }
      if (this.Playing_BlackJack)
      {
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.05f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.05f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.15f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.15f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.25f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.25f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.45f));
      }
      for (int index = 0; index < this.BlackJackTables.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BlackJackTables[index]) < 2.0)
        {
          if (!this.Playing_BlackJack)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to play BlackJack ");
          if (this.Playing_BlackJack && (!this.Placebet && !this.Endgame))
            this.Show_EQ_Chips("Exit", "Place Bet");
          if (this.Placebet && !this.Endgame)
            this.Show_GQ("Accept Hand", "Draw Card");
          if (this.Drawcards && !this.Endgame)
            this.Show_EQ("Fold", "Play Hand");
          if (this.Endgame)
            this.Show_EQ("Exit", "Play Again");
        }
      }
      if (this.Playing_Poker)
      {
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.05f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.05f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.15f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.15f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.25f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.25f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.45f));
      }
      for (int index = 0; index < this.PokerTables.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PokerTables[index]) < 2.0)
        {
          if (!this.Playing_Poker)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to play Poker ");
          if (this.Playing_Poker && (!this.Placebet && !this.Endgame))
            this.Show_EQ_Chips("Exit", "Place Bet");
          if (this.Placebet && !this.Endgame)
            this.Show_GQ("Accept Hand", "Draw Card");
          if (this.Drawcards && !this.Endgame)
            this.Show_EGQ("Fold", "Edit Bet", "Play");
          if (this.Endgame)
            this.Show_EQ("Exit", "Play Again");
        }
      }
      if (this.Playing_Roulette)
      {
        if (Entity.op_Inequality((Entity) this.RouletteTableA, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.RouletteTableA).get_Position()) < 5.0)
        {
          this.TableT = this.RouletteTableA;
          Prop tableT = this.TableT;
        }
        if (Entity.op_Inequality((Entity) this.RouletteTableB, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.RouletteTableB).get_Position()) < 5.0)
        {
          this.TableT = this.RouletteTableB;
          Prop tableT = this.TableT;
        }
        if (Entity.op_Inequality((Entity) this.RouletteTableC, (Entity) null))
        {
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.RouletteTableC).get_Position()) < 5.0)
          {
            this.TableT = this.RouletteTableC;
            Prop tableT = this.TableT;
          }
        }
        else
          UI.Notify("~DC&R MAJOR Error ~W~ : One of The Roulette Tables has failed to spawn, please restart your game");
        if (Entity.op_Inequality((Entity) this.TableT, (Entity) null))
        {
          Prop tableT = this.TableT;
          if (this.MarkerNum < 3)
            this.ShowRouletteOptions(this.TableT);
          if (this.MarkerNum == 3)
            this.ShowRouletteOptionsMid(this.TableT);
          if (this.MarkerNum == 4)
            this.ShowRouletteOptionsEnd(this.TableT);
          if (this.MarkerNum == 5)
          {
            this.ShowRouletteOptionsEndGame(this.TableT);
            if (Game.IsControlJustPressed(2, (Control) 58))
            {
              this.Editbet = false;
              this.Placebet = false;
              this.Drawcards = false;
              this.TableT = (Prop) null;
              this.Endgame = false;
              this.CreatedMarker = false;
              this.PlaceBet_R = false;
              this.Playercards = 0;
              this.DealerCards = 0;
              this.PlayerCard_1 = 0;
              this.PlayerCard_2 = 0;
              this.PlayerCard_3 = 0;
              this.PlayerCard_4 = 0;
              this.PlayerCard_5 = 0;
              this.PlayerCard_6 = 0;
              this.Bet = 0.0f;
              this.DealerCard_1 = 0;
              this.DealerCard_2 = 0;
              this.DealerCard_3 = 0;
              this.DealerCard_4 = 0;
              this.DealerCard_5 = 0;
              this.DealerCard_6 = 0;
              this.BetPos = "None";
              this.BetPosNum = 0;
              this.MarkerNum = 0;
              if (Entity.op_Inequality((Entity) this.RouletteMarker2, (Entity) null))
                ((Entity) this.RouletteMarker2).Delete();
              if (Entity.op_Inequality((Entity) this.RouletteMarker1, (Entity) null))
                ((Entity) this.RouletteMarker1).Delete();
              if (Entity.op_Inequality((Entity) this.RouletteMarker, (Entity) null))
                ((Entity) this.RouletteMarker).Delete();
              this.MarkerNum = 0;
              this.RouletteBet1 = 0.0f;
              this.RouletteBet2 = 0.0f;
              this.RouletteBet3 = 0.0f;
              using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  Prop current = enumerator.Current;
                  if (Entity.op_Inequality((Entity) current, (Entity) null))
                    ((Entity) current).Delete();
                }
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              this.Playing_Roulette = true;
            }
          }
          float num = 0.95f;
          Vector3 offsetInWorldCoords1 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(-0.14f, 0.11f, num));
          Vector3 offsetInWorldCoords2 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(-0.14f, -0.14f, num));
          Vector3 offsetInWorldCoords3 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(-0.05f, -0.185f, num));
          Vector3 offsetInWorldCoords4 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(-0.05f, -0.025f, num));
          Vector3 offsetInWorldCoords5 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(-0.05f, 0.14f, num));
          Vector3 offsetInWorldCoords6 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.03f, -0.185f, num));
          Vector3 offsetInWorldCoords7 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.03f, -0.025f, num));
          Vector3 offsetInWorldCoords8 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.03f, 0.14f, num));
          Vector3 offsetInWorldCoords9 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.1f, -0.185f, num));
          Vector3 offsetInWorldCoords10 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.1f, -0.025f, num));
          Vector3 offsetInWorldCoords11 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.1f, 0.14f, num));
          Vector3 offsetInWorldCoords12 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.19f, -0.185f, num));
          Vector3 offsetInWorldCoords13 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.19f, -0.025f, num));
          Vector3 offsetInWorldCoords14 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.19f, 0.14f, num));
          Vector3 offsetInWorldCoords15 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.27f, -0.185f, num));
          Vector3 offsetInWorldCoords16 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.27f, -0.025f, num));
          Vector3 offsetInWorldCoords17 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.27f, 0.14f, num));
          Vector3 offsetInWorldCoords18 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.35f, -0.185f, num));
          Vector3 offsetInWorldCoords19 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.35f, -0.025f, num));
          Vector3 offsetInWorldCoords20 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.35f, 0.14f, num));
          Vector3 offsetInWorldCoords21 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.43f, -0.185f, num));
          Vector3 offsetInWorldCoords22 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.43f, -0.025f, num));
          Vector3 offsetInWorldCoords23 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.43f, 0.14f, num));
          Vector3 offsetInWorldCoords24 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.51f, -0.185f, num));
          Vector3 offsetInWorldCoords25 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.51f, -0.025f, num));
          Vector3 offsetInWorldCoords26 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.51f, 0.14f, num));
          Vector3 offsetInWorldCoords27 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.59f, -0.185f, num));
          Vector3 offsetInWorldCoords28 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.59f, -0.025f, num));
          Vector3 offsetInWorldCoords29 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.59f, 0.14f, num));
          Vector3 offsetInWorldCoords30 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.67f, -0.185f, num));
          Vector3 offsetInWorldCoords31 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.67f, -0.025f, num));
          Vector3 offsetInWorldCoords32 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.67f, 0.14f, num));
          Vector3 offsetInWorldCoords33 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.75f, -0.185f, num));
          Vector3 offsetInWorldCoords34 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.75f, -0.025f, num));
          Vector3 offsetInWorldCoords35 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.75f, 0.14f, num));
          Vector3 offsetInWorldCoords36 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.83f, -0.185f, num));
          Vector3 offsetInWorldCoords37 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.83f, -0.025f, num));
          Vector3 offsetInWorldCoords38 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.83f, 0.14f, num));
          Vector3 offsetInWorldCoords39 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.91f, -0.185f, num));
          Vector3 offsetInWorldCoords40 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.91f, -0.025f, num));
          Vector3 offsetInWorldCoords41 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.91f, 0.14f, num));
          Vector3 offsetInWorldCoords42 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.83f, -0.35f, num));
          Vector3 offsetInWorldCoords43 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.59f, -0.35f, num));
          Vector3 offsetInWorldCoords44 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(-0.05f, -0.35f, num));
          Vector3 offsetInWorldCoords45 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.19f, -0.35f, num));
          Vector3 offsetInWorldCoords46 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.27f, -0.35f, num));
          Vector3 offsetInWorldCoords47 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.51f, -0.35f, num));
          Vector3 offsetInWorldCoords48 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.27f, -0.3f, num));
          Vector3 offsetInWorldCoords49 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(-0.05f, -0.3f, num));
          Vector3 offsetInWorldCoords50 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(0.83f, -0.3f, num));
          Vector3 offsetInWorldCoords51 = ((Entity) tableT).GetOffsetInWorldCoords(new Vector3(-0.14f, -0.3f, num));
          if (!this.CreatedMarker)
          {
            this.CreatedMarker = true;
            this.RouletteMarker = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), offsetInWorldCoords51, true, false);
            ((Entity) this.RouletteMarker).set_FreezePosition(false);
            this.RouletteMarker1 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), offsetInWorldCoords51, true, false);
            ((Entity) this.RouletteMarker1).set_FreezePosition(false);
            this.RouletteMarker2 = World.CreateProp(this.SpawnProp("vw_prop_roulette_marker"), offsetInWorldCoords51, true, false);
            ((Entity) this.RouletteMarker2).set_FreezePosition(false);
          }
          if (this.MarkerNum == 4 && Game.IsControlJustPressed(2, (Control) 44))
            this.Roulette_Choose_Num();
          if (this.MarkerNum == 0 && Entity.op_Inequality((Entity) this.RouletteMarker1, (Entity) null))
            World.DrawMarker((MarkerType) 1, ((Entity) this.RouletteMarker1).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.01f, 0.01f, 0.25f), Color.Red);
          if (this.MarkerNum == 3)
          {
            if (Game.IsControlJustPressed(2, (Control) 44))
            {
              if ((double) this.RouletteBet1 + (double) this.RouletteBet2 + (double) this.RouletteBet3 < (double) this.Chips_Amount)
                ++this.MarkerNum;
              if ((double) this.RouletteBet1 + (double) this.RouletteBet2 + (double) this.RouletteBet3 > (double) this.Chips_Amount)
                this.DisplayHelpTextThisFrame("The Bet Amount Exceeds your Amount of Chips, please go lower");
            }
            if (Entity.op_Inequality((Entity) this.RouletteMarker1, (Entity) null))
              World.DrawMarker((MarkerType) 1, ((Entity) this.RouletteMarker1).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.01f, 0.01f, 0.25f), Color.Red);
            if (Entity.op_Inequality((Entity) this.RouletteMarker2, (Entity) null))
              World.DrawMarker((MarkerType) 1, ((Entity) this.RouletteMarker2).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.01f, 0.01f, 0.25f), Color.Green);
            if (Entity.op_Inequality((Entity) this.RouletteMarker, (Entity) null))
              World.DrawMarker((MarkerType) 1, ((Entity) this.RouletteMarker).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.01f, 0.01f, 0.25f), Color.Blue);
            if (Game.IsControlJustPressed(2, (Control) 80))
            {
              try
              {
                this.RouletteBet1 = float.Parse(Game.GetUserInput(5));
                UI.Notify("~g~Green~w~ Bet, set to :" + (object) this.RouletteBet1);
              }
              catch (Exception ex)
              {
                UI.Notify("Player did not enter a valid bet");
              }
            }
            if (Game.IsControlJustPressed(2, (Control) 58))
            {
              try
              {
                this.RouletteBet2 = float.Parse(Game.GetUserInput(5));
                UI.Notify("~b~Blue~w~ Bet, set to :" + (object) this.RouletteBet2);
              }
              catch (Exception ex)
              {
                UI.Notify("Player did not enter a valid bet");
              }
            }
            if (Game.IsControlJustPressed(2, (Control) 75))
            {
              try
              {
                this.RouletteBet3 = float.Parse(Game.GetUserInput(5));
                UI.Notify("~r~Red~w~ Bed, set to :" + (object) this.RouletteBet3);
              }
              catch (Exception ex)
              {
                UI.Notify("Player did not enter a valid bet");
              }
            }
          }
          if (this.MarkerNum < 3 && Entity.op_Inequality((Entity) this.MarkerTomove, (Entity) null))
            World.DrawMarker((MarkerType) 1, ((Entity) this.MarkerTomove).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.01f, 0.01f, 0.25f), Color.Red);
          if (this.MarkerNum < 3)
          {
            if (Game.IsControlJustPressed(2, (Control) 80))
            {
              UI.Notify("test1");
              if (this.BetPosNum >= 0)
                ++this.BetPosNum;
              if (this.BetPosNum > 50)
                this.BetPosNum = 0;
              if (this.BetPosNum < 0)
                this.BetPosNum = 50;
              if (this.MarkerNum == 0)
                this.MarkerTomove = this.RouletteMarker;
              if (this.MarkerNum == 1)
                this.MarkerTomove = this.RouletteMarker2;
              if (this.MarkerNum == 2)
                this.MarkerTomove = this.RouletteMarker1;
              if (this.BetPosNum == 0)
              {
                this.BetPos = "None";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords51);
              }
              if (Entity.op_Equality((Entity) this.MarkerTomove, (Entity) null))
                UI.Notify("MK null");
              if (this.BetPosNum == 1)
              {
                this.BetPos = "0";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords2);
              }
              if (this.BetPosNum == 2)
              {
                this.BetPos = "00";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords1);
              }
              if (this.BetPosNum == 3)
              {
                this.BetPos = "Red, 1";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords3);
              }
              if (this.BetPosNum == 4)
              {
                this.BetPos = "Black, 2";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords4);
              }
              if (this.BetPosNum == 5)
              {
                this.BetPos = "Red, 3";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords5);
              }
              if (this.BetPosNum == 6)
              {
                this.BetPos = "Black, 4";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords6);
              }
              if (this.BetPosNum == 7)
              {
                this.BetPos = "Red, 5";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords7);
              }
              if (this.BetPosNum == 8)
              {
                this.BetPos = "Black, 6";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords8);
              }
              if (this.BetPosNum == 9)
              {
                this.BetPos = "Red, 7";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords9);
              }
              if (this.BetPosNum == 10)
              {
                this.BetPos = "Black, 8";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords10);
              }
              if (this.BetPosNum == 11)
              {
                this.BetPos = "Red, 9";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords11);
              }
              if (this.BetPosNum == 12)
              {
                this.BetPos = "Black, 10";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords12);
              }
              if (this.BetPosNum == 13)
              {
                this.BetPos = "Black, 11";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords13);
              }
              if (this.BetPosNum == 14)
              {
                this.BetPos = "Red, 12";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords14);
              }
              if (this.BetPosNum == 15)
              {
                this.BetPos = "Black, 13";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords15);
              }
              if (this.BetPosNum == 16)
              {
                this.BetPos = "Red, 14";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords16);
              }
              if (this.BetPosNum == 17)
              {
                this.BetPos = "Black, 15";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords17);
              }
              if (this.BetPosNum == 18)
              {
                this.BetPos = "Red, 16";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords18);
              }
              if (this.BetPosNum == 19)
              {
                this.BetPos = "Black, 17";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords19);
              }
              if (this.BetPosNum == 20)
              {
                this.BetPos = "Red, 18";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords20);
              }
              if (this.BetPosNum == 21)
              {
                this.BetPos = "Red, 19";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords21);
              }
              if (this.BetPosNum == 22)
              {
                this.BetPos = "Black, 20";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords22);
              }
              if (this.BetPosNum == 23)
              {
                this.BetPos = "Red, 21";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords23);
              }
              if (this.BetPosNum == 24)
              {
                this.BetPos = "Black, 22";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords24);
              }
              if (this.BetPosNum == 25)
              {
                this.BetPos = "Red, 23";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords25);
              }
              if (this.BetPosNum == 26)
              {
                this.BetPos = "Black, 24";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords26);
              }
              if (this.BetPosNum == 27)
              {
                this.BetPos = "Red, 25";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords27);
              }
              if (this.BetPosNum == 28)
              {
                this.BetPos = "Black, 26";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords28);
              }
              if (this.BetPosNum == 29)
              {
                this.BetPos = "Red, 27";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords29);
              }
              if (this.BetPosNum == 30)
              {
                this.BetPos = "Black, 28";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords30);
              }
              if (this.BetPosNum == 31)
              {
                this.BetPos = "Black, 29";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords31);
              }
              if (this.BetPosNum == 32)
              {
                this.BetPos = "Red, 30";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords32);
              }
              if (this.BetPosNum == 33)
              {
                this.BetPos = "Black, 31";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords33);
              }
              if (this.BetPosNum == 34)
              {
                this.BetPos = "Red, 32";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords34);
              }
              if (this.BetPosNum == 35)
              {
                this.BetPos = "Black, 33";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords35);
              }
              if (this.BetPosNum == 36)
              {
                this.BetPos = "Red, 34";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords36);
              }
              if (this.BetPosNum == 37)
              {
                this.BetPos = "Black, 35";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords37);
              }
              if (this.BetPosNum == 38)
              {
                this.BetPos = "Red, 36";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords38);
              }
              if (this.BetPosNum == 39)
              {
                this.BetPos = "1st Column";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords39);
              }
              if (this.BetPosNum == 40)
              {
                this.BetPos = "2nd Column";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords40);
              }
              if (this.BetPosNum == 41)
              {
                this.BetPos = "3rd Column";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords41);
              }
              if (this.BetPosNum == 42)
              {
                this.BetPos = "3rd 12";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords50);
              }
              if (this.BetPosNum == 43)
              {
                this.BetPos = "2nd 12";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords49);
              }
              if (this.BetPosNum == 44)
              {
                this.BetPos = "1st 12";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords48);
              }
              if (this.BetPosNum == 45)
              {
                this.BetPos = "1 to 18";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords44);
              }
              if (this.BetPosNum == 46)
              {
                this.BetPos = "Even";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords45);
              }
              if (this.BetPosNum == 47)
              {
                this.BetPos = "Red";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords46);
              }
              if (this.BetPosNum == 48)
              {
                this.BetPos = "Black";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords47);
              }
              if (this.BetPosNum == 49)
              {
                this.BetPos = "Odd";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords43);
              }
              if (this.BetPosNum == 50)
              {
                this.BetPos = "19 to 36";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords42);
              }
            }
            if (Game.IsControlJustPressed(2, (Control) 58))
            {
              UI.Notify("test2");
              if (this.BetPosNum < 51)
                --this.BetPosNum;
              if (this.BetPosNum > 50)
                this.BetPosNum = 0;
              if (this.BetPosNum < 0)
                this.BetPosNum = 50;
              if (this.MarkerNum == 0)
                this.MarkerTomove = this.RouletteMarker;
              if (this.MarkerNum == 1)
                this.MarkerTomove = this.RouletteMarker2;
              if (this.MarkerNum == 2)
                this.MarkerTomove = this.RouletteMarker1;
              if (this.BetPosNum == 0)
              {
                this.BetPos = "None";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords51);
              }
              if (Entity.op_Equality((Entity) this.MarkerTomove, (Entity) null))
                UI.Notify("MK null");
              if (this.BetPosNum == 1)
              {
                this.BetPos = "0";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords2);
              }
              if (this.BetPosNum == 2)
              {
                this.BetPos = "00";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords1);
              }
              if (this.BetPosNum == 3)
              {
                this.BetPos = "Red, 1";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords3);
              }
              if (this.BetPosNum == 4)
              {
                this.BetPos = "Black, 2";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords4);
              }
              if (this.BetPosNum == 5)
              {
                this.BetPos = "Red, 3";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords5);
              }
              if (this.BetPosNum == 6)
              {
                this.BetPos = "Black, 4";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords6);
              }
              if (this.BetPosNum == 7)
              {
                this.BetPos = "Red, 5";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords7);
              }
              if (this.BetPosNum == 8)
              {
                this.BetPos = "Black, 6";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords8);
              }
              if (this.BetPosNum == 9)
              {
                this.BetPos = "Red, 7";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords9);
              }
              if (this.BetPosNum == 10)
              {
                this.BetPos = "Black, 8";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords10);
              }
              if (this.BetPosNum == 11)
              {
                this.BetPos = "Red, 9";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords11);
              }
              if (this.BetPosNum == 12)
              {
                this.BetPos = "Black, 10";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords12);
              }
              if (this.BetPosNum == 13)
              {
                this.BetPos = "Black, 11";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords13);
              }
              if (this.BetPosNum == 14)
              {
                this.BetPos = "Red, 12";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords14);
              }
              if (this.BetPosNum == 15)
              {
                this.BetPos = "Black, 13";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords15);
              }
              if (this.BetPosNum == 16)
              {
                this.BetPos = "Red, 14";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords16);
              }
              if (this.BetPosNum == 17)
              {
                this.BetPos = "Black, 15";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords17);
              }
              if (this.BetPosNum == 18)
              {
                this.BetPos = "Red, 16";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords18);
              }
              if (this.BetPosNum == 19)
              {
                this.BetPos = "Black, 17";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords19);
              }
              if (this.BetPosNum == 20)
              {
                this.BetPos = "Red, 18";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords20);
              }
              if (this.BetPosNum == 21)
              {
                this.BetPos = "Red, 19";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords21);
              }
              if (this.BetPosNum == 22)
              {
                this.BetPos = "Black, 20";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords22);
              }
              if (this.BetPosNum == 23)
              {
                this.BetPos = "Red, 21";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords23);
              }
              if (this.BetPosNum == 24)
              {
                this.BetPos = "Black, 22";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords24);
              }
              if (this.BetPosNum == 25)
              {
                this.BetPos = "Red, 23";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords25);
              }
              if (this.BetPosNum == 26)
              {
                this.BetPos = "Black, 24";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords26);
              }
              if (this.BetPosNum == 27)
              {
                this.BetPos = "Red, 25";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords27);
              }
              if (this.BetPosNum == 28)
              {
                this.BetPos = "Black, 26";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords28);
              }
              if (this.BetPosNum == 29)
              {
                this.BetPos = "Red, 27";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords29);
              }
              if (this.BetPosNum == 30)
              {
                this.BetPos = "Black, 28";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords30);
              }
              if (this.BetPosNum == 31)
              {
                this.BetPos = "Black, 29";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords31);
              }
              if (this.BetPosNum == 32)
              {
                this.BetPos = "Red, 30";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords32);
              }
              if (this.BetPosNum == 33)
              {
                this.BetPos = "Black, 31";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords33);
              }
              if (this.BetPosNum == 34)
              {
                this.BetPos = "Red, 32";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords34);
              }
              if (this.BetPosNum == 35)
              {
                this.BetPos = "Black, 33";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords35);
              }
              if (this.BetPosNum == 36)
              {
                this.BetPos = "Red, 34";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords36);
              }
              if (this.BetPosNum == 37)
              {
                this.BetPos = "Black, 35";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords37);
              }
              if (this.BetPosNum == 38)
              {
                this.BetPos = "Red, 36";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords38);
              }
              if (this.BetPosNum == 39)
              {
                this.BetPos = "1st Column";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords39);
              }
              if (this.BetPosNum == 40)
              {
                this.BetPos = "2nd Column";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords40);
              }
              if (this.BetPosNum == 41)
              {
                this.BetPos = "3rd Column";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords41);
              }
              if (this.BetPosNum == 42)
              {
                this.BetPos = "3rd 12";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords50);
              }
              if (this.BetPosNum == 43)
              {
                this.BetPos = "2nd 12";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords49);
              }
              if (this.BetPosNum == 44)
              {
                this.BetPos = "1st 12";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords48);
              }
              if (this.BetPosNum == 45)
              {
                this.BetPos = "1 to 18";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords44);
              }
              if (this.BetPosNum == 46)
              {
                this.BetPos = "Even";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords45);
              }
              if (this.BetPosNum == 47)
              {
                this.BetPos = "Red";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords46);
              }
              if (this.BetPosNum == 48)
              {
                this.BetPos = "Black";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords47);
              }
              if (this.BetPosNum == 49)
              {
                this.BetPos = "Odd";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords43);
              }
              if (this.BetPosNum == 50)
              {
                this.BetPos = "19 to 36";
                ((Entity) this.MarkerTomove).set_Position(offsetInWorldCoords42);
              }
            }
            if (Game.IsControlJustPressed(2, (Control) 44))
            {
              ++this.MarkerNum;
              if (this.MarkerNum == 1)
                this.RouletteP1 = this.BetPos;
              if (this.MarkerNum == 2)
                this.RouletteP2 = this.BetPos;
              if (this.MarkerNum == 3)
                this.RouletteP3 = this.BetPos;
              if (this.MarkerNum == 3)
              {
                UI.Notify("~g~ Bet 1 :~w~ " + this.RouletteP1);
                UI.Notify("~b~ Bet 2 :~w~ " + this.RouletteP2);
                UI.Notify("~r~ Bet 3 :~w~ " + this.RouletteP3);
              }
            }
          }
        }
      }
      for (int index = 0; index < this.RouletteTables.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RouletteTables[index]) < 2.0 && !this.Playing_Roulette)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to play Roulette");
      }
      if (this.isRotating)
      {
        if (this.RTimer != this.RMax)
        {
          ++this.RTimer;
          Random random = new Random();
          Vector3 rotation = ((Entity) this.WheelProp).get_Rotation();
          Prop wheelProp = this.WheelProp;
          // ISSUE: cast to a reference type
          ref float local1 = (float&) ref rotation.Y;
          ref float local2 = ref local1;
          float num1 = local1;
          double num2 = (double) num1 + 1.0;
          local2 = (float) num2;
          Quaternion quaternion = Quaternion.RotationYawPitchRoll(num1, 0.0f, 0.0f);
          ((Entity) wheelProp).set_Quaternion(quaternion);
        }
        else
        {
          for (int index = 0; index < this.WheelMarkers.Count; ++index)
          {
            if ((double) World.GetDistance(((Entity) this.WheelWinMarker).get_Position(), ((Entity) this.WheelMarkers[index]).get_Position()) < 0.25)
            {
              World.DrawMarker((MarkerType) 1, ((Entity) this.WheelMarkers[index]).get_Position(), new Vector3(90f, 0.0f, 0.0f), Vector3.get_Zero(), new Vector3(0.1f, 0.1f, 1f), Color.Green);
              if (index == 0)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (Clothing)");
              if (index == 1)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (2,500Rp)");
              if (index == 2)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " ($20,000)");
                Player player = Game.get_Player();
                player.set_Money(player.get_Money() + 20000);
              }
              if (index == 3)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + "(10,000c)");
                this.Chips_Amount += 10000;
                this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                this.Config.Save();
              }
              if (index == 4)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + "(Discount)");
                this.Dis_Unlocked = 1;
                this.Config.SetValue<int>("Setup", "Dis_Unlocked", (M0) this.Dis_Unlocked);
                this.Config.Save();
                UI.Notify(this.GetHostName() + " : The Master's Deck has now been Reduced from 200m to 75m!");
              }
              if (index == 5)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (5,000Rp)");
              if (index == 6)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " ($30,000)");
                Player player = Game.get_Player();
                player.set_Money(player.get_Money() + 30000);
              }
              if (index == 7)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (15,000c)");
                this.Chips_Amount += 15000;
                this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                this.Config.Save();
              }
              if (index == 8)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (Clothing)");
              if (index == 9)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (7,500 Rp)");
              if (index == 10)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (20,000c)");
                this.Chips_Amount += 20000;
                this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                this.Config.Save();
              }
              if (index == 11)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index);
              if (index == 12)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (THRAX)");
                this.ThraxUnlocked = 1;
                this.Config.SetValue<int>("Setup", "ThraxUnlocked", (M0) this.ThraxUnlocked);
                this.Config.Save();
                UI.Notify(this.GetHostName() + " : The Thrax can now be ordered via you Business Garage Menu");
              }
              if (index == 13)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + "(15,000 RP)");
              if (index == 14)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (Clothing)");
              if (index == 15)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (Clothing)");
              if (index == 16)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (25,000c)");
                this.Chips_Amount += 25000;
                this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
                this.Config.Save();
              }
              if (index == 17)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (10,000Rp)");
              if (index == 18)
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (Clothing)");
              if (index == 19)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " (Mystery)");
                this.purchaselvl += 10;
                this.Config.SetValue<int>("Setup", "BuisnessLevel", (M0) this.purchaselvl);
                this.Config.Save();
                UI.Notify(this.GetHostName() + " : You have been gifted +10 Business Levels For Free!");
              }
              if (index == 20)
              {
                UI.Notify(this.GetHostName() + " : You won Prize " + (object) index + " ($50,000)");
                Player player = Game.get_Player();
                player.set_Money(player.get_Money() + 50000);
              }
              this.Config.Save();
            }
          }
          this.isRotating = false;
          this.RTimer = 0;
          this.RMax = 0;
        }
      }
      if (this.modMenuPool.IsAnyMenuOpen() && this.MainStuffMenu.get_Visible() && this.IsinGarageMenu)
      {
        this.IsinGarageMenu = false;
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
        this.modMenuPool.CloseAllMenus();
      }
      if (!this.modMenuPool.IsAnyMenuOpen() && this.IsinGarageMenu)
      {
        this.IsinGarageMenu = false;
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseExit) < 500.0 && !this.CreatedPeds2)
      {
        this.CreatedPeds2 = true;
        this.AddPeds();
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat7) < 4.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to sit in Jacuzzi ");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat8) < 4.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to sit in Jacuzzi ");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat9) < 4.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to sit in Jacuzzi ");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat10) < 4.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to sit in Jacuzzi ");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageMenuPos) < 4.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Open Garage Menu");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageMenuPos) < 80.0)
        World.DrawMarker((MarkerType) 1, this.GarageMenuPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat1) < 4.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to sit in Jacuzzi ");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat1) < 80.0)
        World.DrawMarker((MarkerType) 1, this.jacuzziSeat1, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat2) < 80.0)
        World.DrawMarker((MarkerType) 1, this.jacuzziSeat2, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Red);
      if (!Entity.op_Inequality((Entity) this.RouletteTableB, (Entity) null) || this.Playing_Roulette)
        ;
      if (!Entity.op_Inequality((Entity) this.RouletteTableC, (Entity) null) || this.Playing_Roulette)
        ;
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat4) < 80.0)
        World.DrawMarker((MarkerType) 1, this.jacuzziSeat4, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Green);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat5) < 80.0)
        World.DrawMarker((MarkerType) 1, this.jacuzziSeat5, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Purple);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat6) < 80.0)
        World.DrawMarker((MarkerType) 1, this.jacuzziSeat6, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.YellowGreen);
      for (int index = 0; index < this.DrinkPosPent.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.DrinkPosPent[index]) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to open Drinks Menu ");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.DrinkPosPent[index]) < 10.0)
          World.DrawMarker((MarkerType) 1, this.DrinkPosPent[index], Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.5f, 0.5f, 0.5f), this.MarkerColor);
      }
      this.MarkerColor = Color.FromName(this.MarkerColorString);
      if (Entity.op_Inequality((Entity) this.Prizecar, (Entity) null))
      {
        Vector3 rotation = ((Entity) this.Prizecar).get_Rotation();
        ((Entity) this.Prizecar).set_Rotation(new Vector3((float) rotation.X, (float) rotation.Y, (float) (rotation.Z - 1.0)));
      }
      if (!this.IsinInterior && this.CreatedBlips)
      {
        this.CreatedBlips = false;
        using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            Ped current = enumerator.Current;
            if (Entity.op_Inequality((Entity) current, (Entity) null))
              ((Entity) current).Delete();
          }
        }
        if (Entity.op_Inequality((Entity) this.Prizecar, (Entity) null))
          ((Entity) this.Prizecar).Delete();
        if (this.CreatedBlips)
          this.CreatedBlips = false;
        if (Blip.op_Inequality(this.GarageBlip, (Blip) null))
          this.GarageBlip.Remove();
        if (Blip.op_Inequality(this.PenthouseBlip, (Blip) null))
          this.PenthouseBlip.Remove();
        if (Blip.op_Inequality(this.MenuBlip, (Blip) null))
          this.MenuBlip.Remove();
      }
      if (this.IsinInterior)
      {
        if (this.SlotPeds)
        {
          if (this.SlotTimer != 220)
            ++this.SlotTimer;
          if (this.SlotTimer == 220)
          {
            this.SlotTimer = 0;
            using (List<Ped>.Enumerator enumerator = this.SMPed.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Ped current = enumerator.Current;
                Random random = new Random();
                int num1 = random.Next(0, 100);
                if (num1 > 60)
                {
                  int num2 = random.Next(1, 6);
                  Ped ped = current;
                  if (num2 == 1)
                    ped.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_a", 16f, -1, true, -1f);
                  if (num2 == 2)
                    ped.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_b", 16f, -1, true, -1f);
                  if (num2 == 3)
                    ped.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_c", 16f, -1, true, -1f);
                  if (num2 == 4)
                    ped.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_d", 16f, -1, true, -1f);
                  if (num2 == 5)
                    ped.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_e", 16f, -1, true, -1f);
                  if (num2 == 6)
                    ped.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_f", 16f, -1, true, -1f);
                  if (num2 > 6)
                    ped.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_b", 16f, -1, true, -1f);
                  if (num2 < 0)
                    ped.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "base_idle_e", 16f, -1, true, -1f);
                }
                if (num1 > 45 && num1 < 60)
                  current.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "lose_cruel_a", 16f, -1, true, -1f);
                if (num1 > 35 && num1 < 45)
                  current.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "lose_b", 16f, -1, true, -1f);
                if (num1 > 30 && num1 < 35)
                  current.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "win_c", 16f, -1, true, -1f);
                if (num1 < 30)
                  current.get_Task().PlayAnimation("anim_casino_a@amb@casino@games@slots@male", "pull_spin_a_slotmachine", 16f, -1, true, -1f);
              }
            }
          }
        }
        if (!this.CreatedBlips)
        {
          if (!Entity.op_Equality((Entity) this.Prizecar, (Entity) null))
            ;
          this.CreatePeds();
          if (this.RandomWanderPeds)
          {
            for (int index = 0; index < 35; ++index)
            {
              Random random = new Random();
              Vector3 spawn1 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
              Vector3 spawn2 = this.Spawns[random.Next(0, this.Spawns.Count - 1)];
              this.ped = World.CreateRandomPed(((Vector3) ref spawn2).Around(10f));
              Vector3 position = ((Entity) this.ped).get_Position();
              ((Entity) this.ped).set_Position(new Vector3((float) position.X, (float) position.Y, -49f));
              this.ped.set_RelationshipGroup(2);
              this.ped.set_AlwaysKeepTask(true);
              Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
              {
                InputArgument.op_Implicit(this.ped),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
              {
                InputArgument.op_Implicit(this.ped),
                InputArgument.op_Implicit(17),
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
              {
                InputArgument.op_Implicit(this.ped),
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
              {
                InputArgument.op_Implicit(this.ped),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
              {
                InputArgument.op_Implicit(this.ped),
                InputArgument.op_Implicit(17),
                InputArgument.op_Implicit(1)
              });
              this.ped.set_RelationshipGroup(1);
              this.ped.set_AlwaysKeepTask(true);
              this.ped.get_Task().WanderAround();
              this.Peds.Add(this.ped);
            }
          }
          Script.Wait(200);
          using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Ped current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
              {
                Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(17),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 8116279360099375049L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                {
                  InputArgument.op_Implicit(current),
                  InputArgument.op_Implicit(17),
                  InputArgument.op_Implicit(1)
                });
                current.set_RelationshipGroup(1);
                current.set_AlwaysKeepTask(true);
              }
            }
          }
          using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Ped current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null) && (double) World.GetDistance(((Entity) current).get_Position(), ((Entity) this.Prizecar).get_Position()) < 7.0)
                ((Entity) current).Delete();
            }
          }
          this.CreatedBlips = true;
        }
      }
      if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.VehicleMissioncar).get_Position()) < 100.0)
        ((Entity) this.VehicleMissioncar).set_IsInvincible(false);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MarkerEnter) < 60.0)
        World.DrawMarker((MarkerType) 1, this.MarkerEnter, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MarkerExit) < 60.0)
        World.DrawMarker((MarkerType) 1, this.MarkerExit, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
      if (this.Casino_level >= 1)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MembershipUpgradeMarker) < 60.0)
          World.DrawMarker((MarkerType) 1, this.MembershipUpgradeMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MembershipUpgradeMarker) < 3.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Upgrade you casino Membership");
      }
      if (this.Casino_level >= 3)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter) < 60.0)
          World.DrawMarker((MarkerType) 1, this.PenthouseEnter, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter2) < 60.0)
          World.DrawMarker((MarkerType) 1, this.PenthouseEnter2, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter3) < 60.0)
          World.DrawMarker((MarkerType) 1, this.PenthouseEnter3, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseExit) < 60.0)
          World.DrawMarker((MarkerType) 1, this.PenthouseExit, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseExit2) < 60.0)
          World.DrawMarker((MarkerType) 1, this.PenthouseExit2, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChipsPurchaseMarker) < 60.0)
        World.DrawMarker((MarkerType) 1, this.ChipsPurchaseMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChipsPurchaseMarker) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to purchase Chips");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RaceSTMarker) < 60.0)
        World.DrawMarker((MarkerType) 1, this.RaceSTMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RaceSTMarker) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Start a Race");
      if (this.Casino_level >= 3)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseUpgradeMarker) < 60.0)
          World.DrawMarker((MarkerType) 1, this.PenthouseUpgradeMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseUpgradeMarker) < 3.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Open Penthouse Upgrade Menu");
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.LuckyWheel) < 60.0)
        World.DrawMarker((MarkerType) 1, this.LuckyWheel, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.5f, 0.5f, 0.5f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.LuckyWheel) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Spin the Lucky Wheel");
      if (this.Casino_level >= 3)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageEnt) < 60.0)
          World.DrawMarker((MarkerType) 1, this.GarageEnt, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageEnt) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to enter garage");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageExit) < 60.0)
          World.DrawMarker((MarkerType) 1, this.GarageExit, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageExit) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~/~INPUT_COVER~ to exit garage");
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopEntA) < 60.0)
        World.DrawMarker((MarkerType) 1, this.RooftopEntA, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopEntA) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to go to Heli Pad");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopEntB) < 60.0)
        World.DrawMarker((MarkerType) 1, this.RooftopEntB, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopEntB) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to go to Heli Pad");
      if (this.Casino_level >= 3)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopExitA) < 60.0)
          World.DrawMarker((MarkerType) 1, this.RooftopExitA, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopExitA) < 3.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to go to Casino");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopExitB) < 60.0)
          World.DrawMarker((MarkerType) 1, this.RooftopExitB, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopExitB) < 3.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to go to Penthouse");
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MarkerEnter) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Enter Diamond Casino & Resort");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MarkerExit) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Exit Diamond Casino & Resort");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageMarker) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Enter Office");
      if (Entity.op_Inequality((Entity) this.Chair, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(977.4432f, 48.20891f, 115.25f)) < 3.0)
      {
        if (this.IsSittinginCeoSeat2 && this.Casino_level >= 3)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Open Menu, Press ~INPUT_COVER~ to Exit");
        if (!this.IsSittinginCeoSeat2 && this.Casino_level >= 3)
          this.DisplayHelpTextThisFrame("Press ~INPUT_COVER~ to sit on CEO chair to access Menu");
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChairPos) < 2.0)
      {
        if (this.IsSittinginCeoSeat)
        {
          if (this.Casino_level >= 2)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Open Menu, Press ~INPUT_COVER~ to Exit");
        }
        else
        {
          if (this.Casino_level >= 2)
            this.DisplayHelpTextThisFrame("Press ~INPUT_COVER~ to sit on CEO chair to access Menu");
          if (this.Casino_level < 2)
            this.DisplayHelpTextThisFrame("You Need the 'Business Level' to Manage this Business");
        }
      }
      if (Entity.op_Inequality((Entity) this.Chair, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(977.4432f, 48.20891f, 115.25f)) > 4.0 && this.IsSittinginCeoSeat2)
      {
        if (!this.WCamOn)
          this.modMenuPool.CloseAllMenus();
        this.IsSittinginCeoSeat2 = false;
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
        Game.FadeScreenOut(500);
        Script.Wait(500);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.ChairPos);
        ((Entity) Game.get_Player().get_Character()).set_Heading(this.P_Rotation);
        Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Game.get_Player().get_Character().get_Task().ClearAnimation("anim@amb@office@laptops@male@var_c@base@", "base");
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
        Script.Wait(500);
        Game.FadeScreenIn(500);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChairPos) > 4.0 && this.IsSittinginCeoSeat)
      {
        if (!this.WCamOn)
          this.modMenuPool.CloseAllMenus();
        this.IsSittinginCeoSeat = false;
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
        Game.FadeScreenOut(500);
        Script.Wait(500);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.ChairPos);
        ((Entity) Game.get_Player().get_Character()).set_Heading(this.P_Rotation);
        Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Game.get_Player().get_Character().get_Task().ClearAnimation("anim@amb@office@laptops@male@var_c@base@", "base");
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
        Script.Wait(500);
        Game.FadeScreenIn(500);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter) < 2.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to enter Casino");
      if (this.Casino_level >= 3)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter2) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to enter Penthouse");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseExit) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to go to rooftop");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseExit2) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to exit Penthouse OR ~INPUT_COVER~ to enter Casino");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter3) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Enter Penthouse OR ~INPUT_COVER~ to enter garage");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(974.8987f, 12.62897f, 80f)) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to go to Rooftop");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(938.8819f, -1.1f, 110f)) < 2.0)
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to go to Ground Level");
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(974.8987f, 12.62897f, 80f)) < 80.0)
          World.DrawMarker((MarkerType) 1, new Vector3(974.8987f, 12.62897f, 80f), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), this.MarkerColor);
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(938.8819f, -1.1f, 110f)) < 80.0)
          World.DrawMarker((MarkerType) 1, new Vector3(938.8819f, -1.1f, 110f), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), this.MarkerColor);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SleepPos) < 3.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Sleep");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MBTOfficeSitPos) < 2.0 && !this.sitting)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Sit");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MBTOfficeSitPos) < 2.0 && this.sitting)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to get up");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(1114.801f, 253.6271f, -46.4f)) >= 10.0)
        ;
      if (this.DeliveryMissionOn)
      {
        if (Entity.op_Inequality((Entity) this.Plane, (Entity) null))
        {
          if (((Entity) this.Plane).get_IsAlive())
          {
            if (Blip.op_Inequality(this.PlaneBlip, (Blip) null))
              this.PlaneBlip.set_Position(((Entity) this.Plane).get_Position());
            this.LocationBlip.set_Position(this.MissionMarker);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MissionMarker) < 500.0)
              World.DrawMarker((MarkerType) 1, this.MissionMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(9f, 9f, 40f), Color.Red);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MissionMarker) < 20.0)
              this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to to deliver package");
          }
          else if (!((Entity) this.Plane).get_IsAlive())
          {
            this.shipmentsDElivered = 0;
            this.DeliveryMissionOn = false;
            if (Entity.op_Inequality((Entity) this.Plane, (Entity) null))
              ((Entity) this.Plane).Delete();
            if (Blip.op_Inequality(this.PlaneBlip, (Blip) null))
              this.PlaneBlip.Remove();
            if (Blip.op_Inequality(this.LocationBlip, (Blip) null))
              this.LocationBlip.Remove();
            UI.Notify(this.GetHostName() + ": Ahhhhhh no, we lost the shipments we, will have to attempt this one again");
          }
        }
      }
      else
      {
        if (Entity.op_Inequality((Entity) this.Plane, (Entity) null))
          ((Entity) this.Plane).Delete();
        if (Blip.op_Inequality(this.PlaneBlip, (Blip) null))
          this.PlaneBlip.Remove();
        if ((this.Missionnum != 14 || !this.VehicleSetup) && Blip.op_Inequality(this.LocationBlip, (Blip) null))
          this.LocationBlip.Remove();
      }
      if (!this.VehicleSetup)
        return;
      if (this.Missionnum == 17)
      {
        if (((Entity) Game.get_Player().get_Character()).get_IsAlive())
        {
          if (((Entity) this.Avery).get_IsAlive())
          {
            if (this.TriggeredEscape)
            {
              if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.EscapeHeli).get_Position()) < 250.0)
                ((Entity) this.EscapeHeli).set_IsInvincible(false);
              if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.Avery).get_Position()) > 750.0)
              {
                if (Entity.op_Inequality((Entity) this.TargetPed, (Entity) null))
                  ((Entity) this.TargetPed).Delete();
                if (Entity.op_Inequality((Entity) this.Avery, (Entity) null))
                  ((Entity) this.Avery).Delete();
                if (Entity.op_Inequality((Entity) this.Pilot, (Entity) null))
                  ((Entity) this.Pilot).Delete();
                if (Entity.op_Inequality((Entity) this.EscapeHeli, (Entity) null))
                  ((Entity) this.EscapeHeli).Delete();
                if (Entity.op_Inequality((Entity) this.PatrolCar, (Entity) null))
                  ((Entity) this.PatrolCar).Delete();
                using (List<Ped>.Enumerator enumerator = this.Guard.GetEnumerator())
                {
                  while (enumerator.MoveNext())
                  {
                    Ped current = enumerator.Current;
                    if (Entity.op_Inequality((Entity) current, (Entity) null))
                      ((Entity) current).Delete();
                  }
                }
                this.Missionnum = 0;
                this.VehicleSetup = false;
                new MissionScreen().SetFail("Crashing Out", 4125000, "Avery has escaped!");
                UI.Notify(this.GetHostName() + " : Looks like we will have to replan our responce to Avery's actions");
                this.Missionnum = 0;
                this.VehicleSetup = false;
              }
            }
            if (this.MoveTimer != 75)
              ++this.MoveTimer;
            if (this.MoveTimer == 75)
            {
              this.MoveTimer = 0;
              using (List<Ped>.Enumerator enumerator = this.Guard.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  Ped current = enumerator.Current;
                  if (Entity.op_Inequality((Entity) current, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) current).get_Position()) > 30.0)
                    current.get_Task().WanderAround(((Entity) current).get_Position(), 100f);
                }
              }
            }
            if (Entity.op_Inequality((Entity) this.Avery.get_CurrentVehicle(), (Entity) null) && Entity.op_Inequality((Entity) this.Pilot.get_CurrentVehicle(), (Entity) null) && this.TriggeredEscape)
            {
              if (Entity.op_Equality((Entity) this.TargetPed, (Entity) null))
              {
                Model model = Model.op_Implicit((PedHash) 1074457665);
                Vector3 position = ((Entity) this.EscapeHeli).get_Position();
                Vector3 vector3 = ((Vector3) ref position).Around(6000f);
                this.TargetPed = World.CreatePed(model, vector3);
                ((Entity) this.TargetPed).set_FreezePosition(true);
                ((Entity) this.TargetPed).set_IsVisible(false);
              }
              if (Entity.op_Inequality((Entity) this.TargetPed, (Entity) null))
                this.Pilot.get_Task().FightAgainst(this.TargetPed);
            }
            using (List<Ped>.Enumerator enumerator1 = this.Guard.GetEnumerator())
            {
              while (enumerator1.MoveNext())
              {
                Ped current1 = enumerator1.Current;
                if (Entity.op_Inequality((Entity) current1, (Entity) null))
                {
                  if (!((Entity) current1).get_IsAlive() && ((Entity) current1).get_Alpha() >= (int) byte.MaxValue)
                  {
                    ((Entity) current1).set_Alpha(254);
                    ((Entity) current1).get_CurrentBlip().set_Alpha(0);
                  }
                  if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) current1).get_Position()) > 10.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) current1).get_Position()) < 30.0)
                    current1.get_Task().GoTo(((Entity) Game.get_Player().get_Character()).get_Position());
                  if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) current1).get_Position()) < 10.0)
                  {
                    int num1 = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
                    {
                      InputArgument.op_Implicit("HATES_PLAYER")
                    });
                    Function.Call((Hash) -4032282232082276974L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(current1),
                      InputArgument.op_Implicit(num1)
                    });
                    Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                    {
                      InputArgument.op_Implicit(current1),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(0)
                    });
                    Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(current1),
                      InputArgument.op_Implicit(1)
                    });
                    current1.get_Task().FightAgainst(Game.get_Player().get_Character());
                    this.TriggeredEscape = true;
                    if (Entity.op_Inequality((Entity) this.Pilot, (Entity) null) && ((Entity) this.Pilot).get_IsAlive() && Entity.op_Equality((Entity) this.Pilot.get_CurrentVehicle(), (Entity) null))
                    {
                      Ped pilot = this.Pilot;
                      int num2 = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
                      {
                        InputArgument.op_Implicit("HATES_PLAYER")
                      });
                      Function.Call((Hash) -4032282232082276974L, new InputArgument[2]
                      {
                        InputArgument.op_Implicit(pilot),
                        InputArgument.op_Implicit(num2)
                      });
                      Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                      {
                        InputArgument.op_Implicit(pilot),
                        InputArgument.op_Implicit(0),
                        InputArgument.op_Implicit(0)
                      });
                      Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                      {
                        InputArgument.op_Implicit(pilot),
                        InputArgument.op_Implicit(1)
                      });
                      this.Pilot.get_Task().EnterVehicle(this.EscapeHeli, (VehicleSeat) -1);
                    }
                    if (Entity.op_Inequality((Entity) this.Avery, (Entity) null) && ((Entity) this.Avery).get_IsAlive() && Entity.op_Equality((Entity) this.Avery.get_CurrentVehicle(), (Entity) null))
                    {
                      Ped avery = this.Avery;
                      int num2 = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
                      {
                        InputArgument.op_Implicit("HATES_PLAYER")
                      });
                      Function.Call((Hash) -4032282232082276974L, new InputArgument[2]
                      {
                        InputArgument.op_Implicit(avery),
                        InputArgument.op_Implicit(num2)
                      });
                      Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                      {
                        InputArgument.op_Implicit(avery),
                        InputArgument.op_Implicit(0),
                        InputArgument.op_Implicit(0)
                      });
                      Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                      {
                        InputArgument.op_Implicit(avery),
                        InputArgument.op_Implicit(1)
                      });
                      this.Avery.get_Task().EnterVehicle(this.EscapeHeli, (VehicleSeat) 0);
                    }
                    using (List<Ped>.Enumerator enumerator2 = this.Guard.GetEnumerator())
                    {
                      while (enumerator2.MoveNext())
                      {
                        Ped current2 = enumerator2.Current;
                        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) current2).get_Position()) < 200.0)
                        {
                          int num2 = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
                          {
                            InputArgument.op_Implicit("HATES_PLAYER")
                          });
                          Function.Call((Hash) -4032282232082276974L, new InputArgument[2]
                          {
                            InputArgument.op_Implicit(current2),
                            InputArgument.op_Implicit(num2)
                          });
                          Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                          {
                            InputArgument.op_Implicit(current2),
                            InputArgument.op_Implicit(0),
                            InputArgument.op_Implicit(0)
                          });
                          Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                          {
                            InputArgument.op_Implicit(current2),
                            InputArgument.op_Implicit(1)
                          });
                          current2.get_Task().FightAgainst(Game.get_Player().get_Character());
                          this.TriggeredEscape = true;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
          if (!((Entity) this.Avery).get_IsAlive())
          {
            if (Entity.op_Inequality((Entity) this.TargetPed, (Entity) null))
              ((Entity) this.TargetPed).Delete();
            if (Entity.op_Inequality((Entity) this.Avery, (Entity) null))
              ((Entity) this.Avery).Delete();
            if (Entity.op_Inequality((Entity) this.Pilot, (Entity) null))
              ((Entity) this.Pilot).Delete();
            if (Entity.op_Inequality((Entity) this.EscapeHeli, (Entity) null))
              ((Entity) this.EscapeHeli).Delete();
            if (Entity.op_Inequality((Entity) this.PatrolCar, (Entity) null))
              ((Entity) this.PatrolCar).Delete();
            using (List<Ped>.Enumerator enumerator = this.Guard.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Ped current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Missionnum = 0;
            this.VehicleSetup = false;
            new MissionScreen().SetPass("Crashing Out", 4125000, "The Player has died");
            UI.Notify(this.GetHostName() + " : Stocks just Increased");
            UI.Notify("Max Stocks: " + (object) this.maxstocks);
            UI.Notify("Annual Gain: $" + this.increaseGain.ToString("N"));
            UI.Notify("Mission Gain: " + (object) this.profitMargin + "%");
            UI.Notify("Stock Value: $" + this.stocksvalue.ToString("N"));
            this.stocksvalue = (float) ((double) this.stocksvalue + 4125000.0 + 4125000.0 * (double) this.profitMargin / 100.0);
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
        }
        else if (!((Entity) Game.get_Player().get_Character()).get_IsAlive())
        {
          if (Entity.op_Inequality((Entity) this.TargetPed, (Entity) null))
            ((Entity) this.TargetPed).Delete();
          if (Entity.op_Inequality((Entity) this.Avery, (Entity) null))
            ((Entity) this.Avery).Delete();
          if (Entity.op_Inequality((Entity) this.Pilot, (Entity) null))
            ((Entity) this.Pilot).Delete();
          if (Entity.op_Inequality((Entity) this.EscapeHeli, (Entity) null))
            ((Entity) this.EscapeHeli).Delete();
          if (Entity.op_Inequality((Entity) this.PatrolCar, (Entity) null))
            ((Entity) this.PatrolCar).Delete();
          using (List<Ped>.Enumerator enumerator = this.Guard.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Ped current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
          this.Missionnum = 0;
          this.VehicleSetup = false;
          new MissionScreen().SetFail("Crashing Out", 4125000, "You Died");
          UI.Notify(this.GetHostName() + " : Looks like we will have to replan our responce to Avery's actions");
          this.Missionnum = 0;
          this.VehicleSetup = false;
        }
      }
      if (this.Missionnum == 16)
      {
        if (((Entity) Game.get_Player().get_Character()).get_IsAlive())
        {
          if (this.EnemiesKilled == 30)
          {
            this.Missionnum = 0;
            this.VehicleSetup = false;
            using (List<Vehicle>.Enumerator enumerator = this.EnemyVeh.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Vehicle current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Ped current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            if (Entity.op_Inequality((Entity) this.TankerA, (Entity) null))
              ((Entity) this.TankerA).Delete();
            new MissionScreen().SetPass("Bad Beaf", 2125000, "The Player has died");
            UI.Notify(this.GetHostName() + " : Stocks just Increased");
            UI.Notify("Max Stocks: " + (object) this.maxstocks);
            UI.Notify("Annual Gain: $" + this.increaseGain.ToString("N"));
            UI.Notify("Mission Gain: " + (object) this.profitMargin + "%");
            UI.Notify("Stock Value: $" + this.stocksvalue.ToString("N"));
            this.AddPeds();
            this.stocksvalue = (float) ((double) this.stocksvalue + 2125000.0 + 2125000.0 * (double) this.profitMargin / 100.0);
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
          if (this.EnemiesKilled != 30)
          {
            this.DisplayHelpTextThisFrame("Attackers dead " + (object) this.EnemiesKilled + "/30");
            if (this.EnemySpawntimer != 120)
              ++this.EnemySpawntimer;
            if (this.EnemySpawntimer == 120)
            {
              this.EnemySpawntimer = 0;
              float num1 = (float) new Random().Next(1, 3);
              if ((double) num1 == 1.0)
              {
                Ped ped = World.CreatePed(Model.op_Implicit((PedHash) 1631478380), new Vector3(914f, 50f, 111f));
                ped.get_Weapons().Give((WeaponHash) 2132975508, 9999, true, true);
                ((Entity) ped).AddBlip();
                ((Entity) ped).get_CurrentBlip().set_Name("Avery Goon");
                ((Entity) ped).get_CurrentBlip().set_Color((BlipColor) 1);
                ped.get_Task().FightAgainst(Game.get_Player().get_Character());
                this.EnemyAi.Add(ped);
              }
              if ((double) num1 == 2.0)
              {
                Ped ped = World.CreatePed(Model.op_Implicit((PedHash) 1631478380), new Vector3(915f, 20f, 112f));
                ped.get_Weapons().Give((WeaponHash) 2132975508, 9999, true, true);
                ((Entity) ped).AddBlip();
                ((Entity) ped).get_CurrentBlip().set_Name("Avery Goon");
                ((Entity) ped).get_CurrentBlip().set_Color((BlipColor) 1);
                ped.get_Task().FightAgainst(Game.get_Player().get_Character());
                this.EnemyAi.Add(ped);
              }
              if ((double) num1 == 3.0)
              {
                Ped ped = World.CreatePed(Model.op_Implicit((PedHash) 1631478380), new Vector3(910f, 27f, 111f));
                ped.get_Weapons().Give((WeaponHash) 2132975508, 9999, true, true);
                ((Entity) ped).AddBlip();
                ((Entity) ped).get_CurrentBlip().set_Name("Avery Goon");
                ((Entity) ped).get_CurrentBlip().set_Color((BlipColor) 1);
                ped.get_Task().FightAgainst(Game.get_Player().get_Character());
                this.EnemyAi.Add(ped);
              }
              using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  Ped current = enumerator.Current;
                  if (Entity.op_Inequality((Entity) current, (Entity) null))
                  {
                    Ped ped = current;
                    int num2 = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
                    {
                      InputArgument.op_Implicit("HATES_PLAYER")
                    });
                    Function.Call((Hash) -4032282232082276974L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(ped),
                      InputArgument.op_Implicit(num2)
                    });
                    Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
                    {
                      InputArgument.op_Implicit(ped),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(0)
                    });
                    Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(ped),
                      InputArgument.op_Implicit(1)
                    });
                    ped.get_Weapons().Give((WeaponHash) 324215364, 9999, true, true);
                    ped.get_Task().FightAgainst(Game.get_Player().get_Character());
                  }
                }
              }
            }
            using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Ped current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null) && ((Entity) current).get_IsDead() && ((Entity) current).get_Alpha() == (int) byte.MaxValue)
                {
                  ((Entity) current).set_Alpha(254);
                  ++this.EnemiesKilled;
                  ((Entity) this.ped).get_CurrentBlip().Remove();
                }
              }
            }
          }
        }
        if (!((Entity) Game.get_Player().get_Character()).get_IsAlive())
        {
          new MissionScreen().SetFail("BadBeaf", 3125000, "You Died");
          UI.Notify(this.GetHostName() + " : We will have to clean up this mess ourselfs!");
          this.Missionnum = 0;
          this.VehicleSetup = false;
          if (Entity.op_Inequality((Entity) this.TankerA, (Entity) null))
            ((Entity) this.TankerA).Delete();
          using (List<Vehicle>.Enumerator enumerator = this.EnemyVeh.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Vehicle current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
          using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Ped current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
          this.AddPeds();
        }
      }
      if (this.Missionnum == 14)
      {
        if (((Entity) Game.get_Player().get_Character()).get_IsAlive())
        {
          if (this.EnemyTimer != 500)
            ++this.EnemyTimer;
          if (this.EnemyTimer == 500)
          {
            this.SpawnGTM_Enemy();
            this.EnemyTimer = 0;
          }
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MissionMarker) < 60.0)
            World.DrawMarker((MarkerType) 1, this.MissionMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(4f, 4f, 6f), this.MarkerColor);
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MissionMarker) < 4.0)
          {
            UI.Notify(this.GetHostName() + " : Stocks just Increased");
            UI.Notify("Max Stocks: " + (object) this.maxstocks);
            UI.Notify("Annual Gain: $" + this.increaseGain.ToString("N"));
            UI.Notify("Mission Gain: " + (object) this.profitMargin + "%");
            UI.Notify("Stock Value: $" + this.stocksvalue.ToString("N"));
            this.stocksvalue = (float) ((double) this.stocksvalue + 125000.0 + 125000.0 * (double) this.profitMargin / 100.0);
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
            using (List<Vehicle>.Enumerator enumerator = this.EnemyVeh.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Vehicle current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Ped current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            if (Blip.op_Inequality(this.LocationBlip, (Blip) null))
              this.LocationBlip.Remove();
            this.VehicleSetup = false;
            this.Missionnum = 0;
          }
        }
        if (!((Entity) Game.get_Player().get_Character()).get_IsAlive())
        {
          this.VehicleSetup = false;
          this.Missionnum = 0;
          using (List<Vehicle>.Enumerator enumerator = this.EnemyVeh.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Vehicle current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
          using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Ped current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
          if (Blip.op_Inequality(this.LocationBlip, (Blip) null))
            this.LocationBlip.Remove();
          UI.Notify(this.GetHostName() + " : You died, we will have to recover the package and send out a new delivery guy");
        }
      }
      if (this.Missionnum == 15)
      {
        if (Game.get_Player().get_IsAlive())
        {
          if (((Entity) this.TankerA).get_IsAlive() || ((Entity) this.TankerB).get_IsAlive() || ((Entity) this.TankerC).get_IsAlive() || ((Entity) this.TankerD).get_IsAlive())
          {
            if (this.EnemyTimer != 500)
              ++this.EnemyTimer;
            if (this.EnemyTimer == 500)
            {
              if (!((Entity) this.TankerA).get_IsAlive())
                this.SpawnGTM_Enemy();
              if (!((Entity) this.TankerB).get_IsAlive())
                this.SpawnGTM_Enemy();
              if (!((Entity) this.TankerC).get_IsAlive())
                this.SpawnGTM_Enemy();
              if (!((Entity) this.TankerD).get_IsAlive())
                this.SpawnGTM_Enemy();
              this.EnemyTimer = 0;
            }
          }
          if (!((Entity) this.TankerA).get_IsAlive() && !((Entity) this.TankerB).get_IsAlive() && !((Entity) this.TankerC).get_IsAlive() && !((Entity) this.TankerD).get_IsAlive())
          {
            new MissionScreen().SetPass("Play To Win", 3125000, "The Player has died");
            UI.Notify(this.GetHostName() + " : Stocks just Increased");
            UI.Notify("Max Stocks: " + (object) this.maxstocks);
            UI.Notify("Annual Gain: $" + this.increaseGain.ToString("N"));
            UI.Notify("Mission Gain: " + (object) this.profitMargin + "%");
            UI.Notify("Stock Value: $" + this.stocksvalue.ToString("N"));
            this.stocksvalue = (float) ((double) this.stocksvalue + 3125000.0 + 3125000.0 * (double) this.profitMargin / 100.0);
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
            this.Missionnum = 15;
            this.VehicleSetup = false;
            using (List<Vehicle>.Enumerator enumerator = this.EnemyVeh.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Vehicle current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Ped current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            if (Entity.op_Inequality((Entity) this.TankerA, (Entity) null))
              ((Entity) this.TankerA).Delete();
            if (Entity.op_Inequality((Entity) this.TankerB, (Entity) null))
              ((Entity) this.TankerB).Delete();
            if (Entity.op_Inequality((Entity) this.TankerC, (Entity) null))
              ((Entity) this.TankerC).Delete();
            if (Entity.op_Inequality((Entity) this.TankerD, (Entity) null))
              ((Entity) this.TankerD).Delete();
            if (Entity.op_Inequality((Entity) this.TankerE, (Entity) null))
              ((Entity) this.TankerE).Delete();
            if (Entity.op_Inequality((Entity) this.TankerF, (Entity) null))
              ((Entity) this.TankerF).Delete();
            if (Entity.op_Inequality((Entity) this.TankerG, (Entity) null))
              ((Entity) this.TankerG).Delete();
            if (Entity.op_Inequality((Entity) this.TankerH, (Entity) null))
              ((Entity) this.TankerH).Delete();
          }
        }
        else if (!Game.get_Player().get_IsAlive())
        {
          new MissionScreen().SetFail("Play To Win", 3125000, "You Died");
          UI.Notify(this.GetHostName() + " : Avery's Assets cannot go undammaged! we cannot allow this");
          this.Missionnum = 15;
          this.VehicleSetup = false;
          if (Entity.op_Inequality((Entity) this.TankerA, (Entity) null))
            ((Entity) this.TankerA).Delete();
          if (Entity.op_Inequality((Entity) this.TankerB, (Entity) null))
            ((Entity) this.TankerB).Delete();
          if (Entity.op_Inequality((Entity) this.TankerC, (Entity) null))
            ((Entity) this.TankerC).Delete();
          if (Entity.op_Inequality((Entity) this.TankerD, (Entity) null))
            ((Entity) this.TankerD).Delete();
          if (Entity.op_Inequality((Entity) this.TankerE, (Entity) null))
            ((Entity) this.TankerE).Delete();
          if (Entity.op_Inequality((Entity) this.TankerF, (Entity) null))
            ((Entity) this.TankerF).Delete();
          if (Entity.op_Inequality((Entity) this.TankerG, (Entity) null))
            ((Entity) this.TankerG).Delete();
          if (Entity.op_Inequality((Entity) this.TankerH, (Entity) null))
            ((Entity) this.TankerH).Delete();
          using (List<Vehicle>.Enumerator enumerator = this.EnemyVeh.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Vehicle current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
          using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Ped current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
        }
      }
    }

    public void SpawnGTM_Enemy()
    {
      Random random = new Random();
      int num1 = random.Next(1, 3);
      Vehicle vehicle = this.Vehicle1;
      Vector3 position;
      if (num1 == 1)
      {
        Model model = Model.op_Implicit("GAUNTLET4");
        position = ((Entity) Game.get_Player().get_Character()).get_Position();
        Vector3 vector3 = ((Vector3) ref position).Around((float) random.Next(50, 250));
        vehicle = World.CreateVehicle(model, vector3);
        vehicle.PlaceOnNextStreet();
        vehicle.PlaceOnGround();
        vehicle.set_PrimaryColor((VehicleColor) 12);
        vehicle.set_SecondaryColor((VehicleColor) 12);
        Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
        {
          InputArgument.op_Implicit(((Entity) vehicle).get_Handle()),
          InputArgument.op_Implicit(0)
        });
        vehicle.SetMod((VehicleMod) 15, 3, true);
        vehicle.SetMod((VehicleMod) 16, 3, true);
        vehicle.set_PrimaryColor((VehicleColor) 12);
        vehicle.set_SecondaryColor((VehicleColor) 12);
        vehicle.set_WindowTint((VehicleWindowTint) 5);
        vehicle.SetMod((VehicleMod) 7, 9, true);
        vehicle.set_PearlescentColor((VehicleColor) 12);
      }
      if (num1 == 2)
      {
        Model model = Model.op_Implicit("CARACARA2");
        position = ((Entity) Game.get_Player().get_Character()).get_Position();
        Vector3 vector3 = ((Vector3) ref position).Around((float) random.Next(50, 250));
        vehicle = World.CreateVehicle(model, vector3);
        vehicle.PlaceOnNextStreet();
        vehicle.PlaceOnGround();
        Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
        {
          InputArgument.op_Implicit(((Entity) vehicle).get_Handle()),
          InputArgument.op_Implicit(0)
        });
        vehicle.SetMod((VehicleMod) 15, 3, true);
        vehicle.SetMod((VehicleMod) 16, 3, true);
        vehicle.set_PrimaryColor((VehicleColor) 12);
        vehicle.set_SecondaryColor((VehicleColor) 12);
        vehicle.set_WindowTint((VehicleWindowTint) 5);
        vehicle.set_PearlescentColor((VehicleColor) 12);
      }
      if (num1 == 3)
      {
        Model model = Model.op_Implicit("PARAGON2");
        position = ((Entity) Game.get_Player().get_Character()).get_Position();
        Vector3 vector3 = ((Vector3) ref position).Around((float) random.Next(50, 250));
        vehicle = World.CreateVehicle(model, vector3);
        vehicle.PlaceOnNextStreet();
        vehicle.PlaceOnGround();
        Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
        {
          InputArgument.op_Implicit(((Entity) vehicle).get_Handle()),
          InputArgument.op_Implicit(0)
        });
        vehicle.SetMod((VehicleMod) 15, 3, true);
        vehicle.SetMod((VehicleMod) 16, 3, true);
        vehicle.set_PrimaryColor((VehicleColor) 12);
        vehicle.set_SecondaryColor((VehicleColor) 12);
        vehicle.set_WindowTint((VehicleWindowTint) 5);
        vehicle.set_PearlescentColor((VehicleColor) 12);
      }
      this.EnemyVeh.Add(vehicle);
      vehicle.CreatePedOnSeat((VehicleSeat) -1, Model.op_Implicit((PedHash) 1268862154));
      vehicle.CreatePedOnSeat((VehicleSeat) 0, Model.op_Implicit((PedHash) -1251702741));
      ((Entity) vehicle).AddBlip();
      ((Entity) vehicle).get_CurrentBlip().set_Sprite((BlipSprite) 270);
      ((Entity) vehicle).get_CurrentBlip().set_Name("Enemy, " + vehicle.get_FriendlyName());
      this.EnemyAi.Add(vehicle.GetPedOnSeat((VehicleSeat) -1));
      this.EnemyAi.Add(vehicle.GetPedOnSeat((VehicleSeat) 0));
      using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
          {
            int num2 = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
            {
              InputArgument.op_Implicit("HATES_PLAYER")
            });
            Function.Call((Hash) -4032282232082276974L, new InputArgument[2]
            {
              InputArgument.op_Implicit(current),
              InputArgument.op_Implicit(num2)
            });
            Function.Call((Hash) -6955927877681029095L, new InputArgument[3]
            {
              InputArgument.op_Implicit(current),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -6950556924876694540L, new InputArgument[2]
            {
              InputArgument.op_Implicit(current),
              InputArgument.op_Implicit(1)
            });
            current.get_Weapons().Give((WeaponHash) 324215364, 9999, true, true);
            current.get_Task().FightAgainst(Game.get_Player().get_Character());
          }
        }
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

    public void ShowRaceOptions(int L)
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(44),
          InputArgument.op_Implicit(0)
        }),
        (object) "Cancel Race"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 4,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(132),
          InputArgument.op_Implicit(0)
        }),
        (object) ""
      });
      if (L < 3)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 5,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(21),
            InputArgument.op_Implicit(0)
          }),
          (object) (" Bet " + this.RaceBet.ToString("N"))
        });
      if (L >= 3)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 5,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(21),
            InputArgument.op_Implicit(0)
          }),
          (object) ("(No More Bets), Bet " + this.RaceBet.ToString("N"))
        });
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void GameFail(string Reason, string MissionName)
    {
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 30), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 450), 0.0f, Color.FromArgb(230, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 148, 27, 46), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Reason : " + Reason, new Point(int32, 280), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      new Scaleform(0).Render2D();
    }

    public void GamePassed(string MissionName, int Payout)
    {
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 450), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Payout : $" + Payout.ToString("N"), new Point(int32, 300), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      new Scaleform(0).Render2D();
    }

    public void Poker(string Reason, string MissionName)
    {
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 30), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 450), 0.0f, Color.FromArgb(230, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 148, 27, 46), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Reason : " + Reason, new Point(int32, 280), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", new object[0]);
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", new object[0]);
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(22),
          InputArgument.op_Implicit(0)
        }),
        (object) "Begin Assault"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(202),
          InputArgument.op_Implicit(0)
        }),
        (object) "Cancel"
      });
      scaleform.CallFunction("ORBITAL_CANNON_CAM", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    private void OnKeyDown()
    {
      if (this.DeliveryMissionOn && Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null) && (Entity.op_Equality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) this.Plane) && Game.IsControlJustPressed(2, (Control) 51)) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MissionMarker) < 30.0)
      {
        Model model = Model.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit("WEAPON_BRIEFCASE")
        }));
        if (Function.Call<bool>((Hash) 3955096325251305710L, new InputArgument[1]
        {
          InputArgument.op_Implicit(model)
        }) == 0)
        {
          Function.Call((Hash) 6071771004139350467L, new InputArgument[1]
          {
            InputArgument.op_Implicit(model)
          });
          while (true)
          {
            if (Function.Call<bool>((Hash) 3955096325251305710L, new InputArgument[1]
            {
              InputArgument.op_Implicit(model)
            }) == 0)
              Script.Wait(0);
            else
              break;
          }
        }
        World.ShootBullet(((Entity) Game.get_Player().get_Character()).get_Position(), this.MissionMarker, Game.get_Player().get_Character(), model, 15000);
        this.MissionMarker = this.GetLocation(this.DevMission);
        if (this.shipmentsDElivered != 4)
        {
          ++this.shipmentsDElivered;
          UI.Notify("Ron: Ok a shipment has been delivered");
        }
        else
        {
          this.shipmentsDElivered = 0;
          this.DeliveryMissionOn = false;
          UI.Notify("Ron: Ok all shipments have been delivered");
          if (Entity.op_Inequality((Entity) this.Plane, (Entity) null))
          {
            ((Entity) this.Plane).set_IsPersistent(false);
            this.Plane = (Vehicle) null;
          }
          if (Blip.op_Inequality(this.PlaneBlip, (Blip) null))
            this.PlaneBlip.Remove();
          UI.Notify(this.GetHostName() + " : Stocks just Increased");
          UI.Notify("Max Stocks: " + (object) this.maxstocks);
          UI.Notify("Annual Gain: $" + this.increaseGain.ToString("N"));
          UI.Notify("Mission Gain: " + (object) this.profitMargin + "%");
          UI.Notify("Stock Value: $" + this.stocksvalue.ToString("N"));
          this.stocksvalue = (float) ((double) this.stocksvalue + 150000.0 + 150000.0 * (double) this.profitMargin / 100.0);
          this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
          this.Config.Save();
        }
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RaceSTMarker) < 4.0 && Game.IsControlJustPressed(2, (Control) 51))
      {
        this.StartR = false;
        this.inRace = false;
        if (Entity.op_Inequality((Entity) this.VehicleA, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleA).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleB, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleB).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleC, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleC).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleD, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleD).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleE, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleE.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleE).Delete();
        }
        if (Entity.op_Inequality((Entity) this.VehicleF, (Entity) null))
        {
          if (Entity.op_Inequality((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
            ((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1)).Delete();
          ((Entity) this.VehicleF).Delete();
        }
        this.StartedRace = false;
        this.FinishedRace = true;
        this.CheckpointRace = false;
        this.Race = 0;
        this.CarsFinished = 0;
        using (List<Blip>.Enumerator enumerator = this.CheckPointBlips.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            Blip current = enumerator.Current;
            if (Blip.op_Inequality(current, (Blip) null))
              current.Remove();
          }
        }
        this.StartR = true;
        this.StartedRace = false;
        this.CheckpointRace = true;
        this.Race = 1;
        this.VehicleA = World.CreateVehicle(Model.op_Implicit("S80"), new Vector3(1091.919f, 168.433f, 81f), 148f);
        this.VehicleA.CreateRandomPedOnSeat((VehicleSeat) -1);
        this.VehicleB = World.CreateVehicle(Model.op_Implicit("S80"), new Vector3(1094.322f, 166.4783f, 81f), 148f);
        this.VehicleB.CreateRandomPedOnSeat((VehicleSeat) -1);
        this.VehicleC = World.CreateVehicle(Model.op_Implicit("S80"), new Vector3(1097.571f, 164.7228f, 81f), 148f);
        this.VehicleC.CreateRandomPedOnSeat((VehicleSeat) -1);
        this.VehicleD = World.CreateVehicle(Model.op_Implicit("S80"), new Vector3(1100.567f, 162.9368f, 81f), 148f);
        this.VehicleD.CreateRandomPedOnSeat((VehicleSeat) -1);
        this.VehicleE = World.CreateVehicle(Model.op_Implicit("S80"), new Vector3(1103.283f, 161.6521f, 81f), 148f);
        this.VehicleE.CreateRandomPedOnSeat((VehicleSeat) -1);
        this.VehicleF = World.CreateVehicle(Model.op_Implicit("S80"), new Vector3(1105.805f, 160.1064f, 81f), 148f);
        this.VehicleF.CreateRandomPedOnSeat((VehicleSeat) -1);
        this.CheckpointPos.Add(new Vector3(1005f, -72f, 81f));
        this.CheckpointPos.Add(new Vector3(1165f, 24f, 81f));
        this.CheckpointPos.Add(new Vector3(1253f, 267f, 82f));
        this.UpgradeVehicle(this.VehicleA);
        this.UpgradeVehicle(this.VehicleB);
        this.UpgradeVehicle(this.VehicleC);
        this.UpgradeVehicle(this.VehicleD);
        this.UpgradeVehicle(this.VehicleE);
        this.UpgradeVehicle(this.VehicleF);
        this.IsinInterior = false;
        ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(1092.119f, 147.6446f, 82f));
        ((Entity) Game.get_Player().get_Character()).set_Heading(-33f);
        this.RaceMenu.set_Visible(!this.RaceMenu.get_Visible());
        this.RaceCam = World.CreateCamera(new Vector3(1089.806f, 148.7886f, 82f), new Vector3(0.0f, 0.0f, -34f), 100f);
        this.RaceCam.set_IsActive(true);
        this.RaceCam.set_FarClip(2000f);
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        World.set_RenderingCamera(this.RaceCam);
      }
      if (this.Casino_level >= 1 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MembershipUpgradeMarker) < 4.0 && Game.IsControlJustPressed(2, (Control) 51))
        this.Casino_Menu.set_Visible(!this.Casino_Menu.get_Visible());
      for (int index = 0; index < this.DrinkPosPent.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.DrinkPosPent[index]) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
        {
          ((Entity) Game.get_Player().get_Character()).set_Rotation(new Vector3(0.0f, 0.0f, this.DrinkPosRot[index]));
          this.DrinksMenu.set_Visible(!this.DrinksMenu.get_Visible());
        }
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.LuckyWheel) < 3.0)
      {
        Quaternion quaternion;
        if (Game.IsControlJustPressed(2, (Control) 80))
        {
          quaternion = ((Entity) this.WheelProp).get_Quaternion();
          ((Entity) this.BasePlate2).set_Quaternion(Quaternion.RotationYawPitchRoll(((Quaternion) ref quaternion).get_Angle() + 0.01f, 0.0f, 0.0f));
        }
        if (Game.IsControlJustPressed(2, (Control) 58))
        {
          quaternion = ((Entity) this.WheelProp).get_Quaternion();
          ((Entity) this.BasePlate2).set_Quaternion(Quaternion.RotationYawPitchRoll(((Quaternion) ref quaternion).get_Angle() - 0.01f, 0.0f, 0.0f));
        }
        if (Game.IsControlJustPressed(2, (Control) 44))
        {
          quaternion = ((Entity) this.WheelProp).get_Quaternion();
          UI.Notify("ROT y" + (object) ((Quaternion) ref quaternion).get_Angle());
        }
        if (Game.IsControlJustPressed(2, (Control) 51))
        {
          this.isRotating = true;
          this.RMax = new Random().Next(50, 150);
          this.RTimer = 0;
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat1) < 4.0)
      {
        if (!this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat1);
          ((Entity) Game.get_Player().get_Character()).set_Rotation(new Vector3(0.0f, 0.0f, this.J_rot1));
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
          this.PlayAnim(Game.get_Player().get_Character(), 2);
          this.IsinHottub = true;
        }
        else if (this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat1);
          Game.get_Player().get_Character().get_Task().ClearAllImmediately();
          Game.get_Player().get_Character().get_Task().ClearAll();
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
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
          this.IsinHottub = false;
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat7) < 4.0)
      {
        if (!this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat7);
          ((Entity) Game.get_Player().get_Character()).set_Rotation(new Vector3(0.0f, 0.0f, this.J_rot7));
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
          this.PlayAnim(Game.get_Player().get_Character(), 2);
          this.IsinHottub = true;
        }
        else if (this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat7);
          Game.get_Player().get_Character().get_Task().ClearAllImmediately();
          Game.get_Player().get_Character().get_Task().ClearAll();
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
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
          this.IsinHottub = false;
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat8) < 4.0)
      {
        if (!this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat8);
          ((Entity) Game.get_Player().get_Character()).set_Rotation(new Vector3(0.0f, 0.0f, this.J_rot8));
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
          this.PlayAnim(Game.get_Player().get_Character(), 2);
          this.IsinHottub = true;
        }
        else if (this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat8);
          Game.get_Player().get_Character().get_Task().ClearAllImmediately();
          Game.get_Player().get_Character().get_Task().ClearAll();
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
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
          this.IsinHottub = false;
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat9) < 4.0)
      {
        if (!this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat9);
          ((Entity) Game.get_Player().get_Character()).set_Rotation(new Vector3(0.0f, 0.0f, this.J_rot9));
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
          this.PlayAnim(Game.get_Player().get_Character(), 2);
          this.IsinHottub = true;
        }
        else if (this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat9);
          Game.get_Player().get_Character().get_Task().ClearAllImmediately();
          Game.get_Player().get_Character().get_Task().ClearAll();
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
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
          this.IsinHottub = false;
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat10) < 4.0)
      {
        if (!this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat10);
          ((Entity) Game.get_Player().get_Character()).set_Rotation(new Vector3(0.0f, 0.0f, this.J_rot10));
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
          this.PlayAnim(Game.get_Player().get_Character(), 2);
          this.IsinHottub = true;
        }
        else if (this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat10);
          Game.get_Player().get_Character().get_Task().ClearAllImmediately();
          Game.get_Player().get_Character().get_Task().ClearAll();
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
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
          this.IsinHottub = false;
        }
      }
      if (this.Playing_Poker)
      {
        Vector3 offsetInWorldCoords1 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.05f, 0.9f, -0.45f));
        Vector3 offsetInWorldCoords2 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.05f, 0.9f, -0.45f));
        Vector3 offsetInWorldCoords3 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.15f, 0.9f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.15f, 0.9f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.25f, 0.9f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.25f, 0.9f, -0.45f));
        Vector3 offsetInWorldCoords4 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.05f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords5 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.05f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords6 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.15f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.15f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.25f, 0.55f, -0.45f));
        ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.25f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords7 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.45f));
        Vector3 offsetInWorldCoords8 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.7f, -0.45f));
        if (this.Endgame)
        {
          if (Game.IsControlJustPressed(2, (Control) 44))
          {
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Editbet = false;
            this.Placebet = false;
            this.Drawcards = false;
            this.Endgame = false;
            this.Playercards = 0;
            this.DealerCards = 0;
            this.PlayerCard_1 = 0;
            this.PlayerCard_2 = 0;
            this.PlayerCard_3 = 0;
            this.PlayerCard_4 = 0;
            this.PlayerCard_5 = 0;
            this.PlayerCard_6 = 0;
            this.Bet = 0.0f;
            this.DealerCard_1 = 0;
            this.DealerCard_2 = 0;
            this.DealerCard_3 = 0;
            this.DealerCard_4 = 0;
            this.DealerCard_5 = 0;
            this.DealerCard_6 = 0;
          }
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Editbet = false;
            this.Placebet = false;
            this.Drawcards = false;
            this.Endgame = false;
            this.Playercards = 0;
            this.DealerCards = 0;
            this.PlayerCard_1 = 0;
            this.PlayerCard_2 = 0;
            this.PlayerCard_3 = 0;
            this.PlayerCard_4 = 0;
            this.PlayerCard_5 = 0;
            this.PlayerCard_6 = 0;
            this.Bet = 0.0f;
            this.DealerCard_1 = 0;
            this.DealerCard_2 = 0;
            this.DealerCard_3 = 0;
            this.DealerCard_4 = 0;
            this.DealerCard_5 = 0;
            this.DealerCard_6 = 0;
          }
        }
        if (this.Editbet)
        {
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            this.Chips_Amount -= (int) this.Bet;
            this.Config.SetValue<int>("Setup", "Chips_Amount", (M0) this.Chips_Amount);
            this.Config.Save();
            ((Entity) this.PlayerCardA).set_Rotation(new Vector3((float) ((Entity) this.PlayerCardA).get_Rotation().X, 180f, (float) ((Entity) this.PlayerCardA).get_Rotation().Z));
            Script.Wait(200);
            ((Entity) this.PlayerCardB).set_Rotation(new Vector3((float) ((Entity) this.PlayerCardB).get_Rotation().X, 180f, (float) ((Entity) this.PlayerCardB).get_Rotation().Z));
            Script.Wait(200);
            ((Entity) this.PlayerCardC).set_Rotation(new Vector3((float) ((Entity) this.PlayerCardC).get_Rotation().X, 180f, (float) ((Entity) this.PlayerCardC).get_Rotation().Z));
            Script.Wait(1000);
            Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@threecardpoker@ped_male@engaged@01b@reacts@v01", "collect_chips_card_c", 8f, -1, true, -1f);
            ((Entity) this.CardB).set_Rotation(new Vector3((float) ((Entity) this.CardB).get_Rotation().X, 180f, (float) ((Entity) this.CardB).get_Rotation().Z));
            Script.Wait(200);
            ((Entity) this.CardC).set_Rotation(new Vector3((float) ((Entity) this.CardC).get_Rotation().X, 180f, (float) ((Entity) this.CardC).get_Rotation().Z));
            Script.Wait(200);
            ((Entity) this.CardA).set_Rotation(new Vector3((float) ((Entity) this.CardA).get_Rotation().X, 180f, (float) ((Entity) this.CardA).get_Rotation().Z));
            Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@base", "idle_c", 8f, -1, true, -1f);
            for (int index = 0; index < 100; ++index)
            {
              this.GameFail("You Folded", "3 Card Poker");
              Script.Wait(1);
            }
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Editbet = false;
            this.Placebet = false;
            this.Drawcards = false;
            this.Endgame = false;
            this.Playercards = 0;
            this.DealerCards = 0;
            this.PlayerCard_1 = 0;
            this.PlayerCard_2 = 0;
            this.PlayerCard_3 = 0;
            this.PlayerCard_4 = 0;
            this.PlayerCard_5 = 0;
            this.PlayerCard_6 = 0;
            this.Bet = 0.0f;
            this.DealerCard_1 = 0;
            this.DealerCard_2 = 0;
            this.DealerCard_3 = 0;
            this.DealerCard_4 = 0;
            this.DealerCard_5 = 0;
            this.DealerCard_6 = 0;
            Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
          }
          if (Game.IsControlJustPressed(2, (Control) 58))
          {
            try
            {
              UI.Notify("~p~ Dealer ~w~ : Enter an amount to ~b~Increase~w~/~g~Decrease~w~ Bet, Enter ~g~-~w~ to enter a Negative Bet");
              this.Bet += (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(966.9417f, 32.0952f, 115f)) >= 6.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(1146.76f, 248.972f, -51f)) >= 6.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(1131.154f, 265.2554f, -51f)) >= 6.0 ? float.Parse(Game.GetUserInput((WindowTitle) 0, "100000", 5)) : (this.Casino_level < 3 ? float.Parse(Game.GetUserInput((WindowTitle) 0, "100000", 5)) : float.Parse(Game.GetUserInput((WindowTitle) 0, "1000000", 6)));
              UI.Notify("~p~ Dealer ~w~ : Total bet : " + (object) this.Bet + "c");
              if ((double) this.Bet < (double) this.Chips_Amount)
              {
                UI.Notify("Player bet :" + (object) this.Bet);
                this.Placebet = true;
                if ((double) this.Bet <= 10.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_10dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 10.0 && (double) this.Bet <= 60.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_50dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 50.0 && (double) this.Bet <= 100.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_100dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 100.0 && (double) this.Bet <= 500.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_500dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 500.0 && (double) this.Bet <= 1000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_1kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 1000.0 && (double) this.Bet <= 5000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_plaq_5kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 5000.0 && (double) this.Bet <= 10000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_plaq_10kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 10000.0 && (double) this.Bet <= 25000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_plaq_10kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_02a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 25000.0 && (double) this.Bet <= 50000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_02a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 50000.0 && (double) this.Bet <= 150000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 50000.0 && (double) this.Bet <= 150000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.45f));
                  Prop prop3 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords9, true, false);
                  ((Entity) prop3).set_FreezePosition(true);
                  ((Entity) prop3).set_Position(new Vector3((float) ((Entity) prop3).get_Position().X, (float) ((Entity) prop3).get_Position().Y, (float) ((Entity) prop3).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop3);
                  Vector3 offsetInWorldCoords10 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.45f));
                  Prop prop4 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords10, true, false);
                  ((Entity) prop4).set_FreezePosition(true);
                  ((Entity) prop4).set_Position(new Vector3((float) ((Entity) prop4).get_Position().X, (float) ((Entity) prop4).get_Position().Y, (float) ((Entity) prop4).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop4);
                }
                if ((double) this.Bet > 150000.0 && (double) this.Bet < 5000000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.45f));
                  Prop prop3 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords9, true, false);
                  ((Entity) prop3).set_FreezePosition(true);
                  ((Entity) prop3).set_Position(new Vector3((float) ((Entity) prop3).get_Position().X, (float) ((Entity) prop3).get_Position().Y, (float) ((Entity) prop3).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop3);
                  Vector3 offsetInWorldCoords10 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.45f));
                  Prop prop4 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords10, true, false);
                  ((Entity) prop4).set_FreezePosition(true);
                  ((Entity) prop4).set_Position(new Vector3((float) ((Entity) prop4).get_Position().X, (float) ((Entity) prop4).get_Position().Y, (float) ((Entity) prop4).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop4);
                  Vector3 offsetInWorldCoords11 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.4f));
                  Vector3 offsetInWorldCoords12 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.7f, -0.4f));
                  Prop prop5 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords11, true, false);
                  ((Entity) prop5).set_FreezePosition(true);
                  ((Entity) prop5).set_Position(new Vector3((float) ((Entity) prop5).get_Position().X, (float) ((Entity) prop5).get_Position().Y, (float) ((Entity) prop5).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop5);
                  Script.Wait(10);
                  Prop prop6 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords12, true, false);
                  ((Entity) prop6).set_FreezePosition(true);
                  ((Entity) prop6).set_Position(new Vector3((float) ((Entity) prop6).get_Position().X, (float) ((Entity) prop6).get_Position().Y, (float) ((Entity) prop6).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop6);
                  Vector3 offsetInWorldCoords13 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.4f));
                  Prop prop7 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords13, true, false);
                  ((Entity) prop7).set_FreezePosition(true);
                  ((Entity) prop7).set_Position(new Vector3((float) ((Entity) prop7).get_Position().X, (float) ((Entity) prop7).get_Position().Y, (float) ((Entity) prop7).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop7);
                  Vector3 offsetInWorldCoords14 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.4f));
                  Prop prop8 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords14, true, false);
                  ((Entity) prop8).set_FreezePosition(true);
                  ((Entity) prop8).set_Position(new Vector3((float) ((Entity) prop8).get_Position().X, (float) ((Entity) prop8).get_Position().Y, (float) ((Entity) prop8).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop8);
                }
                if ((double) this.Bet > 4999999.0)
                {
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.5f));
                  Prop prop = World.CreateProp(Model.op_Implicit("prop_gold_bar"), offsetInWorldCoords9, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
              }
              if ((double) this.Bet > (double) this.Chips_Amount)
              {
                UI.Notify("you do not have enough chips for this bet");
                this.Placebet = false;
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "place_bet", 8f, -1, true, -1f);
              Script.Wait(1000);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            catch (Exception ex)
            {
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              UI.Notify("Player did not enter a valid bet");
            }
          }
          if (Game.IsControlJustPressed(2, (Control) 44))
          {
            if (this.Playercards == 3)
            {
              UI.Notify("Calculating winner");
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              this.Editbet = false;
              this.Endgame = true;
              this.Placebet = false;
              ((Entity) this.CardA).set_Rotation(new Vector3((float) ((Entity) this.CardA).get_Rotation().X, 180f, (float) ((Entity) this.CardA).get_Rotation().Z));
              ((Entity) this.CardB).set_Rotation(new Vector3((float) ((Entity) this.CardB).get_Rotation().X, 180f, (float) ((Entity) this.CardB).get_Rotation().Z));
              ((Entity) this.CardC).set_Rotation(new Vector3((float) ((Entity) this.CardC).get_Rotation().X, 180f, (float) ((Entity) this.CardC).get_Rotation().Z));
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "place_bet", 8f, -1, true, -1f);
              this.CalculatePoker();
            }
            else
            {
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              UI.Notify("You cannot Accept untill you have a hand of at least 3");
            }
          }
        }
        if (this.Placebet)
        {
          if (Game.IsControlJustPressed(2, (Control) 58))
          {
            if (this.Playercards == 3)
            {
              this.Drawcards = true;
              this.Endgame = false;
              this.Editbet = true;
            }
            else
            {
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "place_bet", 8f, -1, true, -1f);
              UI.Notify("You cannot Accept untill you have a hand of at least 3");
            }
          }
          if (Game.IsControlJustPressed(2, (Control) 44))
          {
            Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "request_card", 8f, -1, true, -1f);
            if (this.Playercards == 0)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_1 = this.Set_PlayerCardPoker(randomCardPlayer, 1);
              ++this.Playercards;
              Prop prop1 = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords4, true, false);
              ((Entity) prop1).set_FreezePosition(true);
              Vector3 position1 = ((Entity) prop1).get_Position();
              this.PlayerCardA = prop1;
              ((Entity) prop1).set_Position(new Vector3((float) position1.X, (float) position1.Y, (float) position1.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop1).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop1);
              Script.Wait(500);
              string randomCardDealer = this.GetRandomCardDealer();
              this.DealerCard_1 = this.Set_DealerCardPoker(randomCardDealer, 1);
              Prop prop2 = World.CreateProp(Model.op_Implicit(randomCardDealer), offsetInWorldCoords3, true, false);
              ((Entity) prop2).set_FreezePosition(true);
              Vector3 position2 = ((Entity) prop2).get_Position();
              this.CardC = prop2;
              ((Entity) prop2).set_Position(new Vector3((float) position2.X, (float) position2.Y, (float) position2.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop2).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop2);
              ((Entity) this.CardC).set_Rotation(new Vector3((float) ((Entity) this.CardC).get_Rotation().X, 180f, (float) ((Entity) this.CardC).get_Rotation().Z));
              Script.Wait(500);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            else if (this.Playercards == 1)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_2 = this.Set_PlayerCardPoker(randomCardPlayer, 2);
              ++this.Playercards;
              Prop prop1 = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords5, true, false);
              ((Entity) prop1).set_FreezePosition(true);
              this.PlayerCardB = prop1;
              Vector3 position1 = ((Entity) prop1).get_Position();
              ((Entity) prop1).set_Position(new Vector3((float) position1.X, (float) position1.Y, (float) position1.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop1).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop1);
              Script.Wait(500);
              string randomCardDealer = this.GetRandomCardDealer();
              this.DealerCard_2 = this.Set_DealerCardPoker(randomCardDealer, 2);
              Prop prop2 = World.CreateProp(Model.op_Implicit(randomCardDealer), offsetInWorldCoords2, true, false);
              ((Entity) prop2).set_FreezePosition(true);
              Vector3 position2 = ((Entity) prop2).get_Position();
              this.CardB = prop2;
              ((Entity) prop2).set_Position(new Vector3((float) position2.X, (float) position2.Y, (float) position2.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop2).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop2);
              ((Entity) this.CardB).set_Rotation(new Vector3((float) ((Entity) this.CardB).get_Rotation().X, 180f, (float) ((Entity) this.CardB).get_Rotation().Z));
              Script.Wait(500);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            else if (this.Playercards == 2)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_3 = this.Set_PlayerCardPoker(randomCardPlayer, 3);
              ++this.Playercards;
              Prop prop1 = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords6, true, false);
              ((Entity) prop1).set_FreezePosition(true);
              this.PlayerCardC = prop1;
              Vector3 position1 = ((Entity) prop1).get_Position();
              ((Entity) prop1).set_Position(new Vector3((float) position1.X, (float) position1.Y, (float) position1.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop1).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop1);
              Script.Wait(500);
              string randomCardDealer = this.GetRandomCardDealer();
              this.DealerCard_3 = this.Set_DealerCardPoker(randomCardDealer, 3);
              Prop prop2 = World.CreateProp(Model.op_Implicit(randomCardDealer), offsetInWorldCoords1, true, false);
              ((Entity) prop2).set_FreezePosition(true);
              Vector3 position2 = ((Entity) prop2).get_Position();
              this.CardA = prop2;
              ((Entity) prop2).set_Position(new Vector3((float) position2.X, (float) position2.Y, (float) position2.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop2).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop2);
              ((Entity) this.CardA).set_Rotation(new Vector3((float) ((Entity) this.CardA).get_Rotation().X, 180f, (float) ((Entity) this.CardA).get_Rotation().Z));
              Script.Wait(500);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            else
              UI.Notify("You cannot pick any more cards");
          }
        }
        if (!this.Placebet)
        {
          if (Game.IsControlJustPressed(2, (Control) 44))
          {
            try
            {
              this.Bet = (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(966.9417f, 32.0952f, 115f)) >= 6.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(1146.76f, 248.972f, -51f)) >= 6.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(1131.154f, 265.2554f, -51f)) >= 6.0 ? float.Parse(Game.GetUserInput((WindowTitle) 0, "100000", 5)) : (this.Casino_level < 3 ? float.Parse(Game.GetUserInput((WindowTitle) 0, "100000", 5)) : float.Parse(Game.GetUserInput((WindowTitle) 0, "1000000", 6)));
              if ((double) this.Bet < (double) this.Chips_Amount)
              {
                UI.Notify("Player bet :" + (object) this.Bet);
                this.Placebet = true;
                if ((double) this.Bet <= 10.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_10dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 10.0 && (double) this.Bet <= 60.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_50dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 50.0 && (double) this.Bet <= 100.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_100dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 100.0 && (double) this.Bet <= 500.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_500dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 500.0 && (double) this.Bet <= 1000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_1kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 1000.0 && (double) this.Bet <= 5000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_plaq_5kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 5000.0 && (double) this.Bet <= 10000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_plaq_10kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 10000.0 && (double) this.Bet <= 25000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_plaq_10kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_02a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 25000.0 && (double) this.Bet <= 50000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_02a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 50000.0 && (double) this.Bet <= 150000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 50000.0 && (double) this.Bet <= 150000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.45f));
                  Prop prop3 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords9, true, false);
                  ((Entity) prop3).set_FreezePosition(true);
                  ((Entity) prop3).set_Position(new Vector3((float) ((Entity) prop3).get_Position().X, (float) ((Entity) prop3).get_Position().Y, (float) ((Entity) prop3).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop3);
                  Vector3 offsetInWorldCoords10 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.45f));
                  Prop prop4 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords10, true, false);
                  ((Entity) prop4).set_FreezePosition(true);
                  ((Entity) prop4).set_Position(new Vector3((float) ((Entity) prop4).get_Position().X, (float) ((Entity) prop4).get_Position().Y, (float) ((Entity) prop4).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop4);
                }
                if ((double) this.Bet > 150000.0 && (double) this.Bet < 5000000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.45f));
                  Prop prop3 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords9, true, false);
                  ((Entity) prop3).set_FreezePosition(true);
                  ((Entity) prop3).set_Position(new Vector3((float) ((Entity) prop3).get_Position().X, (float) ((Entity) prop3).get_Position().Y, (float) ((Entity) prop3).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop3);
                  Vector3 offsetInWorldCoords10 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.45f));
                  Prop prop4 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords10, true, false);
                  ((Entity) prop4).set_FreezePosition(true);
                  ((Entity) prop4).set_Position(new Vector3((float) ((Entity) prop4).get_Position().X, (float) ((Entity) prop4).get_Position().Y, (float) ((Entity) prop4).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop4);
                  Vector3 offsetInWorldCoords11 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.4f));
                  Vector3 offsetInWorldCoords12 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.7f, -0.4f));
                  Prop prop5 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords11, true, false);
                  ((Entity) prop5).set_FreezePosition(true);
                  ((Entity) prop5).set_Position(new Vector3((float) ((Entity) prop5).get_Position().X, (float) ((Entity) prop5).get_Position().Y, (float) ((Entity) prop5).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop5);
                  Script.Wait(10);
                  Prop prop6 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords12, true, false);
                  ((Entity) prop6).set_FreezePosition(true);
                  ((Entity) prop6).set_Position(new Vector3((float) ((Entity) prop6).get_Position().X, (float) ((Entity) prop6).get_Position().Y, (float) ((Entity) prop6).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop6);
                  Vector3 offsetInWorldCoords13 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.4f));
                  Prop prop7 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords13, true, false);
                  ((Entity) prop7).set_FreezePosition(true);
                  ((Entity) prop7).set_Position(new Vector3((float) ((Entity) prop7).get_Position().X, (float) ((Entity) prop7).get_Position().Y, (float) ((Entity) prop7).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop7);
                  Vector3 offsetInWorldCoords14 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.4f));
                  Prop prop8 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords14, true, false);
                  ((Entity) prop8).set_FreezePosition(true);
                  ((Entity) prop8).set_Position(new Vector3((float) ((Entity) prop8).get_Position().X, (float) ((Entity) prop8).get_Position().Y, (float) ((Entity) prop8).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop8);
                }
                if ((double) this.Bet > 4999999.0)
                {
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.5f));
                  Prop prop = World.CreateProp(Model.op_Implicit("prop_gold_bar"), offsetInWorldCoords9, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
              }
              if ((double) this.Bet > (double) this.Chips_Amount)
              {
                UI.Notify("you do not have enough chips for this bet");
                this.Placebet = false;
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "place_bet", 8f, -1, true, -1f);
              Script.Wait(1000);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            catch (Exception ex)
            {
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              UI.Notify("Player did not enter a valid bet");
            }
          }
        }
      }
      for (int index = 0; index < this.PokerTables.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PokerTables[index]) < 2.0)
        {
          if (!this.Playing_Poker && !this.Placebet)
          {
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              ((Entity) Game.get_Player().get_Character()).set_Position(this.PokerTables[index]);
              ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
              ((Entity) Game.get_Player().get_Character()).set_Heading(this.PokerTablesRot[index]);
              this.Editbet = false;
              this.Placebet = false;
              this.Drawcards = false;
              this.Endgame = false;
              this.Playercards = 0;
              this.DealerCards = 0;
              this.PlayerCard_1 = 0;
              this.PlayerCard_2 = 0;
              this.PlayerCard_3 = 0;
              this.PlayerCard_4 = 0;
              this.PlayerCard_5 = 0;
              this.PlayerCard_6 = 0;
              this.Bet = 0.0f;
              this.DealerCard_1 = 0;
              this.DealerCard_2 = 0;
              this.DealerCard_3 = 0;
              this.DealerCard_4 = 0;
              this.DealerCard_5 = 0;
              this.DealerCard_6 = 0;
              this.CurrentTable = index;
              using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  Prop current = enumerator.Current;
                  if (Entity.op_Inequality((Entity) current, (Entity) null))
                    ((Entity) current).Delete();
                }
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              this.Playing_Poker = true;
            }
          }
          else if (this.Playing_Poker && !this.Placebet && Game.IsControlJustPressed(2, (Control) 51))
          {
            this.CurrentTable = index;
            ((Entity) Game.get_Player().get_Character()).set_Position(this.PokerTables[index]);
            ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
            ((Entity) Game.get_Player().get_Character()).set_Heading(this.PokerTablesRot[index]);
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Playing_Poker = false;
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Editbet = false;
            this.Placebet = false;
            this.Drawcards = false;
            this.Endgame = false;
            this.Playercards = 0;
            this.DealerCards = 0;
            this.PlayerCard_1 = 0;
            this.PlayerCard_2 = 0;
            this.PlayerCard_3 = 0;
            this.PlayerCard_4 = 0;
            this.PlayerCard_5 = 0;
            this.PlayerCard_6 = 0;
            this.Bet = 0.0f;
            this.DealerCard_1 = 0;
            this.DealerCard_2 = 0;
            this.DealerCard_3 = 0;
            this.DealerCard_4 = 0;
            this.DealerCard_5 = 0;
            this.DealerCard_6 = 0;
          }
        }
      }
      if (this.Playing_BlackJack)
      {
        Vector3 offsetInWorldCoords1 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.05f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords2 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.05f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords3 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.15f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords4 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.15f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords5 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(-0.25f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords6 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.25f, 0.55f, -0.45f));
        Vector3 offsetInWorldCoords7 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.45f));
        Vector3 offsetInWorldCoords8 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.7f, -0.45f));
        if (this.Endgame && Game.IsControlJustPressed(2, (Control) 44))
        {
          using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Prop current = enumerator.Current;
              if (Entity.op_Inequality((Entity) current, (Entity) null))
                ((Entity) current).Delete();
            }
          }
          this.Placebet = false;
          this.Drawcards = false;
          this.Endgame = false;
          this.Playercards = 0;
          this.DealerCards = 0;
          this.PlayerCard_1 = 0;
          this.PlayerCard_2 = 0;
          this.PlayerCard_3 = 0;
          this.PlayerCard_4 = 0;
          this.PlayerCard_5 = 0;
          this.PlayerCard_6 = 0;
          this.Bet = 0.0f;
          this.DealerCard_1 = 0;
          this.DealerCard_2 = 0;
          this.DealerCard_3 = 0;
          this.DealerCard_4 = 0;
          this.DealerCard_5 = 0;
          this.DealerCard_6 = 0;
        }
        if (this.Placebet)
        {
          if (Game.IsControlJustPressed(2, (Control) 58))
          {
            if (this.Playercards >= 2)
            {
              UI.Notify("~g~Calculating Winner~w~");
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              this.Drawcards = true;
              this.Placebet = false;
              Random random = new Random();
              int num1 = random.Next(0, 2000);
              int num2 = 0;
              if (num1 > 0 && num1 < 100)
                num2 = random.Next(2, 6);
              if (num1 > 100 && num1 < 125)
                num2 = random.Next(2, 5);
              if (num1 > 125 && num1 < 200)
                num2 = random.Next(2, 6);
              if (num1 > 200 && num1 < 350)
                num2 = this.Playercards + random.Next(-1, 2);
              if (num1 > 350 && num1 < 600)
                num2 = this.Playercards + random.Next(-2, 2);
              if (num1 > 600 && num1 < 800)
                num2 = this.Playercards;
              if (num1 > 800 && num1 < 1150)
                num2 = random.Next(13, 28);
              if (num1 > 1150 && num1 < 1350)
                num2 = random.Next(12, 29);
              if (num1 > 1350 && num1 < 1550)
                num2 = random.Next(13, 28);
              if (num1 > 1550 && num1 < 1800)
                num2 = random.Next(14, 27);
              if (num1 > 1800 && num1 < 2000)
                num2 = random.Next(15, 26);
              if (num1 <= 800)
              {
                this.DealerCards = num2;
                for (int index = 1; index <= num2; ++index)
                {
                  string randomCardPlayer = this.GetRandomCardPlayer();
                  if (index == 1)
                    this.DealerCard_1 = this.Set_DealerCard(randomCardPlayer, 1);
                  Script.Wait(100);
                  if (index == 1)
                    this.DealerCard_2 = this.Set_DealerCard(randomCardPlayer, 2);
                  Script.Wait(100);
                  if (index == 1)
                    this.DealerCard_3 = this.Set_DealerCard(randomCardPlayer, 3);
                  Script.Wait(100);
                  if (index == 1)
                    this.DealerCard_4 = this.Set_DealerCard(randomCardPlayer, 4);
                  Script.Wait(100);
                  if (index == 1)
                    this.DealerCard_5 = this.Set_DealerCard(randomCardPlayer, 5);
                  Script.Wait(100);
                  if (index == 1)
                    this.DealerCard_6 = this.Set_DealerCard(randomCardPlayer, 6);
                  Script.Wait(100);
                }
              }
              if (num1 > 800)
              {
                UI.Notify("Dealer");
                int num3 = num2;
                this.DealerCards = num2;
                this.GetRandomCardDealer();
                int num4 = random.Next(1, 4);
                if (num4 == 1)
                {
                  this.DealerCard_1 = 10;
                  UI.Notify("~p~Dealer~w~ got Card : Jack");
                }
                if (num4 == 2)
                {
                  this.DealerCard_1 = 10;
                  UI.Notify("~p~Dealer~w~ got Card : 10");
                }
                if (num4 == 3)
                {
                  this.DealerCard_1 = 10;
                  UI.Notify("~p~Dealer~w~ got Card : Queen");
                }
                if (num4 == 4)
                {
                  this.DealerCard_1 = 10;
                  UI.Notify("~p~Dealer~w~ got Card : King");
                }
                int num5 = num2 - 10;
                int maxValue1 = num3 - num5;
                if ((uint) maxValue1 > 0U)
                {
                  int num6 = random.Next(1, maxValue1);
                  this.DealerCard_2 = num6;
                  UI.Notify("~p~Dealer~w~ got Card : " + (object) num6);
                  num5 = maxValue1 - num6;
                }
                int maxValue2 = num5;
                if ((uint) maxValue2 > 0U)
                {
                  int num6 = random.Next(1, maxValue2);
                  this.DealerCard_3 = num6;
                  UI.Notify("~p~Dealer~w~ got Card : " + (object) num6);
                  num5 = maxValue2 - num6;
                }
                int maxValue3 = num5;
                if ((uint) maxValue3 > 0U)
                {
                  int num6 = random.Next(1, maxValue3);
                  this.DealerCard_4 = num6;
                  UI.Notify("~p~Dealer~w~ got Card : " + (object) num6);
                  num5 = maxValue3 - num6;
                }
                int maxValue4 = num5;
                if ((uint) maxValue4 > 0U)
                {
                  int num6 = random.Next(1, maxValue4);
                  this.DealerCard_5 = num6;
                  UI.Notify("~p~Dealer~w~ got Card : " + (object) num6);
                  num5 = maxValue4 - num6;
                }
                int maxValue5 = num5;
                if ((uint) maxValue5 > 0U)
                {
                  int num6 = random.Next(1, maxValue5);
                  this.DealerCard_6 = num6;
                  UI.Notify("~p~Dealer~w~ got Card : " + (object) num6);
                  int num7 = maxValue5 - num6;
                }
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              this.CalculateBlackJack();
              this.Drawcards = false;
              this.Endgame = true;
            }
            else
            {
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              UI.Notify("You cannot Accept untill you have a hand of at least 2");
            }
          }
          if (Game.IsControlJustPressed(2, (Control) 44))
          {
            Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "request_card", 8f, -1, true, -1f);
            if (this.Playercards == 0)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_1 = this.Set_PlayerCard(randomCardPlayer, 1);
              ++this.Playercards;
              Prop prop = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords1, true, false);
              ((Entity) prop).set_FreezePosition(true);
              Vector3 position = ((Entity) prop).get_Position();
              this.PlayerCardA = prop;
              ((Entity) prop).set_Position(new Vector3((float) position.X, (float) position.Y, (float) position.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop);
              Script.Wait(500);
            }
            else if (this.Playercards == 1)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_2 = this.Set_PlayerCard(randomCardPlayer, 2);
              ++this.Playercards;
              Prop prop = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords2, true, false);
              ((Entity) prop).set_FreezePosition(true);
              Vector3 position = ((Entity) prop).get_Position();
              this.PlayerCardB = prop;
              ((Entity) prop).set_Position(new Vector3((float) position.X, (float) position.Y, (float) position.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop);
              Script.Wait(500);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            else if (this.Playercards == 2)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_3 = this.Set_PlayerCard(randomCardPlayer, 3);
              ++this.Playercards;
              Prop prop = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords3, true, false);
              ((Entity) prop).set_FreezePosition(true);
              Vector3 position = ((Entity) prop).get_Position();
              this.PlayerCardC = prop;
              ((Entity) prop).set_Position(new Vector3((float) position.X, (float) position.Y, (float) position.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop);
              Script.Wait(500);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            else if (this.Playercards == 3)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_4 = this.Set_PlayerCard(randomCardPlayer, 4);
              ++this.Playercards;
              Prop prop = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords4, true, false);
              ((Entity) prop).set_FreezePosition(true);
              Vector3 position = ((Entity) prop).get_Position();
              this.PlayerCardD = prop;
              ((Entity) prop).set_Position(new Vector3((float) position.X, (float) position.Y, (float) position.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop);
              Script.Wait(500);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            else if (this.Playercards == 4)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_5 = this.Set_PlayerCard(randomCardPlayer, 5);
              ++this.Playercards;
              Prop prop = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords5, true, false);
              ((Entity) prop).set_FreezePosition(true);
              Vector3 position = ((Entity) prop).get_Position();
              this.PlayerCardE = prop;
              ((Entity) prop).set_Position(new Vector3((float) position.X, (float) position.Y, (float) position.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop);
              Script.Wait(500);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
            else if (this.Playercards == 5)
            {
              Script.Wait(800);
              string randomCardPlayer = this.GetRandomCardPlayer();
              this.PlayerCard_6 = this.Set_PlayerCard(randomCardPlayer, 6);
              ++this.Playercards;
              Prop prop = World.CreateProp(Model.op_Implicit(randomCardPlayer), offsetInWorldCoords6, true, false);
              ((Entity) prop).set_FreezePosition(true);
              Vector3 position = ((Entity) prop).get_Position();
              this.PlayerCardF = prop;
              ((Entity) prop).set_Position(new Vector3((float) position.X, (float) position.Y, (float) position.Z - this.GetTableHeight_Cards(this.CurrentTable)));
              ((Entity) prop).set_Heading(((Entity) Game.get_Player().get_Character()).get_Heading());
              this.Chips.Add(prop);
              Script.Wait(500);
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
            }
          }
        }
        if (!this.Placebet)
        {
          if (Game.IsControlJustPressed(2, (Control) 44))
          {
            try
            {
              this.Bet = (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(966.9417f, 32.0952f, 115f)) >= 6.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(1146.76f, 248.972f, -51f)) >= 6.0 && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(1131.154f, 265.2554f, -51f)) >= 6.0 ? float.Parse(Game.GetUserInput((WindowTitle) 0, "100000", 5)) : (this.Casino_level < 3 ? float.Parse(Game.GetUserInput((WindowTitle) 0, "100000", 5)) : float.Parse(Game.GetUserInput((WindowTitle) 0, "1000000", 6)));
              if ((double) this.Bet < (double) this.Chips_Amount)
              {
                UI.Notify("Player bet :" + (object) this.Bet);
                this.Placebet = true;
                if ((double) this.Bet <= 10.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_10dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 10.0 && (double) this.Bet <= 60.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_50dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 50.0 && (double) this.Bet <= 100.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_100dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 100.0 && (double) this.Bet <= 500.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_500dollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                }
                if ((double) this.Bet > 500.0 && (double) this.Bet <= 1000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_chip_1kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 1000.0 && (double) this.Bet <= 5000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_plaq_5kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 5000.0 && (double) this.Bet <= 10000.0)
                {
                  Prop prop = World.CreateProp(Model.op_Implicit("vw_prop_plaq_10kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
                if ((double) this.Bet > 10000.0 && (double) this.Bet <= 25000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_plaq_10kdollar_st"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_02a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 25000.0 && (double) this.Bet <= 50000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_02a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 50000.0 && (double) this.Bet <= 150000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                }
                if ((double) this.Bet > 50000.0 && (double) this.Bet <= 150000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.45f));
                  Prop prop3 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords9, true, false);
                  ((Entity) prop3).set_FreezePosition(true);
                  ((Entity) prop3).set_Position(new Vector3((float) ((Entity) prop3).get_Position().X, (float) ((Entity) prop3).get_Position().Y, (float) ((Entity) prop3).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop3);
                  Vector3 offsetInWorldCoords10 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.45f));
                  Prop prop4 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords10, true, false);
                  ((Entity) prop4).set_FreezePosition(true);
                  ((Entity) prop4).set_Position(new Vector3((float) ((Entity) prop4).get_Position().X, (float) ((Entity) prop4).get_Position().Y, (float) ((Entity) prop4).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop4);
                }
                if ((double) this.Bet > 150000.0 && (double) this.Bet < 5000000.0)
                {
                  Prop prop1 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords7, true, false);
                  ((Entity) prop1).set_FreezePosition(true);
                  ((Entity) prop1).set_Position(new Vector3((float) ((Entity) prop1).get_Position().X, (float) ((Entity) prop1).get_Position().Y, (float) ((Entity) prop1).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop1);
                  Script.Wait(10);
                  Prop prop2 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords8, true, false);
                  ((Entity) prop2).set_FreezePosition(true);
                  ((Entity) prop2).set_Position(new Vector3((float) ((Entity) prop2).get_Position().X, (float) ((Entity) prop2).get_Position().Y, (float) ((Entity) prop2).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop2);
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.45f));
                  Prop prop3 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords9, true, false);
                  ((Entity) prop3).set_FreezePosition(true);
                  ((Entity) prop3).set_Position(new Vector3((float) ((Entity) prop3).get_Position().X, (float) ((Entity) prop3).get_Position().Y, (float) ((Entity) prop3).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop3);
                  Vector3 offsetInWorldCoords10 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.45f));
                  Prop prop4 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords10, true, false);
                  ((Entity) prop4).set_FreezePosition(true);
                  ((Entity) prop4).set_Position(new Vector3((float) ((Entity) prop4).get_Position().X, (float) ((Entity) prop4).get_Position().Y, (float) ((Entity) prop4).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop4);
                  Vector3 offsetInWorldCoords11 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.4f));
                  Vector3 offsetInWorldCoords12 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.7f, -0.4f));
                  Prop prop5 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords11, true, false);
                  ((Entity) prop5).set_FreezePosition(true);
                  ((Entity) prop5).set_Position(new Vector3((float) ((Entity) prop5).get_Position().X, (float) ((Entity) prop5).get_Position().Y, (float) ((Entity) prop5).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop5);
                  Script.Wait(10);
                  Prop prop6 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords12, true, false);
                  ((Entity) prop6).set_FreezePosition(true);
                  ((Entity) prop6).set_Position(new Vector3((float) ((Entity) prop6).get_Position().X, (float) ((Entity) prop6).get_Position().Y, (float) ((Entity) prop6).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop6);
                  Vector3 offsetInWorldCoords13 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.8f, -0.4f));
                  Prop prop7 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords13, true, false);
                  ((Entity) prop7).set_FreezePosition(true);
                  ((Entity) prop7).set_Position(new Vector3((float) ((Entity) prop7).get_Position().X, (float) ((Entity) prop7).get_Position().Y, (float) ((Entity) prop7).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop7);
                  Vector3 offsetInWorldCoords14 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.9f, -0.4f));
                  Prop prop8 = World.CreateProp(Model.op_Implicit("vw_prop_vw_chips_pile_03a"), offsetInWorldCoords14, true, false);
                  ((Entity) prop8).set_FreezePosition(true);
                  ((Entity) prop8).set_Position(new Vector3((float) ((Entity) prop8).get_Position().X, (float) ((Entity) prop8).get_Position().Y, (float) ((Entity) prop8).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop8);
                }
                if ((double) this.Bet > 4999999.0)
                {
                  Vector3 offsetInWorldCoords9 = ((Entity) Game.get_Player().get_Character()).GetOffsetInWorldCoords(new Vector3(0.4f, 0.6f, -0.5f));
                  Prop prop = World.CreateProp(Model.op_Implicit("prop_gold_bar"), offsetInWorldCoords9, true, false);
                  ((Entity) prop).set_FreezePosition(true);
                  ((Entity) prop).set_Position(new Vector3((float) ((Entity) prop).get_Position().X, (float) ((Entity) prop).get_Position().Y, (float) ((Entity) prop).get_Position().Z + this.GetTableHeight_Chips(this.CurrentTable)));
                  this.Chips.Add(prop);
                  Script.Wait(10);
                }
              }
              if ((double) this.Bet > (double) this.Chips_Amount)
              {
                UI.Notify("you do not have enough chips for this bet");
                this.Placebet = false;
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@engaged@01a@play@v02", "place_bet", 8f, -1, true, -1f);
            }
            catch (Exception ex)
            {
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              UI.Notify("Player did not enter a valid bet");
            }
          }
        }
      }
      for (int index = 0; index < this.BlackJackTables.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BlackJackTables[index]) < 2.0)
        {
          if (!this.Playing_BlackJack && !this.Placebet)
          {
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              this.CurrentTable = index;
              ((Entity) Game.get_Player().get_Character()).set_Position(this.BlackJackTables[index]);
              ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
              ((Entity) Game.get_Player().get_Character()).set_Heading(this.BlackJackRot[index]);
              this.Placebet = false;
              this.Drawcards = false;
              this.Endgame = false;
              this.Playercards = 0;
              this.DealerCards = 0;
              this.PlayerCard_1 = 0;
              this.PlayerCard_2 = 0;
              this.PlayerCard_3 = 0;
              this.PlayerCard_4 = 0;
              this.PlayerCard_5 = 0;
              this.PlayerCard_6 = 0;
              this.Bet = 0.0f;
              this.DealerCard_1 = 0;
              this.DealerCard_2 = 0;
              this.DealerCard_3 = 0;
              this.DealerCard_4 = 0;
              this.DealerCard_5 = 0;
              this.DealerCard_6 = 0;
              using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  Prop current = enumerator.Current;
                  if (Entity.op_Inequality((Entity) current, (Entity) null))
                    ((Entity) current).Delete();
                }
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              this.Playing_BlackJack = true;
            }
          }
          else if (this.Playing_BlackJack && !this.Placebet && Game.IsControlJustPressed(2, (Control) 51))
          {
            this.CurrentTable = index;
            ((Entity) Game.get_Player().get_Character()).set_Position(this.BlackJackTables[index]);
            ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
            ((Entity) Game.get_Player().get_Character()).set_Heading(this.BlackJackRot[index]);
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Playing_BlackJack = false;
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Placebet = false;
            this.Drawcards = false;
            this.Endgame = false;
            this.Playercards = 0;
            this.DealerCards = 0;
            this.PlayerCard_1 = 0;
            this.PlayerCard_2 = 0;
            this.PlayerCard_3 = 0;
            this.PlayerCard_4 = 0;
            this.PlayerCard_5 = 0;
            this.PlayerCard_6 = 0;
            this.Bet = 0.0f;
            this.DealerCard_1 = 0;
            this.DealerCard_2 = 0;
            this.DealerCard_3 = 0;
            this.DealerCard_4 = 0;
            this.DealerCard_5 = 0;
            this.DealerCard_6 = 0;
          }
        }
      }
      for (int index = 0; index < this.RouletteTables.Count; ++index)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RouletteTables[index]) < 2.0)
        {
          if (!this.Playing_Roulette && !this.Placebet)
          {
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              ((Entity) Game.get_Player().get_Character()).set_Position(this.RouletteTables[index]);
              ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
              ((Entity) Game.get_Player().get_Character()).set_Heading(this.RouletteTablesRot[index]);
              this.Editbet = false;
              this.Placebet = false;
              this.Drawcards = false;
              this.TableT = (Prop) null;
              this.Endgame = false;
              this.CreatedMarker = false;
              this.PlaceBet_R = false;
              this.Playercards = 0;
              this.DealerCards = 0;
              this.PlayerCard_1 = 0;
              this.PlayerCard_2 = 0;
              this.PlayerCard_3 = 0;
              this.PlayerCard_4 = 0;
              this.PlayerCard_5 = 0;
              this.PlayerCard_6 = 0;
              this.Bet = 0.0f;
              this.DealerCard_1 = 0;
              this.DealerCard_2 = 0;
              this.DealerCard_3 = 0;
              this.DealerCard_4 = 0;
              this.DealerCard_5 = 0;
              this.DealerCard_6 = 0;
              this.CurrentTable = index;
              this.BetPos = "None";
              this.BetPosNum = 0;
              this.MarkerNum = 0;
              if (Entity.op_Inequality((Entity) this.RouletteMarker2, (Entity) null))
                ((Entity) this.RouletteMarker2).Delete();
              if (Entity.op_Inequality((Entity) this.RouletteMarker1, (Entity) null))
                ((Entity) this.RouletteMarker1).Delete();
              if (Entity.op_Inequality((Entity) this.RouletteMarker, (Entity) null))
                ((Entity) this.RouletteMarker).Delete();
              this.MarkerNum = 0;
              this.RouletteBet1 = 0.0f;
              this.RouletteBet2 = 0.0f;
              this.RouletteBet3 = 0.0f;
              using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  Prop current = enumerator.Current;
                  if (Entity.op_Inequality((Entity) current, (Entity) null))
                    ((Entity) current).Delete();
                }
              }
              Game.get_Player().get_Character().get_Task().PlayAnimation("anim_casino_b@amb@casino@games@blackjack@ped_male@regular@02b@base", "base", 8f, -1, true, -1f);
              this.Playing_Roulette = true;
            }
          }
          else if (this.Playing_Roulette && !this.Placebet && Game.IsControlJustPressed(2, (Control) 51))
          {
            this.TableT = (Prop) null;
            this.CurrentTable = index;
            ((Entity) Game.get_Player().get_Character()).set_Position(this.RouletteTables[index]);
            ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
            this.CreatedMarker = false;
            ((Entity) Game.get_Player().get_Character()).set_Heading(this.RouletteTablesRot[index]);
            this.PlaceBet_R = false;
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            if (Entity.op_Inequality((Entity) this.RouletteMarker2, (Entity) null))
              ((Entity) this.RouletteMarker2).Delete();
            if (Entity.op_Inequality((Entity) this.RouletteMarker1, (Entity) null))
              ((Entity) this.RouletteMarker1).Delete();
            if (Entity.op_Inequality((Entity) this.RouletteMarker, (Entity) null))
              ((Entity) this.RouletteMarker).Delete();
            this.BetPos = "None";
            this.MarkerNum = 0;
            this.BetPosNum = 0;
            this.RouletteBet1 = 0.0f;
            this.RouletteBet2 = 0.0f;
            this.RouletteBet3 = 0.0f;
            this.Playing_Roulette = false;
            using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
            this.Editbet = false;
            this.Placebet = false;
            this.Drawcards = false;
            this.Endgame = false;
            this.Playercards = 0;
            this.DealerCards = 0;
            this.PlayerCard_1 = 0;
            this.PlayerCard_2 = 0;
            this.PlayerCard_3 = 0;
            this.PlayerCard_4 = 0;
            this.PlayerCard_5 = 0;
            this.PlayerCard_6 = 0;
            this.Bet = 0.0f;
            this.DealerCard_1 = 0;
            this.DealerCard_2 = 0;
            this.DealerCard_3 = 0;
            this.DealerCard_4 = 0;
            this.DealerCard_5 = 0;
            this.DealerCard_6 = 0;
          }
        }
      }
      if (this.Playing_BlackJack || this.Playing_Poker)
      {
        for (int index = 0; index < this.Tables.Count; ++index)
        {
          if (Entity.op_Inequality((Entity) this.Tables[index], (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.Tables[index]).get_Position()) < 3.0)
          {
            Vector3 offsetInWorldCoords1 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(0.39f, -0.18f, 0.95f));
            Vector3 offsetInWorldCoords2 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(0.29f, -0.22f, 0.95f));
            Vector3 offsetInWorldCoords3 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(0.19f, -0.25f, 0.95f));
            Vector3 offsetInWorldCoords4 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(0.16f, -0.15f, 0.95f));
            Vector3 offsetInWorldCoords5 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(0.24f, -0.11f, 0.95f));
            Vector3 offsetInWorldCoords6 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(0.35f, -0.08f, 0.95f));
            Vector3 offsetInWorldCoords7 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(0.15f, 0.13f, 0.95f));
            Vector3 offsetInWorldCoords8 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(0.0f, 0.1f, 0.95f));
            Vector3 offsetInWorldCoords9 = ((Entity) this.Tables[index]).GetOffsetInWorldCoords(new Vector3(-0.15f, 0.13f, 0.95f));
            if (Entity.op_Inequality((Entity) this.PlayerCardA, (Entity) null))
              ((Entity) this.PlayerCardA).set_Position(offsetInWorldCoords3);
            if (Entity.op_Inequality((Entity) this.PlayerCardB, (Entity) null))
              ((Entity) this.PlayerCardB).set_Position(offsetInWorldCoords2);
            if (Entity.op_Inequality((Entity) this.PlayerCardC, (Entity) null))
              ((Entity) this.PlayerCardC).set_Position(offsetInWorldCoords1);
            if (Entity.op_Inequality((Entity) this.PlayerCardD, (Entity) null))
              ((Entity) this.PlayerCardD).set_Position(offsetInWorldCoords4);
            if (Entity.op_Inequality((Entity) this.PlayerCardE, (Entity) null))
              ((Entity) this.PlayerCardE).set_Position(offsetInWorldCoords5);
            if (Entity.op_Inequality((Entity) this.PlayerCardF, (Entity) null))
              ((Entity) this.PlayerCardF).set_Position(offsetInWorldCoords6);
            if (Entity.op_Inequality((Entity) this.CardA, (Entity) null))
            {
              ((Entity) this.CardA).set_Position(offsetInWorldCoords7);
              ((Entity) this.CardA).set_Rotation(new Vector3((float) ((Entity) this.CardA).get_Rotation().X, (float) ((Entity) this.CardA).get_Rotation().Y, (float) (((Entity) this.Tables[index]).get_Rotation().Z + 20.0)));
            }
            if (Entity.op_Inequality((Entity) this.CardB, (Entity) null))
            {
              ((Entity) this.CardB).set_Position(offsetInWorldCoords8);
              ((Entity) this.CardB).set_Rotation(new Vector3((float) ((Entity) this.CardB).get_Rotation().X, (float) ((Entity) this.CardB).get_Rotation().Y, (float) ((Entity) this.Tables[index]).get_Rotation().Z));
            }
            if (Entity.op_Inequality((Entity) this.CardC, (Entity) null))
            {
              ((Entity) this.CardC).set_Position(offsetInWorldCoords9);
              ((Entity) this.CardC).set_Rotation(new Vector3((float) ((Entity) this.CardC).get_Rotation().X, (float) ((Entity) this.CardC).get_Rotation().Y, (float) (((Entity) this.Tables[index]).get_Rotation().Z - 20.0)));
            }
          }
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseUpgradeMarker) < 3.0 && this.Casino_level >= 3)
        this.Pent_Menu.set_Visible(!this.Pent_Menu.get_Visible());
      if (this.Casino_level >= 3 && Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageEnt) < 3.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        Script.Wait(300);
        Game.FadeScreenIn(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(808f, 808f, 808f));
        Script.Wait(1);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.GarageExit);
        this.IsinInterior = false;
      }
      if (this.Casino_level >= 3)
      {
        if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(938.8819f, -1.1f, 110f)) < 3.0)
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(974.8987f, 12.62897f, 80f));
          Script.Wait(1);
          Script.Wait(300);
          Game.FadeScreenIn(300);
        }
        if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(974.8987f, 12.62897f, 80f)) < 3.0)
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(938.8819f, -1.1f, 110f));
          Script.Wait(300);
          Game.FadeScreenIn(300);
        }
      }
      if (this.Casino_level >= 3)
      {
        if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageExit) < 3.0)
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(404f, 404f, 404f));
          Script.Wait(1);
          ((Entity) Game.get_Player().get_Character()).set_Position(this.GarageEnt);
          Script.Wait(300);
          Game.FadeScreenIn(300);
          this.IsinInterior = true;
        }
        if (Game.IsControlJustPressed(2, (Control) 44) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageExit) < 3.0)
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(404f, 404f, 404f));
          Script.Wait(1);
          ((Entity) Game.get_Player().get_Character()).set_Position(this.PenthouseEnter3);
          Script.Wait(300);
          Game.FadeScreenIn(300);
          this.IsinInterior = true;
        }
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChipsPurchaseMarker) < 3.0)
      {
        this.Show_EQ("   Current Cash :   " + Game.get_Player().get_Money().ToString("N") + "   ", "    Current Chips :" + this.Chips_Amount.ToString("N") + "    ");
        if (Game.IsControlJustPressed(2, (Control) 51))
          this.ChipsMenu.set_Visible(!this.ChipsMenu.get_Visible());
      }
      if (this.Casino_level >= 3 && Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter2) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.PenthouseExit2);
        Script.Wait(300);
        Game.FadeScreenIn(300);
        this.IsinInterior = true;
      }
      if (this.Casino_level >= 3)
      {
        if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter3) < 2.0)
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          ((Entity) Game.get_Player().get_Character()).set_Position(this.PenthouseExit2);
          Script.Wait(300);
          Game.FadeScreenIn(300);
          this.IsinInterior = true;
        }
        if (Game.IsControlJustPressed(2, (Control) 44) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter3) < 3.0)
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          Script.Wait(300);
          Game.FadeScreenIn(300);
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(808f, 808f, 808f));
          Script.Wait(1);
          ((Entity) Game.get_Player().get_Character()).set_Position(this.GarageExit);
          this.IsinInterior = false;
        }
      }
      if (this.Casino_level >= 3)
      {
        if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseExit2) < 2.0)
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          ((Entity) Game.get_Player().get_Character()).set_Position(this.PenthouseEnter2);
          Script.Wait(300);
          Game.FadeScreenIn(300);
          this.IsinInterior = false;
        }
        if (Game.IsControlJustPressed(2, (Control) 44) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseExit2) < 2.0)
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          ((Entity) Game.get_Player().get_Character()).set_Position(this.PenthouseEnter3);
          Script.Wait(300);
          Game.FadeScreenIn(300);
          this.IsinInterior = true;
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopEntA) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RooftopExitA);
        Script.Wait(300);
        Game.FadeScreenIn(300);
        this.IsinInterior = false;
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopExitA) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RooftopEntA);
        Script.Wait(300);
        Game.FadeScreenIn(300);
        this.IsinInterior = true;
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopEntB) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RooftopExitB);
        Script.Wait(300);
        Game.FadeScreenIn(300);
        this.IsinInterior = false;
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RooftopExitB) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.RooftopEntB);
        Script.Wait(300);
        Game.FadeScreenIn(300);
        this.IsinInterior = false;
      }
      if (this.Casino_level >= 3 && Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseEnter) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.PenthouseExit);
        Script.Wait(300);
        Game.FadeScreenIn(300);
        this.IsinInterior = true;
      }
      if (this.Casino_level >= 3 && Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.PenthouseExit) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.PenthouseEnter);
        Script.Wait(300);
        Game.FadeScreenIn(300);
        this.IsinInterior = false;
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && this.IsinInterior)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.EnterMarkerA) < 2.0)
          this.IsinInterior = false;
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.EnterMarkerB) < 2.0)
          this.IsinInterior = false;
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.EnterMarkerC) < 2.0)
          this.IsinInterior = false;
      }
      if (this.Missionnum == 13 && Game.IsControlJustPressed(2, (Control) 51))
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(213f, -936f, 24f)) < 3.0)
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(227f, -1001f, -99f));
        else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(227f, -1001f, -99f)) < 4.0)
        {
          if (Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
          {
            ((Entity) Game.get_Player().get_Character().get_CurrentVehicle()).set_Position(new Vector3(213f, -936f, 24f));
            ((Entity) Game.get_Player().get_Character().get_CurrentVehicle()).set_Rotation(new Vector3(0.0f, 0.0f, -34f));
            Game.get_Player().set_WantedLevel(2);
          }
          else
            ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(213f, -936f, 24f));
        }
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageMenuPos) < 3.0 && Game.IsControlJustPressed(2, (Control) 51))
      {
        this.IsinGarageMenu = true;
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
        this.Garage.set_Visible(!this.Garage.get_Visible());
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MarkerEnter) < 3.0)
      {
        if (Game.IsControlJustPressed(2, (Control) 51))
        {
          Script.Wait(100);
          if (this.purchaselvl == 0)
            this.Casino_Menu.set_Visible(!this.Casino_Menu.get_Visible());
          else if (this.purchaselvl >= 0)
          {
            if (Game.get_Player().get_WantedLevel() < 1)
            {
              Game.FadeScreenOut(300);
              Script.Wait(300);
              Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
              {
                InputArgument.op_Implicit(this.Design)
              });
              int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
              {
                InputArgument.op_Implicit(-75.8466),
                InputArgument.op_Implicit(-826.9893),
                InputArgument.op_Implicit(243.3859)
              });
              Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
              {
                InputArgument.op_Implicit(num)
              });
              ((Entity) Game.get_Player().get_Character()).set_Position(this.MarkerExit);
              Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
              {
                InputArgument.op_Implicit(num)
              });
              Script.Wait(300);
              Game.FadeScreenIn(300);
              this.IsinInterior = true;
            }
            else
            {
              this.DisplayHelpTextThisFrame("Lose the cops");
              UI.Notify(this.GetHostName() + " : Please lose the cops boss");
            }
          }
        }
      }
      else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MarkerExit) < 2.0)
      {
        if (Game.IsControlJustPressed(2, (Control) 51))
        {
          Game.FadeScreenOut(300);
          Script.Wait(300);
          Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
          {
            InputArgument.op_Implicit(this.Design)
          });
          Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
          {
            InputArgument.op_Implicit((int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
            {
              InputArgument.op_Implicit(-141.392),
              InputArgument.op_Implicit(-621.0451),
              InputArgument.op_Implicit(168.8204)
            }))
          });
          ((Entity) Game.get_Player().get_Character()).set_Position(this.MarkerEnter);
          Script.Wait(300);
          Game.FadeScreenIn(300);
          this.IsinInterior = false;
        }
      }
      else if (this.Casino_level >= 2)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChairPos) < 2.0)
        {
          if (this.IsSittinginCeoSeat)
          {
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              this.LoadIniFile("scripts//DC&R//Casino.ini");
              this.Dis_Unlocked = (int) this.Config.GetValue<int>("Setup", "Dis_Unlocked", (M0) this.Dis_Unlocked);
              if (this.Dis_Unlocked == 1)
                this.TDMPrice = 75000000;
              if (this.Dis_Unlocked == 0)
                this.TDMPrice = 200000000;
              this.modMenuPool.RefreshIndex();
              this.MainStuffMenu.set_Visible(!this.MainStuffMenu.get_Visible());
            }
            if (Game.IsControlJustPressed(2, (Control) 44))
            {
              this.modMenuPool.CloseAllMenus();
              this.IsSittinginCeoSeat = false;
              ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
              Game.FadeScreenOut(500);
              Script.Wait(500);
              ((Entity) Game.get_Player().get_Character()).set_Position(this.ChairPos);
              ((Entity) Game.get_Player().get_Character()).set_Heading(this.P_Rotation);
              Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
              {
                InputArgument.op_Implicit(0.0f)
              });
              Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
              {
                InputArgument.op_Implicit(0.0f)
              });
              Game.get_Player().get_Character().get_Task().ClearAnimation("anim@amb@office@laptops@male@var_c@base@", "base");
              ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
              Script.Wait(500);
              Game.FadeScreenIn(500);
            }
          }
          else if (!this.IsSittinginCeoSeat && Game.IsControlJustPressed(2, (Control) 44))
          {
            this.IsSittinginCeoSeat = true;
            Game.FadeScreenOut(500);
            Script.Wait(500);
            ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
            ((Entity) Game.get_Player().get_Character()).set_Position(this.ChairPos);
            ((Entity) Game.get_Player().get_Character()).set_Heading(this.P_Rotation);
            Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
            {
              InputArgument.op_Implicit(0.0f)
            });
            Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
            {
              InputArgument.op_Implicit(0.0f)
            });
            Game.get_Player().get_Character().get_Task().PlayAnimation("anim@amb@office@laptops@male@var_c@base@", "base", 8f, -1, true, -1f);
            Script.Wait(500);
            Game.FadeScreenIn(500);
            this.IsinInterior = true;
          }
        }
        else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageMarker) < 2.0)
        {
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            Game.FadeScreenOut(300);
            Script.Wait(300);
            ((Entity) Game.get_Player().get_Character()).set_Position(this.RoofEnterMarker);
            Script.Wait(300);
            Game.FadeScreenIn(300);
            this.IsinInterior = true;
          }
        }
        else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RoofExitMarker) < 2.0)
        {
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            Game.FadeScreenOut(300);
            Script.Wait(300);
            Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
            {
              InputArgument.op_Implicit(this.Design)
            });
            Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
            {
              InputArgument.op_Implicit((int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
              {
                InputArgument.op_Implicit(-75.8466),
                InputArgument.op_Implicit(-826.9893),
                InputArgument.op_Implicit(243.3859)
              }))
            });
            ((Entity) Game.get_Player().get_Character()).set_Position(this.RoofEnterMarker);
            Script.Wait(300);
            Game.FadeScreenIn(300);
            this.IsinInterior = true;
          }
        }
        else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.RoofEnterMarker) < 2.0)
        {
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            Game.FadeScreenOut(300);
            Script.Wait(300);
            ((Entity) Game.get_Player().get_Character()).set_Position(this.RoofExitMarker);
            Script.Wait(300);
            Game.FadeScreenIn(300);
            this.IsinInterior = false;
          }
          if (Game.IsControlJustPressed(2, (Control) 44))
          {
            Game.FadeScreenOut(300);
            Script.Wait(300);
            ((Entity) Game.get_Player().get_Character()).set_Position(this.GarageMarker);
            Script.Wait(300);
            Game.FadeScreenIn(300);
            this.IsinInterior = false;
          }
        }
        else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.GarageMarker) < 2.0)
        {
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            Game.FadeScreenOut(300);
            Script.Wait(300);
            Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
            {
              InputArgument.op_Implicit(this.Design)
            });
            int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
            {
              InputArgument.op_Implicit(-75.8466),
              InputArgument.op_Implicit(-826.9893),
              InputArgument.op_Implicit(243.3859)
            });
            ((Entity) Game.get_Player().get_Character()).set_Position(this.MarkerExit);
            Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
            {
              InputArgument.op_Implicit(num)
            });
            ((Entity) Game.get_Player().get_Character()).set_Position(this.RoofEnterMarker);
            Script.Wait(300);
            Game.FadeScreenIn(300);
            this.IsinInterior = true;
          }
        }
        else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SleepPos) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
        {
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
          Game.FadeScreenOut(500);
          Script.Wait(500);
          Function.Call((Hash) -3978201909929952453L, new InputArgument[3]
          {
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0)
          });
          Game.get_Player().set_WantedLevel(0);
          Function.Call((Hash) -8078852494817208297L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character())
          });
          Function.Call((Hash) -7173663049392046466L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character())
          });
          ((Entity) Game.get_Player().get_Character()).set_Position(this.SleepPos);
          ((Entity) Game.get_Player().get_Character()).set_Heading(248.15f);
          Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
          {
            InputArgument.op_Implicit(0.0f)
          });
          Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
          {
            InputArgument.op_Implicit(0.0f)
          });
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
          Script.Wait(1500);
          Game.FadeScreenIn(500);
          this.IsinInterior = true;
        }
      }
      if (this.Casino_level < 3 || !Entity.op_Inequality((Entity) this.Chair, (Entity) null) || (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(977.4432f, 48.20891f, 115.25f)) >= 3.0)
        return;
      if (this.IsSittinginCeoSeat2)
      {
        if (Game.IsControlJustPressed(2, (Control) 51))
        {
          this.LoadIniFile("scripts//DC&R//Casino.ini");
          if (this.Dis_Unlocked == 1)
            this.TDMPrice = 75000000;
          if (this.Dis_Unlocked == 0)
            this.TDMPrice = 200000000;
          this.modMenuPool.RefreshIndex();
          this.MainStuffMenu.set_Visible(!this.MainStuffMenu.get_Visible());
        }
        if (Game.IsControlJustPressed(2, (Control) 44))
        {
          this.modMenuPool.CloseAllMenus();
          this.IsSittinginCeoSeat2 = false;
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
          Game.FadeScreenOut(500);
          Script.Wait(500);
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(977.4432f, 48.20891f, 115.1f));
          ((Entity) Game.get_Player().get_Character()).set_Heading(178f);
          Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
          {
            InputArgument.op_Implicit(0.0f)
          });
          Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
          {
            InputArgument.op_Implicit(0.0f)
          });
          Game.get_Player().get_Character().get_Task().ClearAnimation("anim@amb@office@laptops@male@var_c@base@", "base");
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
          Script.Wait(500);
          Game.FadeScreenIn(500);
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(977.4432f, 48.20891f, 115.1f));
        }
      }
      if (!this.IsSittinginCeoSeat2 && Game.IsControlJustPressed(2, (Control) 44))
      {
        this.IsSittinginCeoSeat2 = true;
        Game.FadeScreenOut(500);
        Script.Wait(500);
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
        ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(977.4432f, 48.20891f, 114.8f));
        ((Entity) Game.get_Player().get_Character()).set_Heading(178f);
        Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Game.get_Player().get_Character().get_Task().PlayAnimation("anim@amb@office@laptops@male@var_c@base@", "base", 8f, -1, true, -1f);
        Script.Wait(500);
        Game.FadeScreenIn(500);
      }
    }

    protected virtual void Dispose(bool A_0)
    {
      if (!A_0)
        return;
      if (Entity.op_Inequality((Entity) this.TargetPed, (Entity) null))
        ((Entity) this.TargetPed).Delete();
      if (Entity.op_Inequality((Entity) this.Avery, (Entity) null))
        ((Entity) this.Avery).Delete();
      if (Entity.op_Inequality((Entity) this.Pilot, (Entity) null))
        ((Entity) this.Pilot).Delete();
      if (Entity.op_Inequality((Entity) this.EscapeHeli, (Entity) null))
        ((Entity) this.EscapeHeli).Delete();
      if (Entity.op_Inequality((Entity) this.PatrolCar, (Entity) null))
        ((Entity) this.PatrolCar).Delete();
      using (List<Ped>.Enumerator enumerator = this.Guard.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Camera.op_Inequality(this.ArtPropCam, (Camera) null))
      {
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.ArtPropCam.set_IsActive(false);
        this.ArtPropCam.Destroy();
      }
      if (Entity.op_Inequality((Entity) this.CurrentArtProp, (Entity) null))
        ((Entity) this.CurrentArtProp).Delete();
      using (List<Prop>.Enumerator enumerator = this.ArtProps.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Vehicle>.Enumerator enumerator = this.EnemyVeh.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Vehicle current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Ped>.Enumerator enumerator = this.EnemyAi.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality((Entity) this.RouletteMarker2, (Entity) null))
        ((Entity) this.RouletteMarker2).Delete();
      if (Entity.op_Inequality((Entity) this.RouletteMarker1, (Entity) null))
        ((Entity) this.RouletteMarker1).Delete();
      if (Entity.op_Inequality((Entity) this.RouletteMarker, (Entity) null))
        ((Entity) this.RouletteMarker).Delete();
      if (Entity.op_Inequality((Entity) this.Plane, (Entity) null))
        ((Entity) this.Plane).Delete();
      if (Blip.op_Inequality(this.PlaneBlip, (Blip) null))
        this.PlaneBlip.Remove();
      if (Blip.op_Inequality(this.LocationBlip, (Blip) null))
        this.LocationBlip.Remove();
      if (Entity.op_Inequality((Entity) this.BasePlate2, (Entity) null))
        ((Entity) this.BasePlate2).Delete();
      if (Entity.op_Inequality((Entity) this.BasePlate, (Entity) null))
        ((Entity) this.BasePlate).Delete();
      if (Entity.op_Inequality((Entity) this.VIPBlocker, (Entity) null))
        ((Entity) this.VIPBlocker).Delete();
      if (Camera.op_Inequality(this.RaceCam, (Camera) null))
      {
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.RaceCam.set_IsActive(false);
        this.RaceCam.Destroy();
      }
      using (List<Blip>.Enumerator enumerator = this.CheckPointBlips.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Blip current = enumerator.Current;
          if (Blip.op_Inequality(current, (Blip) null))
            current.Remove();
        }
      }
      if (Entity.op_Inequality((Entity) this.VehicleA, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleA.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleA).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleB, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleB.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleB).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleC, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleC.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleC).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleD, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleD).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleE, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleD.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleE.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleE).Delete();
      }
      if (Entity.op_Inequality((Entity) this.VehicleF, (Entity) null))
      {
        if (Entity.op_Inequality((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
          ((Entity) this.VehicleF.GetPedOnSeat((VehicleSeat) -1)).Delete();
        ((Entity) this.VehicleF).Delete();
      }
      if (Blip.op_Inequality(this.FinishLineBLip, (Blip) null))
        this.FinishLineBLip.Remove();
      if (Blip.op_Inequality(this.RaceBlip, (Blip) null))
        this.RaceBlip.Remove();
      if (Entity.op_Inequality((Entity) this.WheelProp2, (Entity) null))
        ((Entity) this.WheelProp2).Delete();
      if (Entity.op_Inequality((Entity) this.WheelProp, (Entity) null))
        ((Entity) this.WheelProp).Delete();
      if (Entity.op_Inequality((Entity) this.Vendor1, (Entity) null))
        ((Entity) this.Vendor1).Delete();
      if (Entity.op_Inequality((Entity) this.Vendor2, (Entity) null))
        ((Entity) this.Vendor2).Delete();
      using (List<Ped>.Enumerator enumerator = this.MainPed.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Ped>.Enumerator enumerator = this.Peds2.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality((Entity) this.AirVehicle, (Entity) null) && Entity.op_Equality((Entity) this.AirVehicle.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
        ((Entity) this.AirVehicle).Delete();
      if (Entity.op_Inequality((Entity) this.Computer, (Entity) null))
      {
        if (this.IsinInterior)
          this.SpawnProp("ex_prop_monitor_01_ex", this.ComputerPos, ((Entity) this.Computer).get_Rotation());
        if (this.IsinInterior)
          ;
        ((Entity) this.Computer).Delete();
      }
      if (Entity.op_Inequality((Entity) this.AssistantPed, (Entity) null))
        ((Entity) this.AssistantPed).Delete();
      if (Entity.op_Inequality((Entity) this.CEOChairProp, (Entity) null))
        ((Entity) this.CEOChairProp).Delete();
      if (Entity.op_Inequality((Entity) this.AssistantChairProp, (Entity) null))
        ((Entity) this.AssistantChairProp).Delete();
      if (Camera.op_Inequality(this.WarehouseCam, (Camera) null))
      {
        World.set_RenderingCamera(this.WarehouseCam);
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.WarehouseCam.set_IsActive(false);
        this.WarehouseCam.Destroy();
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
      }
      if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
        this.DestoryVehicle.Remove();
      if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
        ((Entity) this.VehicleMissioncar).Delete();
      if (Entity.op_Inequality((Entity) this.VehicleId, (Entity) null))
        ((Entity) this.VehicleId).Delete();
      if (Entity.op_Inequality((Entity) this.VtoGet, (Entity) null))
        ((Entity) this.VtoGet).Delete();
      if (Entity.op_Inequality((Entity) this.VtoGet1, (Entity) null))
        ((Entity) this.VtoGet1).Delete();
      if (Entity.op_Inequality((Entity) this.VtoGet2, (Entity) null))
        ((Entity) this.VtoGet2).Delete();
      if (Entity.op_Inequality((Entity) this.VtoGet3, (Entity) null))
        ((Entity) this.VtoGet3).Delete();
      if (Blip.op_Inequality(this.VtoGetBlip, (Blip) null))
        this.VtoGetBlip.Remove();
      if (Blip.op_Inequality(this.DropzoneBlip, (Blip) null))
        this.DropzoneBlip.Remove();
      if (Entity.op_Inequality((Entity) this.RentedVehicle, (Entity) null))
        ((Entity) this.RentedVehicle).Delete();
      if (Blip.op_Inequality(this.TowerBlip, (Blip) null))
        this.TowerBlip.Remove();
      if (Blip.op_Inequality(this.GarageBlip, (Blip) null))
        this.GarageBlip.Remove();
      if (Blip.op_Inequality(this.PenthouseBlip, (Blip) null))
        this.PenthouseBlip.Remove();
      if (Blip.op_Inequality(this.MenuBlip, (Blip) null))
        this.MenuBlip.Remove();
      using (List<Ped>.Enumerator enumerator = this.MiscPed.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Ped>.Enumerator enumerator = this.SMPed.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality((Entity) this.Prizecar, (Entity) null))
        ((Entity) this.Prizecar).Delete();
      if (Entity.op_Inequality((Entity) this.Chair, (Entity) null))
        ((Entity) this.Chair).Delete();
      using (List<Prop>.Enumerator enumerator = this.Champ.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Prop>.Enumerator enumerator = this.WheelMarkers.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Prop>.Enumerator enumerator = this.Card_Deck.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Prop>.Enumerator enumerator = this.Tables2.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Prop>.Enumerator enumerator = this.Tables.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Prop>.Enumerator enumerator = this.Chips.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality((Entity) this.WheelWinMarker, (Entity) null))
        ((Entity) this.WheelWinMarker).Delete();
      if (Entity.op_Inequality((Entity) this.TankerA, (Entity) null))
        ((Entity) this.TankerA).Delete();
      if (Entity.op_Inequality((Entity) this.TankerB, (Entity) null))
        ((Entity) this.TankerB).Delete();
      if (Entity.op_Inequality((Entity) this.TankerC, (Entity) null))
        ((Entity) this.TankerC).Delete();
      if (Entity.op_Inequality((Entity) this.TankerD, (Entity) null))
        ((Entity) this.TankerD).Delete();
      if (Entity.op_Inequality((Entity) this.TankerE, (Entity) null))
        ((Entity) this.TankerE).Delete();
      if (Entity.op_Inequality((Entity) this.TankerF, (Entity) null))
        ((Entity) this.TankerF).Delete();
      if (Entity.op_Inequality((Entity) this.TankerG, (Entity) null))
        ((Entity) this.TankerG).Delete();
      if (Entity.op_Inequality((Entity) this.TankerH, (Entity) null))
        ((Entity) this.TankerH).Delete();
    }
  }
}
