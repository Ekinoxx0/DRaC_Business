// Decompiled with JetBrains decompiler
// Type: DRaC_Business.SaveCar
// Assembly: DRaC_Business, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 46ED2638-FF60-4062-85B3-F169AC3C0185
// Assembly location: C:\Users\Ekinoxx\Desktop\DRaC_Business.dll

using GTA;
using GTA.Math;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DRaC_Business
{
  public class SaveCar : Script
  {
    public ScriptSettings Config;
    public Vehicle VehicleId;
    public string VehicleName;
    public int RoofId;
    public int AerialsId;
    public int AirfilterId;
    public int ArchCoverId;
    public int ArmorId;
    public int BackWheelsId;
    public int BrakesId;
    public int ColumnShifterLeversId;
    public int DashboardId;
    public int DialDesignId;
    public int DoorSpeekersId;
    public int EngineId;
    public int EngineBlockId;
    public int ExaustId;
    public int FenderId;
    public int FrameId;
    public int FrontBumperId;
    public int FrontWheelsId;
    public int GrilleId;
    public int HoodId;
    public int HornsId;
    public int HydralicsId;
    public int LiveryId;
    public int OrnamentsId;
    public int PlaquesId;
    public int Plateholder;
    public int RearBumperId;
    public int RightFenderId;
    public int SeatsId;
    public int SideSkirt;
    public int speakers;
    public int SpoilersId;
    public int SteeringWheelId;
    public int StrutId;
    public int SuspensionId;
    public int TankId;
    public int TransmissionId;
    public int TrimId;
    public int TrimDesignId;
    public int TrunkId;
    public int VanityPlatesId;
    public int WindowId;
    public VehicleColor PearlCent;
    public Color NeonColour;
    public VehicleColor PrimaryColor;
    public VehicleColor SecondaryColor;
    public Vector3 VehhicleLoc;
    public Vehicle SavedVehicle;
    public Vehicle newvehicle;
    public Vehicle VehicletoCheck;
    public bool HasTurbo;
    public bool HasXenonLights;
    public VehicleWindowTint TintId;
    public string PlanteNo;
    public int Blades;
    public int LightColor;
    public string VehicleHash;
    public bool TurboActive;
    public Color NeonColor;
    public bool RightNeonOn;
    public bool LeftNeonOn;
    public bool FrontNeonOn;
    public bool BackNeonOn;
    public List<bool> ExtraOn;
    public bool HasTireSmoke;
    public VehicleColor Wheelcolour;
    public VehicleColor DashBoardColour;
    public Color TireSmokeColor;
    public bool TireSmoke;
    public bool BulletProofTires;
    public VehicleColor TrimColor;
    public float Torque;
    public float Power;
    public bool HasClanTag;
    public VehiclesEmblem VE;

    public SaveCar()
    {
      base.\u002Ector();
      this.VE.AddVehicles();
      this.add_Tick(new EventHandler(this.OnTick));
      this.add_KeyDown(new KeyEventHandler(this.onKeyDown));
      this.Setup();
    }

    public void SetupVehicle(Vehicle Car, int I)
    {
      if (I != 0)
        return;
      Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
      {
        InputArgument.op_Implicit(((Entity) Car).get_Handle()),
        InputArgument.op_Implicit(0)
      });
      Car.SetMod((VehicleMod) 10, 0, true);
      Car.SetMod((VehicleMod) 5, 2, true);
      Car.SetMod((VehicleMod) 7, 2, true);
    }

    public void SaveName()
    {
      this.VehicleName = "null";
      this.Config.SetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
      this.Config.Save();
    }

    public void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.VehicleName = (string) this.Config.GetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
        this.RoofId = (int) this.Config.GetValue<int>("Configurations", "RoofId", (M0) this.RoofId);
        this.AerialsId = (int) this.Config.GetValue<int>("Configurations", "AerialsId", (M0) this.AerialsId);
        this.AirfilterId = (int) this.Config.GetValue<int>("Configurations", "AirfilterId", (M0) this.AirfilterId);
        this.ArchCoverId = (int) this.Config.GetValue<int>("Configurations", "ArchCoverId", (M0) this.ArchCoverId);
        this.ArmorId = (int) this.Config.GetValue<int>("Configurations", "ArmorId", (M0) this.ArmorId);
        this.BackWheelsId = (int) this.Config.GetValue<int>("Configurations", "BackWheelsId", (M0) this.BackWheelsId);
        this.BrakesId = (int) this.Config.GetValue<int>("Configurations", "BrakesId", (M0) this.BrakesId);
        this.ColumnShifterLeversId = (int) this.Config.GetValue<int>("Configurations", "ColumnShifterLeversId", (M0) this.ColumnShifterLeversId);
        this.DashboardId = (int) this.Config.GetValue<int>("Configurations", "DashboardId", (M0) this.DashboardId);
        this.DialDesignId = (int) this.Config.GetValue<int>("Configurations", "DialDesignId", (M0) this.DialDesignId);
        this.DoorSpeekersId = (int) this.Config.GetValue<int>("Configurations", "DoorSpeekersId", (M0) this.DoorSpeekersId);
        this.EngineId = (int) this.Config.GetValue<int>("Configurations", "EngineId", (M0) this.EngineId);
        this.EngineBlockId = (int) this.Config.GetValue<int>("Configurations", "EngineBlockId", (M0) this.EngineBlockId);
        this.ExaustId = (int) this.Config.GetValue<int>("Configurations", "ExaustId", (M0) this.ExaustId);
        this.FenderId = (int) this.Config.GetValue<int>("Configurations", "FenderId", (M0) this.FenderId);
        this.FrameId = (int) this.Config.GetValue<int>("Configurations", "FrameId", (M0) this.FrameId);
        this.FrontBumperId = (int) this.Config.GetValue<int>("Configurations", "FrontBumperId", (M0) this.FrontBumperId);
        this.FrontWheelsId = (int) this.Config.GetValue<int>("Configurations", "FrontWheelsId", (M0) this.FrontWheelsId);
        this.GrilleId = (int) this.Config.GetValue<int>("Configurations", "GrilleId", (M0) this.GrilleId);
        this.HoodId = (int) this.Config.GetValue<int>("Configurations", "HoodId", (M0) this.HoodId);
        this.HornsId = (int) this.Config.GetValue<int>("Configurations", "HornsId", (M0) this.HornsId);
        this.HydralicsId = (int) this.Config.GetValue<int>("Configurations", "HydralicsId", (M0) this.HydralicsId);
        this.LiveryId = (int) this.Config.GetValue<int>("Configurations", "LiveryId", (M0) this.LiveryId);
        this.OrnamentsId = (int) this.Config.GetValue<int>("Configurations", "OrnamentsId", (M0) this.OrnamentsId);
        this.PlaquesId = (int) this.Config.GetValue<int>("Configurations", "PlaquesId", (M0) this.PlaquesId);
        this.Plateholder = (int) this.Config.GetValue<int>("Configurations", "Plateholder", (M0) this.Plateholder);
        this.RearBumperId = (int) this.Config.GetValue<int>("Configurations", "RearBumperId", (M0) this.RearBumperId);
        this.RightFenderId = (int) this.Config.GetValue<int>("Configurations", "RightFenderId", (M0) this.RightFenderId);
        this.SeatsId = (int) this.Config.GetValue<int>("Configurations", "SeatsId", (M0) this.SeatsId);
        this.SideSkirt = (int) this.Config.GetValue<int>("Configurations", "SideSkirt", (M0) this.SideSkirt);
        this.speakers = (int) this.Config.GetValue<int>("Configurations", "speakers", (M0) this.speakers);
        this.SpoilersId = (int) this.Config.GetValue<int>("Configurations", "SpoilersId", (M0) this.SpoilersId);
        this.SteeringWheelId = (int) this.Config.GetValue<int>("Configurations", "SteeringWheelId", (M0) this.SteeringWheelId);
        this.StrutId = (int) this.Config.GetValue<int>("Configurations", "StrutId", (M0) this.StrutId);
        this.SuspensionId = (int) this.Config.GetValue<int>("Configurations", "SuspensionId", (M0) this.SuspensionId);
        this.TankId = (int) this.Config.GetValue<int>("Configurations", "TankId", (M0) this.TankId);
        this.TransmissionId = (int) this.Config.GetValue<int>("Configurations", "TransmissionId", (M0) this.TransmissionId);
        this.TrimId = (int) this.Config.GetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
        this.TrimDesignId = (int) this.Config.GetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
        this.TrunkId = (int) this.Config.GetValue<int>("Configurations", "TrunkId", (M0) this.TrunkId);
        this.VanityPlatesId = (int) this.Config.GetValue<int>("Configurations", "VanityPlatesId", (M0) this.VanityPlatesId);
        this.WindowId = (int) this.Config.GetValue<int>("Configurations", "WindowId", (M0) this.WindowId);
        this.PrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "PrimaryColor", (M0) this.PrimaryColor);
        this.SecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "SecondaryColor", (M0) this.SecondaryColor);
        this.Wheelcolour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
        this.DashBoardColour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
        this.PearlCent = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "PearlCent", (M0) this.PearlCent);
        this.NeonColour = (Color) this.Config.GetValue<Color>("Configurations", "NeonColour", (M0) this.NeonColour);
        this.TintId = (VehicleWindowTint) this.Config.GetValue<VehicleWindowTint>("Configurations", "TintId", (M0) this.TintId);
        this.PlanteNo = (string) this.Config.GetValue<string>("Configurations", "PlanteNo", (M0) this.PlanteNo);
        this.Blades = (int) this.Config.GetValue<int>("Configurations", "Blades", (M0) this.Blades);
        this.LightColor = (int) this.Config.GetValue<int>("Configurations", "LightColor", (M0) this.LightColor);
        this.HasXenonLights = (bool) this.Config.GetValue<bool>("Configurations", "HasXenonLights", (M0) (this.HasXenonLights ? 1 : 0));
        this.TurboActive = (bool) this.Config.GetValue<bool>("Configurations", "TurboActive", (M0) (this.TurboActive ? 1 : 0));
        this.NeonColor = (Color) this.Config.GetValue<Color>("Configurations", "NeonColor", (M0) this.NeonColor);
        this.RightNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "RightNeonOn", (M0) (this.RightNeonOn ? 1 : 0));
        this.LeftNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "LeftNeonOn", (M0) (this.LeftNeonOn ? 1 : 0));
        this.FrontNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "FrontNeonOn", (M0) (this.FrontNeonOn ? 1 : 0));
        this.BackNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "BackNeonOn", (M0) (this.BackNeonOn ? 1 : 0));
        this.HasClanTag = (bool) this.Config.GetValue<bool>("Configurations", "CLanTagOn", (M0) (this.HasClanTag ? 1 : 0));
        try
        {
          string str1 = "//";
          StreamReader streamReader = new StreamReader(iniName);
          while (true)
          {
            string str2 = streamReader.ReadLine();
            string str3 = str2;
            if (str2 != null)
            {
              if (str3.Contains(str1))
                ;
            }
            else
              break;
          }
          streamReader.Close();
        }
        catch (NullReferenceException ex)
        {
          UI.Notify("TEST18A");
        }
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: Config.ini Failed To Load.");
      }
    }

    private void Setup() => this.VehhicleLoc = new Vector3(849.007f, -3238.2f, -98f);

    public void Delete()
    {
      if (!Entity.op_Inequality((Entity) this.SavedVehicle, (Entity) null))
        return;
      this.VehicleId = this.SavedVehicle;
      ((Entity) this.SavedVehicle).Delete();
    }

    public void LoadAV() => this.Load2();

    private void Load2()
    {
      this.RoofId = (int) this.Config.GetValue<int>("Configurations", "RoofId", (M0) this.RoofId);
      this.AerialsId = (int) this.Config.GetValue<int>("Configurations", "AerialsId", (M0) this.AerialsId);
      this.AirfilterId = (int) this.Config.GetValue<int>("Configurations", "AirfilterId", (M0) this.AirfilterId);
      this.ArchCoverId = (int) this.Config.GetValue<int>("Configurations", "ArchCoverId", (M0) this.ArchCoverId);
      this.ArmorId = (int) this.Config.GetValue<int>("Configurations", "ArmorId", (M0) this.ArmorId);
      this.BackWheelsId = (int) this.Config.GetValue<int>("Configurations", "BackWheelsId", (M0) this.BackWheelsId);
      this.BrakesId = (int) this.Config.GetValue<int>("Configurations", "BrakesId", (M0) this.BrakesId);
      this.ColumnShifterLeversId = (int) this.Config.GetValue<int>("Configurations", "ColumnShifterLeversId", (M0) this.ColumnShifterLeversId);
      this.DashboardId = (int) this.Config.GetValue<int>("Configurations", "DashboardId", (M0) this.DashboardId);
      this.DialDesignId = (int) this.Config.GetValue<int>("Configurations", "DialDesignId", (M0) this.DialDesignId);
      this.DoorSpeekersId = (int) this.Config.GetValue<int>("Configurations", "DoorSpeekersId", (M0) this.DoorSpeekersId);
      this.EngineId = (int) this.Config.GetValue<int>("Configurations", "EngineId", (M0) this.EngineId);
      this.EngineBlockId = (int) this.Config.GetValue<int>("Configurations", "EngineBlockId", (M0) this.EngineBlockId);
      this.ExaustId = (int) this.Config.GetValue<int>("Configurations", "ExaustId", (M0) this.ExaustId);
      this.FenderId = (int) this.Config.GetValue<int>("Configurations", "FenderId", (M0) this.FenderId);
      this.FrameId = (int) this.Config.GetValue<int>("Configurations", "FrameId", (M0) this.FrameId);
      this.FrontBumperId = (int) this.Config.GetValue<int>("Configurations", "FrontBumperId", (M0) this.FrontBumperId);
      this.FrontWheelsId = (int) this.Config.GetValue<int>("Configurations", "FrontWheelsId", (M0) this.FrontWheelsId);
      this.GrilleId = (int) this.Config.GetValue<int>("Configurations", "GrilleId", (M0) this.GrilleId);
      this.HoodId = (int) this.Config.GetValue<int>("Configurations", "HoodId", (M0) this.HoodId);
      this.HornsId = (int) this.Config.GetValue<int>("Configurations", "HornsId", (M0) this.HornsId);
      this.HydralicsId = (int) this.Config.GetValue<int>("Configurations", "HydralicsId", (M0) this.HydralicsId);
      this.LiveryId = (int) this.Config.GetValue<int>("Configurations", "LiveryId", (M0) this.LiveryId);
      this.OrnamentsId = (int) this.Config.GetValue<int>("Configurations", "OrnamentsId", (M0) this.OrnamentsId);
      this.PlaquesId = (int) this.Config.GetValue<int>("Configurations", "PlaquesId", (M0) this.PlaquesId);
      this.Plateholder = (int) this.Config.GetValue<int>("Configurations", "Plateholder", (M0) this.Plateholder);
      this.RearBumperId = (int) this.Config.GetValue<int>("Configurations", "RearBumperId", (M0) this.RearBumperId);
      this.RightFenderId = (int) this.Config.GetValue<int>("Configurations", "RightFenderId", (M0) this.RightFenderId);
      this.SeatsId = (int) this.Config.GetValue<int>("Configurations", "SeatsId", (M0) this.SeatsId);
      this.SideSkirt = (int) this.Config.GetValue<int>("Configurations", "SideSkirt", (M0) this.SideSkirt);
      this.speakers = (int) this.Config.GetValue<int>("Configurations", "speakers", (M0) this.speakers);
      this.SpoilersId = (int) this.Config.GetValue<int>("Configurations", "SpoilersId", (M0) this.SpoilersId);
      this.SteeringWheelId = (int) this.Config.GetValue<int>("Configurations", "SteeringWheelId", (M0) this.SteeringWheelId);
      this.StrutId = (int) this.Config.GetValue<int>("Configurations", "StrutId", (M0) this.StrutId);
      this.SuspensionId = (int) this.Config.GetValue<int>("Configurations", "SuspensionId", (M0) this.SuspensionId);
      this.TankId = (int) this.Config.GetValue<int>("Configurations", "TankId", (M0) this.TankId);
      this.TransmissionId = (int) this.Config.GetValue<int>("Configurations", "TransmissionId", (M0) this.TransmissionId);
      this.TrimId = (int) this.Config.GetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.TrimDesignId = (int) this.Config.GetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.TrunkId = (int) this.Config.GetValue<int>("Configurations", "TrunkId", (M0) this.TrunkId);
      this.VanityPlatesId = (int) this.Config.GetValue<int>("Configurations", "VanityPlatesId", (M0) this.VanityPlatesId);
      this.WindowId = (int) this.Config.GetValue<int>("Configurations", "WindowId", (M0) this.WindowId);
      this.PrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "PrimaryColor", (M0) this.PrimaryColor);
      this.SecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "SecondaryColor", (M0) this.SecondaryColor);
      this.Wheelcolour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.DashBoardColour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.PearlCent = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "PearlCent", (M0) this.PearlCent);
      this.NeonColour = (Color) this.Config.GetValue<Color>("Configurations", "NeonColour", (M0) this.NeonColour);
      this.TintId = (VehicleWindowTint) this.Config.GetValue<VehicleWindowTint>("Configurations", "TintId", (M0) this.TintId);
      this.PlanteNo = (string) this.Config.GetValue<string>("Configurations", "PlanteNo", (M0) this.PlanteNo);
      this.Blades = (int) this.Config.GetValue<int>("Configurations", "Blades", (M0) this.Blades);
      this.LightColor = (int) this.Config.GetValue<int>("Configurations", "LightColor", (M0) this.LightColor);
      this.HasXenonLights = (bool) this.Config.GetValue<bool>("Configurations", "HasXenonLights", (M0) (this.HasXenonLights ? 1 : 0));
      this.TurboActive = (bool) this.Config.GetValue<bool>("Configurations", "TurboActive", (M0) (this.TurboActive ? 1 : 0));
      this.NeonColor = (Color) this.Config.GetValue<Color>("Configurations", "NeonColor", (M0) this.NeonColor);
      this.RightNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "RightNeonOn", (M0) (this.RightNeonOn ? 1 : 0));
      this.LeftNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "LeftNeonOn", (M0) (this.LeftNeonOn ? 1 : 0));
      this.FrontNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "FrontNeonOn", (M0) (this.FrontNeonOn ? 1 : 0));
      this.BackNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "BackNeonOn", (M0) (this.BackNeonOn ? 1 : 0));
      this.TrimColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "TrimColor", (M0) this.TrimColor);
      this.BulletProofTires = (bool) this.Config.GetValue<bool>("Configurations", "BulletProofTires", (M0) (this.BulletProofTires ? 1 : 0));
      this.Wheelcolour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.DashBoardColour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.TireSmokeColor = (Color) this.Config.GetValue<Color>("Configurations", "TireSmokeColor", (M0) this.TireSmokeColor);
      this.TireSmoke = (bool) this.Config.GetValue<bool>("Configurations", "TireSmoke", (M0) (this.TireSmoke ? 1 : 0));
      try
      {
        this.Torque = (float) this.Config.GetValue<float>("Configurations", "Torque", (M0) (double) this.Torque);
        this.Power = (float) this.Config.GetValue<float>("Configurations", "Power", (M0) (double) this.Power);
      }
      catch
      {
        this.Torque = 1f;
        this.Config.SetValue<float>("Configurations", "Torque", (M0) (double) this.Torque);
        this.Power = 1f;
        this.Config.SetValue<float>("Configurations", "Power", (M0) (double) this.Power);
        this.Config.Save();
      }
      this.HasClanTag = (bool) this.Config.GetValue<bool>("Configurations", "CLanTagOn", (M0) (this.HasClanTag ? 1 : 0));
      this.ExtraOn.Clear();
      for (int index = 0; index < 21; ++index)
      {
        if ((bool) this.Config.GetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) 1))
          this.ExtraOn.Add(true);
        else
          this.ExtraOn.Add(false);
      }
      this.newvehicle = World.CreateVehicle(Model.op_Implicit(this.VehicleName.ToString()), this.VehhicleLoc, -90f);
      Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
      {
        InputArgument.op_Implicit(((Entity) this.newvehicle).get_Handle()),
        InputArgument.op_Implicit(0)
      });
      this.newvehicle.SetMod((VehicleMod) 10, this.RoofId, true);
      this.newvehicle.SetMod((VehicleMod) 10, this.RoofId, true);
      this.newvehicle.SetMod((VehicleMod) 43, this.AerialsId, true);
      this.newvehicle.SetMod((VehicleMod) 40, this.AirfilterId, true);
      this.newvehicle.SetMod((VehicleMod) 42, this.ArchCoverId, true);
      this.newvehicle.SetMod((VehicleMod) 16, this.ArmorId, true);
      this.newvehicle.SetMod((VehicleMod) 24, this.BackWheelsId, true);
      this.newvehicle.SetMod((VehicleMod) 12, this.BrakesId, true);
      this.newvehicle.SetMod((VehicleMod) 34, this.ColumnShifterLeversId, true);
      this.newvehicle.SetMod((VehicleMod) 29, this.DashboardId, true);
      this.newvehicle.SetMod((VehicleMod) 30, this.DialDesignId, true);
      this.newvehicle.SetMod((VehicleMod) 31, this.DoorSpeekersId, true);
      this.newvehicle.SetMod((VehicleMod) 11, this.EngineId, true);
      this.newvehicle.SetMod((VehicleMod) 39, this.EngineBlockId, true);
      this.newvehicle.SetMod((VehicleMod) 4, this.ExaustId, true);
      this.newvehicle.SetMod((VehicleMod) 8, this.FenderId, true);
      this.newvehicle.SetMod((VehicleMod) 5, this.FrameId, true);
      this.newvehicle.SetMod((VehicleMod) 1, this.FrontBumperId, true);
      this.newvehicle.SetMod((VehicleMod) 23, this.FrontWheelsId, true);
      this.newvehicle.SetMod((VehicleMod) 6, this.GrilleId, true);
      this.newvehicle.SetMod((VehicleMod) 7, this.HoodId, true);
      this.newvehicle.SetMod((VehicleMod) 14, this.HornsId, true);
      this.newvehicle.SetMod((VehicleMod) 38, this.HydralicsId, true);
      this.newvehicle.SetMod((VehicleMod) 48, this.LiveryId, true);
      this.newvehicle.SetMod((VehicleMod) 28, this.OrnamentsId, true);
      this.newvehicle.SetMod((VehicleMod) 35, this.PlaquesId, true);
      this.newvehicle.SetMod((VehicleMod) 25, this.Plateholder, true);
      this.newvehicle.SetMod((VehicleMod) 2, this.RearBumperId, true);
      this.newvehicle.SetMod((VehicleMod) 9, this.RightFenderId, true);
      this.newvehicle.SetMod((VehicleMod) 32, this.SeatsId, true);
      this.newvehicle.SetMod((VehicleMod) 3, this.SideSkirt, true);
      this.newvehicle.SetMod((VehicleMod) 36, this.speakers, true);
      this.newvehicle.SetMod((VehicleMod) 0, this.SpoilersId, true);
      this.newvehicle.SetMod((VehicleMod) 33, this.SteeringWheelId, true);
      this.newvehicle.SetMod((VehicleMod) 41, this.StrutId, true);
      this.newvehicle.SetMod((VehicleMod) 15, this.SuspensionId, true);
      this.newvehicle.SetMod((VehicleMod) 45, this.TankId, true);
      this.newvehicle.SetMod((VehicleMod) 13, this.TransmissionId, true);
      this.newvehicle.SetMod((VehicleMod) 44, this.TrimId, true);
      this.newvehicle.SetMod((VehicleMod) 27, this.TrimDesignId, true);
      this.newvehicle.SetMod((VehicleMod) 37, this.TrunkId, true);
      this.newvehicle.SetMod((VehicleMod) 26, this.VanityPlatesId, true);
      this.newvehicle.SetMod((VehicleMod) 46, this.WindowId, true);
      this.newvehicle.SetMod((VehicleMod) 44, this.Blades, true);
      this.newvehicle.ToggleMod((VehicleToggleMod) 22, this.HasXenonLights);
      this.newvehicle.ToggleMod((VehicleToggleMod) 18, this.TurboActive);
      Function.Call((Hash) -2013052192277120505L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.newvehicle),
        InputArgument.op_Implicit(this.LightColor)
      });
      try
      {
        if (this.HasClanTag)
        {
          this.VE.CheckforEmblem(this.newvehicle);
          this.VE.CreateVehEmblem(this.newvehicle, Game.get_Player().get_Character());
        }
      }
      catch (Exception ex)
      {
      }
      if (this.RightNeonOn)
      {
        this.newvehicle.set_NeonLightsColor(this.NeonColor);
        this.newvehicle.SetNeonLightsOn((VehicleNeonLight) 1, true);
      }
      if (this.LeftNeonOn)
      {
        this.newvehicle.set_NeonLightsColor(this.NeonColor);
        this.newvehicle.SetNeonLightsOn((VehicleNeonLight) 0, true);
      }
      if (this.BackNeonOn)
      {
        this.newvehicle.set_NeonLightsColor(this.NeonColor);
        this.newvehicle.SetNeonLightsOn((VehicleNeonLight) 3, true);
      }
      if (this.FrontNeonOn)
      {
        this.newvehicle.set_NeonLightsColor(this.NeonColor);
        this.newvehicle.SetNeonLightsOn((VehicleNeonLight) 2, true);
      }
      this.newvehicle.set_WindowTint(this.TintId);
      this.newvehicle.set_PrimaryColor(this.PrimaryColor);
      this.newvehicle.set_SecondaryColor(this.SecondaryColor);
      this.newvehicle.set_RimColor(this.Wheelcolour);
      this.newvehicle.set_DashboardColor(this.DashBoardColour);
      this.newvehicle.set_PearlescentColor(this.PearlCent);
      this.newvehicle.set_NeonLightsColor(this.NeonColour);
      this.newvehicle.set_NumberPlate(this.PlanteNo);
      this.newvehicle.set_IsDriveable(false);
      this.newvehicle.ToggleMod((VehicleToggleMod) 20, this.TireSmoke);
      this.newvehicle.set_RimColor(this.Wheelcolour);
      this.newvehicle.set_DashboardColor(this.DashBoardColour);
      this.newvehicle.set_TireSmokeColor(this.TireSmokeColor);
      this.newvehicle.set_EngineTorqueMultiplier(this.Torque);
      this.newvehicle.set_EnginePowerMultiplier(this.Power);
      this.newvehicle.set_TrimColor(this.TrimColor);
      this.newvehicle.set_CanTiresBurst(this.BulletProofTires);
      for (int index = 0; index < 21; ++index)
      {
        if ((bool) this.Config.GetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) (this.ExtraOn[index] ? 1 : 0)))
          this.newvehicle.ToggleExtra(index, this.ExtraOn[index]);
      }
      this.SavedVehicle = this.newvehicle;
    }

    public void Load(Vehicle V, string VehicleName2, Vector3 VehicleLoc2, int Rot)
    {
      this.newvehicle = V;
      this.RoofId = (int) this.Config.GetValue<int>("Configurations", "RoofId", (M0) this.RoofId);
      this.AerialsId = (int) this.Config.GetValue<int>("Configurations", "AerialsId", (M0) this.AerialsId);
      this.AirfilterId = (int) this.Config.GetValue<int>("Configurations", "AirfilterId", (M0) this.AirfilterId);
      this.ArchCoverId = (int) this.Config.GetValue<int>("Configurations", "ArchCoverId", (M0) this.ArchCoverId);
      this.ArmorId = (int) this.Config.GetValue<int>("Configurations", "ArmorId", (M0) this.ArmorId);
      this.BackWheelsId = (int) this.Config.GetValue<int>("Configurations", "BackWheelsId", (M0) this.BackWheelsId);
      this.BrakesId = (int) this.Config.GetValue<int>("Configurations", "BrakesId", (M0) this.BrakesId);
      this.ColumnShifterLeversId = (int) this.Config.GetValue<int>("Configurations", "ColumnShifterLeversId", (M0) this.ColumnShifterLeversId);
      this.DashboardId = (int) this.Config.GetValue<int>("Configurations", "DashboardId", (M0) this.DashboardId);
      this.DialDesignId = (int) this.Config.GetValue<int>("Configurations", "DialDesignId", (M0) this.DialDesignId);
      this.DoorSpeekersId = (int) this.Config.GetValue<int>("Configurations", "DoorSpeekersId", (M0) this.DoorSpeekersId);
      this.EngineId = (int) this.Config.GetValue<int>("Configurations", "EngineId", (M0) this.EngineId);
      this.EngineBlockId = (int) this.Config.GetValue<int>("Configurations", "EngineBlockId", (M0) this.EngineBlockId);
      this.ExaustId = (int) this.Config.GetValue<int>("Configurations", "ExaustId", (M0) this.ExaustId);
      this.FenderId = (int) this.Config.GetValue<int>("Configurations", "FenderId", (M0) this.FenderId);
      this.FrameId = (int) this.Config.GetValue<int>("Configurations", "FrameId", (M0) this.FrameId);
      this.FrontBumperId = (int) this.Config.GetValue<int>("Configurations", "FrontBumperId", (M0) this.FrontBumperId);
      this.FrontWheelsId = (int) this.Config.GetValue<int>("Configurations", "FrontWheelsId", (M0) this.FrontWheelsId);
      this.GrilleId = (int) this.Config.GetValue<int>("Configurations", "GrilleId", (M0) this.GrilleId);
      this.HoodId = (int) this.Config.GetValue<int>("Configurations", "HoodId", (M0) this.HoodId);
      this.HornsId = (int) this.Config.GetValue<int>("Configurations", "HornsId", (M0) this.HornsId);
      this.HydralicsId = (int) this.Config.GetValue<int>("Configurations", "HydralicsId", (M0) this.HydralicsId);
      this.LiveryId = (int) this.Config.GetValue<int>("Configurations", "LiveryId", (M0) this.LiveryId);
      this.OrnamentsId = (int) this.Config.GetValue<int>("Configurations", "OrnamentsId", (M0) this.OrnamentsId);
      this.PlaquesId = (int) this.Config.GetValue<int>("Configurations", "PlaquesId", (M0) this.PlaquesId);
      this.Plateholder = (int) this.Config.GetValue<int>("Configurations", "Plateholder", (M0) this.Plateholder);
      this.RearBumperId = (int) this.Config.GetValue<int>("Configurations", "RearBumperId", (M0) this.RearBumperId);
      this.RightFenderId = (int) this.Config.GetValue<int>("Configurations", "RightFenderId", (M0) this.RightFenderId);
      this.SeatsId = (int) this.Config.GetValue<int>("Configurations", "SeatsId", (M0) this.SeatsId);
      this.SideSkirt = (int) this.Config.GetValue<int>("Configurations", "SideSkirt", (M0) this.SideSkirt);
      this.speakers = (int) this.Config.GetValue<int>("Configurations", "speakers", (M0) this.speakers);
      this.SpoilersId = (int) this.Config.GetValue<int>("Configurations", "SpoilersId", (M0) this.SpoilersId);
      this.SteeringWheelId = (int) this.Config.GetValue<int>("Configurations", "SteeringWheelId", (M0) this.SteeringWheelId);
      this.StrutId = (int) this.Config.GetValue<int>("Configurations", "StrutId", (M0) this.StrutId);
      this.SuspensionId = (int) this.Config.GetValue<int>("Configurations", "SuspensionId", (M0) this.SuspensionId);
      this.TankId = (int) this.Config.GetValue<int>("Configurations", "TankId", (M0) this.TankId);
      this.TransmissionId = (int) this.Config.GetValue<int>("Configurations", "TransmissionId", (M0) this.TransmissionId);
      this.TrimId = (int) this.Config.GetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.TrimDesignId = (int) this.Config.GetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.TrunkId = (int) this.Config.GetValue<int>("Configurations", "TrunkId", (M0) this.TrunkId);
      this.VanityPlatesId = (int) this.Config.GetValue<int>("Configurations", "VanityPlatesId", (M0) this.VanityPlatesId);
      this.WindowId = (int) this.Config.GetValue<int>("Configurations", "WindowId", (M0) this.WindowId);
      this.PrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "PrimaryColor", (M0) this.PrimaryColor);
      this.SecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "SecondaryColor", (M0) this.SecondaryColor);
      this.Wheelcolour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.DashBoardColour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.PearlCent = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "PearlCent", (M0) this.PearlCent);
      this.NeonColour = (Color) this.Config.GetValue<Color>("Configurations", "NeonColour", (M0) this.NeonColour);
      this.TintId = (VehicleWindowTint) this.Config.GetValue<VehicleWindowTint>("Configurations", "TintId", (M0) this.TintId);
      this.PlanteNo = (string) this.Config.GetValue<string>("Configurations", "PlanteNo", (M0) this.PlanteNo);
      this.Blades = (int) this.Config.GetValue<int>("Configurations", "Blades", (M0) this.Blades);
      this.LightColor = (int) this.Config.GetValue<int>("Configurations", "LightColor", (M0) this.LightColor);
      this.HasXenonLights = (bool) this.Config.GetValue<bool>("Configurations", "HasXenonLights", (M0) (this.HasXenonLights ? 1 : 0));
      this.TurboActive = (bool) this.Config.GetValue<bool>("Configurations", "TurboActive", (M0) (this.TurboActive ? 1 : 0));
      this.NeonColor = (Color) this.Config.GetValue<Color>("Configurations", "NeonColor", (M0) this.NeonColor);
      this.RightNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "RightNeonOn", (M0) (this.RightNeonOn ? 1 : 0));
      this.LeftNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "LeftNeonOn", (M0) (this.LeftNeonOn ? 1 : 0));
      this.FrontNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "FrontNeonOn", (M0) (this.FrontNeonOn ? 1 : 0));
      this.BackNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "BackNeonOn", (M0) (this.BackNeonOn ? 1 : 0));
      this.TrimColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "TrimColor", (M0) this.TrimColor);
      this.BulletProofTires = (bool) this.Config.GetValue<bool>("Configurations", "BulletProofTires", (M0) (this.BulletProofTires ? 1 : 0));
      this.Wheelcolour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.DashBoardColour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.TireSmokeColor = (Color) this.Config.GetValue<Color>("Configurations", "TireSmokeColor", (M0) this.TireSmokeColor);
      this.TireSmoke = (bool) this.Config.GetValue<bool>("Configurations", "TireSmoke", (M0) (this.TireSmoke ? 1 : 0));
      try
      {
        this.Torque = (float) this.Config.GetValue<float>("Configurations", "Torque", (M0) (double) this.Torque);
        this.Power = (float) this.Config.GetValue<float>("Configurations", "Power", (M0) (double) this.Power);
      }
      catch
      {
        this.Torque = 1f;
        this.Config.SetValue<float>("Configurations", "Torque", (M0) (double) this.Torque);
        this.Power = 1f;
        this.Config.SetValue<float>("Configurations", "Power", (M0) (double) this.Power);
        this.Config.Save();
      }
      this.HasClanTag = (bool) this.Config.GetValue<bool>("Configurations", "CLanTagOn", (M0) (this.HasClanTag ? 1 : 0));
      this.ExtraOn.Clear();
      for (int index = 0; index < 21; ++index)
      {
        if ((bool) this.Config.GetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) 1))
          this.ExtraOn.Add(true);
        else
          this.ExtraOn.Add(false);
      }
      this.newvehicle = World.CreateVehicle(Model.op_Implicit(VehicleName2), VehicleLoc2, (float) Rot);
      Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
      {
        InputArgument.op_Implicit(((Entity) this.newvehicle).get_Handle()),
        InputArgument.op_Implicit(0)
      });
      this.newvehicle.SetMod((VehicleMod) 10, this.RoofId, true);
      this.newvehicle.SetMod((VehicleMod) 10, this.RoofId, true);
      this.newvehicle.SetMod((VehicleMod) 43, this.AerialsId, true);
      this.newvehicle.SetMod((VehicleMod) 40, this.AirfilterId, true);
      this.newvehicle.SetMod((VehicleMod) 42, this.ArchCoverId, true);
      this.newvehicle.SetMod((VehicleMod) 16, this.ArmorId, true);
      this.newvehicle.SetMod((VehicleMod) 24, this.BackWheelsId, true);
      this.newvehicle.SetMod((VehicleMod) 12, this.BrakesId, true);
      this.newvehicle.SetMod((VehicleMod) 34, this.ColumnShifterLeversId, true);
      this.newvehicle.SetMod((VehicleMod) 29, this.DashboardId, true);
      this.newvehicle.SetMod((VehicleMod) 30, this.DialDesignId, true);
      this.newvehicle.SetMod((VehicleMod) 31, this.DoorSpeekersId, true);
      this.newvehicle.SetMod((VehicleMod) 11, this.EngineId, true);
      this.newvehicle.SetMod((VehicleMod) 39, this.EngineBlockId, true);
      this.newvehicle.SetMod((VehicleMod) 4, this.ExaustId, true);
      this.newvehicle.SetMod((VehicleMod) 8, this.FenderId, true);
      this.newvehicle.SetMod((VehicleMod) 5, this.FrameId, true);
      this.newvehicle.SetMod((VehicleMod) 1, this.FrontBumperId, true);
      this.newvehicle.SetMod((VehicleMod) 23, this.FrontWheelsId, true);
      this.newvehicle.SetMod((VehicleMod) 6, this.GrilleId, true);
      this.newvehicle.SetMod((VehicleMod) 7, this.HoodId, true);
      this.newvehicle.SetMod((VehicleMod) 14, this.HornsId, true);
      this.newvehicle.SetMod((VehicleMod) 38, this.HydralicsId, true);
      this.newvehicle.SetMod((VehicleMod) 48, this.LiveryId, true);
      this.newvehicle.SetMod((VehicleMod) 28, this.OrnamentsId, true);
      this.newvehicle.SetMod((VehicleMod) 35, this.PlaquesId, true);
      this.newvehicle.SetMod((VehicleMod) 25, this.Plateholder, true);
      this.newvehicle.SetMod((VehicleMod) 2, this.RearBumperId, true);
      this.newvehicle.SetMod((VehicleMod) 9, this.RightFenderId, true);
      this.newvehicle.SetMod((VehicleMod) 32, this.SeatsId, true);
      this.newvehicle.SetMod((VehicleMod) 3, this.SideSkirt, true);
      this.newvehicle.SetMod((VehicleMod) 36, this.speakers, true);
      this.newvehicle.SetMod((VehicleMod) 0, this.SpoilersId, true);
      this.newvehicle.SetMod((VehicleMod) 33, this.SteeringWheelId, true);
      this.newvehicle.SetMod((VehicleMod) 41, this.StrutId, true);
      this.newvehicle.SetMod((VehicleMod) 15, this.SuspensionId, true);
      this.newvehicle.SetMod((VehicleMod) 45, this.TankId, true);
      this.newvehicle.SetMod((VehicleMod) 13, this.TransmissionId, true);
      this.newvehicle.SetMod((VehicleMod) 44, this.TrimId, true);
      this.newvehicle.SetMod((VehicleMod) 27, this.TrimDesignId, true);
      this.newvehicle.SetMod((VehicleMod) 37, this.TrunkId, true);
      this.newvehicle.SetMod((VehicleMod) 26, this.VanityPlatesId, true);
      this.newvehicle.SetMod((VehicleMod) 46, this.WindowId, true);
      this.newvehicle.SetMod((VehicleMod) 44, this.Blades, true);
      this.newvehicle.ToggleMod((VehicleToggleMod) 22, this.HasXenonLights);
      this.newvehicle.ToggleMod((VehicleToggleMod) 18, this.TurboActive);
      Function.Call((Hash) -2013052192277120505L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.newvehicle),
        InputArgument.op_Implicit(this.LightColor)
      });
      try
      {
        if (this.HasClanTag)
        {
          this.VE.CheckforEmblem(this.newvehicle);
          this.VE.CreateVehEmblem(this.newvehicle, Game.get_Player().get_Character());
        }
      }
      catch (Exception ex)
      {
      }
      if (this.RightNeonOn)
      {
        this.newvehicle.set_NeonLightsColor(this.NeonColor);
        this.newvehicle.SetNeonLightsOn((VehicleNeonLight) 1, true);
      }
      if (this.LeftNeonOn)
      {
        this.newvehicle.set_NeonLightsColor(this.NeonColor);
        this.newvehicle.SetNeonLightsOn((VehicleNeonLight) 0, true);
      }
      if (this.BackNeonOn)
      {
        this.newvehicle.set_NeonLightsColor(this.NeonColor);
        this.newvehicle.SetNeonLightsOn((VehicleNeonLight) 3, true);
      }
      if (this.FrontNeonOn)
      {
        this.newvehicle.set_NeonLightsColor(this.NeonColor);
        this.newvehicle.SetNeonLightsOn((VehicleNeonLight) 2, true);
      }
      this.newvehicle.set_WindowTint(this.TintId);
      this.newvehicle.set_PrimaryColor(this.PrimaryColor);
      this.newvehicle.set_SecondaryColor(this.SecondaryColor);
      this.newvehicle.set_PearlescentColor(this.PearlCent);
      this.newvehicle.set_NeonLightsColor(this.NeonColour);
      this.newvehicle.set_NumberPlate(this.PlanteNo);
      this.newvehicle.set_IsDriveable(false);
      this.SavedVehicle = this.newvehicle;
      this.newvehicle.set_EngineTorqueMultiplier(this.Torque);
      this.newvehicle.set_EnginePowerMultiplier(this.Power);
      this.newvehicle.ToggleMod((VehicleToggleMod) 20, this.TireSmoke);
      this.newvehicle.set_RimColor(this.Wheelcolour);
      this.newvehicle.set_DashboardColor(this.DashBoardColour);
      this.newvehicle.set_TireSmokeColor(this.TireSmokeColor);
      this.newvehicle.set_TrimColor(this.TrimColor);
      this.newvehicle.set_CanTiresBurst(this.BulletProofTires);
      for (int index = 0; index < 21; ++index)
      {
        if ((bool) this.Config.GetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) (this.ExtraOn[index] ? 1 : 0)))
          this.newvehicle.ToggleExtra(index, this.ExtraOn[index]);
      }
    }

    public void Load(Vehicle newvehicle)
    {
      this.VehicletoCheck = newvehicle;
      Model model1 = ((Entity) newvehicle).get_Model();
      int num;
      if (((Model) ref model1).get_IsInCdImage())
      {
        Model model2 = ((Entity) newvehicle).get_Model();
        if (((Model) ref model2).get_IsValid())
        {
          num = 1;
          goto label_4;
        }
      }
      num = Entity.op_Inequality((Entity) newvehicle, (Entity) null) ? 1 : 0;
label_4:
      if (num != 0)
      {
        this.RoofId = (int) this.Config.GetValue<int>("Configurations", "RoofId", (M0) this.RoofId);
        this.AerialsId = (int) this.Config.GetValue<int>("Configurations", "AerialsId", (M0) this.AerialsId);
        this.AirfilterId = (int) this.Config.GetValue<int>("Configurations", "AirfilterId", (M0) this.AirfilterId);
        this.ArchCoverId = (int) this.Config.GetValue<int>("Configurations", "ArchCoverId", (M0) this.ArchCoverId);
        this.ArmorId = (int) this.Config.GetValue<int>("Configurations", "ArmorId", (M0) this.ArmorId);
        this.BackWheelsId = (int) this.Config.GetValue<int>("Configurations", "BackWheelsId", (M0) this.BackWheelsId);
        this.BrakesId = (int) this.Config.GetValue<int>("Configurations", "BrakesId", (M0) this.BrakesId);
        this.ColumnShifterLeversId = (int) this.Config.GetValue<int>("Configurations", "ColumnShifterLeversId", (M0) this.ColumnShifterLeversId);
        this.DashboardId = (int) this.Config.GetValue<int>("Configurations", "DashboardId", (M0) this.DashboardId);
        this.DialDesignId = (int) this.Config.GetValue<int>("Configurations", "DialDesignId", (M0) this.DialDesignId);
        this.DoorSpeekersId = (int) this.Config.GetValue<int>("Configurations", "DoorSpeekersId", (M0) this.DoorSpeekersId);
        this.EngineId = (int) this.Config.GetValue<int>("Configurations", "EngineId", (M0) this.EngineId);
        this.EngineBlockId = (int) this.Config.GetValue<int>("Configurations", "EngineBlockId", (M0) this.EngineBlockId);
        this.ExaustId = (int) this.Config.GetValue<int>("Configurations", "ExaustId", (M0) this.ExaustId);
        this.FenderId = (int) this.Config.GetValue<int>("Configurations", "FenderId", (M0) this.FenderId);
        this.FrameId = (int) this.Config.GetValue<int>("Configurations", "FrameId", (M0) this.FrameId);
        this.FrontBumperId = (int) this.Config.GetValue<int>("Configurations", "FrontBumperId", (M0) this.FrontBumperId);
        this.FrontWheelsId = (int) this.Config.GetValue<int>("Configurations", "FrontWheelsId", (M0) this.FrontWheelsId);
        this.GrilleId = (int) this.Config.GetValue<int>("Configurations", "GrilleId", (M0) this.GrilleId);
        this.HoodId = (int) this.Config.GetValue<int>("Configurations", "HoodId", (M0) this.HoodId);
        this.HornsId = (int) this.Config.GetValue<int>("Configurations", "HornsId", (M0) this.HornsId);
        this.HydralicsId = (int) this.Config.GetValue<int>("Configurations", "HydralicsId", (M0) this.HydralicsId);
        this.LiveryId = (int) this.Config.GetValue<int>("Configurations", "LiveryId", (M0) this.LiveryId);
        this.OrnamentsId = (int) this.Config.GetValue<int>("Configurations", "OrnamentsId", (M0) this.OrnamentsId);
        this.PlaquesId = (int) this.Config.GetValue<int>("Configurations", "PlaquesId", (M0) this.PlaquesId);
        this.Plateholder = (int) this.Config.GetValue<int>("Configurations", "Plateholder", (M0) this.Plateholder);
        this.RearBumperId = (int) this.Config.GetValue<int>("Configurations", "RearBumperId", (M0) this.RearBumperId);
        this.RightFenderId = (int) this.Config.GetValue<int>("Configurations", "RightFenderId", (M0) this.RightFenderId);
        this.SeatsId = (int) this.Config.GetValue<int>("Configurations", "SeatsId", (M0) this.SeatsId);
        this.SideSkirt = (int) this.Config.GetValue<int>("Configurations", "SideSkirt", (M0) this.SideSkirt);
        this.speakers = (int) this.Config.GetValue<int>("Configurations", "speakers", (M0) this.speakers);
        this.SpoilersId = (int) this.Config.GetValue<int>("Configurations", "SpoilersId", (M0) this.SpoilersId);
        this.SteeringWheelId = (int) this.Config.GetValue<int>("Configurations", "SteeringWheelId", (M0) this.SteeringWheelId);
        this.StrutId = (int) this.Config.GetValue<int>("Configurations", "StrutId", (M0) this.StrutId);
        this.SuspensionId = (int) this.Config.GetValue<int>("Configurations", "SuspensionId", (M0) this.SuspensionId);
        this.TankId = (int) this.Config.GetValue<int>("Configurations", "TankId", (M0) this.TankId);
        this.TransmissionId = (int) this.Config.GetValue<int>("Configurations", "TransmissionId", (M0) this.TransmissionId);
        this.TrimId = (int) this.Config.GetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
        this.TrimDesignId = (int) this.Config.GetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
        this.TrunkId = (int) this.Config.GetValue<int>("Configurations", "TrunkId", (M0) this.TrunkId);
        this.VanityPlatesId = (int) this.Config.GetValue<int>("Configurations", "VanityPlatesId", (M0) this.VanityPlatesId);
        this.WindowId = (int) this.Config.GetValue<int>("Configurations", "WindowId", (M0) this.WindowId);
        this.PrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "PrimaryColor", (M0) this.PrimaryColor);
        this.SecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "SecondaryColor", (M0) this.SecondaryColor);
        this.Wheelcolour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
        this.DashBoardColour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
        this.PearlCent = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "PearlCent", (M0) this.PearlCent);
        this.NeonColour = (Color) this.Config.GetValue<Color>("Configurations", "NeonColour", (M0) this.NeonColour);
        this.TintId = (VehicleWindowTint) this.Config.GetValue<VehicleWindowTint>("Configurations", "TintId", (M0) this.TintId);
        this.PlanteNo = (string) this.Config.GetValue<string>("Configurations", "PlanteNo", (M0) this.PlanteNo);
        this.Blades = (int) this.Config.GetValue<int>("Configurations", "Blades", (M0) this.Blades);
        this.HasXenonLights = (bool) this.Config.GetValue<bool>("Configurations", "HasXenonLights", (M0) (this.HasXenonLights ? 1 : 0));
        this.TurboActive = (bool) this.Config.GetValue<bool>("Configurations", "TurboActive", (M0) (this.TurboActive ? 1 : 0));
        this.LightColor = (int) this.Config.GetValue<int>("Configurations", "LightColor", (M0) this.LightColor);
        this.NeonColor = (Color) this.Config.GetValue<Color>("Configurations", "NeonColor", (M0) this.NeonColor);
        this.RightNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "RightNeonOn", (M0) (this.RightNeonOn ? 1 : 0));
        this.LeftNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "LeftNeonOn", (M0) (this.LeftNeonOn ? 1 : 0));
        this.FrontNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "FrontNeonOn", (M0) (this.FrontNeonOn ? 1 : 0));
        this.BackNeonOn = (bool) this.Config.GetValue<bool>("Configurations", "BackNeonOn", (M0) (this.BackNeonOn ? 1 : 0));
        this.TrimColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "TrimColor", (M0) this.TrimColor);
        this.BulletProofTires = (bool) this.Config.GetValue<bool>("Configurations", "BulletProofTires", (M0) (this.BulletProofTires ? 1 : 0));
        try
        {
          this.Torque = (float) this.Config.GetValue<float>("Configurations", "Torque", (M0) (double) this.Torque);
          this.Power = (float) this.Config.GetValue<float>("Configurations", "Power", (M0) (double) this.Power);
        }
        catch
        {
          this.Torque = 1f;
          this.Config.SetValue<float>("Configurations", "Torque", (M0) (double) this.Torque);
          this.Power = 1f;
          this.Config.SetValue<float>("Configurations", "Power", (M0) (double) this.Power);
          this.Config.Save();
        }
        this.Wheelcolour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
        this.DashBoardColour = (VehicleColor) this.Config.GetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
        this.TireSmokeColor = (Color) this.Config.GetValue<Color>("Configurations", "TireSmokeColor", (M0) this.TireSmokeColor);
        this.TireSmoke = (bool) this.Config.GetValue<bool>("Configurations", "TireSmoke", (M0) (this.TireSmoke ? 1 : 0));
        this.HasClanTag = (bool) this.Config.GetValue<bool>("Configurations", "CLanTagOn", (M0) (this.HasClanTag ? 1 : 0));
        this.ExtraOn.Clear();
        for (int index = 0; index < 21; ++index)
        {
          if ((bool) this.Config.GetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) 1))
            this.ExtraOn.Add(true);
          else
            this.ExtraOn.Add(false);
        }
        Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
        {
          InputArgument.op_Implicit(((Entity) newvehicle).get_Handle()),
          InputArgument.op_Implicit(0)
        });
        newvehicle.SetMod((VehicleMod) 48, this.LiveryId, false);
        newvehicle.SetMod((VehicleMod) 10, this.RoofId, true);
        newvehicle.SetMod((VehicleMod) 43, this.AerialsId, true);
        newvehicle.SetMod((VehicleMod) 40, this.AirfilterId, true);
        newvehicle.SetMod((VehicleMod) 42, this.ArchCoverId, true);
        newvehicle.SetMod((VehicleMod) 16, this.ArmorId, true);
        newvehicle.SetMod((VehicleMod) 24, this.BackWheelsId, true);
        newvehicle.SetMod((VehicleMod) 12, this.BrakesId, true);
        newvehicle.SetMod((VehicleMod) 34, this.ColumnShifterLeversId, true);
        newvehicle.SetMod((VehicleMod) 29, this.DashboardId, true);
        newvehicle.SetMod((VehicleMod) 30, this.DialDesignId, true);
        newvehicle.SetMod((VehicleMod) 31, this.DoorSpeekersId, true);
        newvehicle.SetMod((VehicleMod) 11, this.EngineId, true);
        newvehicle.SetMod((VehicleMod) 39, this.EngineBlockId, true);
        newvehicle.SetMod((VehicleMod) 4, this.ExaustId, true);
        newvehicle.SetMod((VehicleMod) 8, this.FenderId, true);
        newvehicle.SetMod((VehicleMod) 5, this.FrameId, true);
        newvehicle.SetMod((VehicleMod) 1, this.FrontBumperId, true);
        newvehicle.SetMod((VehicleMod) 23, this.FrontWheelsId, true);
        newvehicle.SetMod((VehicleMod) 6, this.GrilleId, true);
        newvehicle.SetMod((VehicleMod) 7, this.HoodId, true);
        newvehicle.SetMod((VehicleMod) 14, this.HornsId, true);
        newvehicle.SetMod((VehicleMod) 38, this.HydralicsId, true);
        newvehicle.SetMod((VehicleMod) 48, this.LiveryId, false);
        newvehicle.SetMod((VehicleMod) 28, this.OrnamentsId, true);
        newvehicle.SetMod((VehicleMod) 35, this.PlaquesId, true);
        newvehicle.SetMod((VehicleMod) 25, this.Plateholder, true);
        newvehicle.SetMod((VehicleMod) 2, this.RearBumperId, true);
        newvehicle.SetMod((VehicleMod) 9, this.RightFenderId, true);
        newvehicle.SetMod((VehicleMod) 32, this.SeatsId, true);
        newvehicle.SetMod((VehicleMod) 3, this.SideSkirt, true);
        newvehicle.SetMod((VehicleMod) 36, this.speakers, true);
        newvehicle.SetMod((VehicleMod) 0, this.SpoilersId, true);
        newvehicle.SetMod((VehicleMod) 33, this.SteeringWheelId, true);
        newvehicle.SetMod((VehicleMod) 41, this.StrutId, true);
        newvehicle.SetMod((VehicleMod) 15, this.SuspensionId, true);
        newvehicle.SetMod((VehicleMod) 45, this.TankId, true);
        newvehicle.SetMod((VehicleMod) 13, this.TransmissionId, true);
        newvehicle.SetMod((VehicleMod) 44, this.TrimId, true);
        newvehicle.SetMod((VehicleMod) 27, this.TrimDesignId, true);
        newvehicle.SetMod((VehicleMod) 37, this.TrunkId, true);
        newvehicle.SetMod((VehicleMod) 26, this.VanityPlatesId, true);
        newvehicle.SetMod((VehicleMod) 46, this.WindowId, true);
        newvehicle.SetMod((VehicleMod) 44, this.Blades, true);
        newvehicle.ToggleMod((VehicleToggleMod) 22, this.HasXenonLights);
        newvehicle.ToggleMod((VehicleToggleMod) 18, this.TurboActive);
        Function.Call((Hash) -2013052192277120505L, new InputArgument[2]
        {
          InputArgument.op_Implicit(newvehicle),
          InputArgument.op_Implicit(this.LightColor)
        });
        newvehicle.set_EngineTorqueMultiplier(this.Torque);
        newvehicle.set_EnginePowerMultiplier(this.Power);
        try
        {
          if (this.HasClanTag)
          {
            this.VE.CheckforEmblem(newvehicle);
            this.VE.CreateVehEmblem(newvehicle, Game.get_Player().get_Character());
          }
        }
        catch (Exception ex)
        {
        }
        if (this.RightNeonOn)
        {
          newvehicle.set_NeonLightsColor(this.NeonColor);
          newvehicle.SetNeonLightsOn((VehicleNeonLight) 1, true);
        }
        if (this.LeftNeonOn)
        {
          newvehicle.set_NeonLightsColor(this.NeonColor);
          newvehicle.SetNeonLightsOn((VehicleNeonLight) 0, true);
        }
        if (this.BackNeonOn)
        {
          newvehicle.set_NeonLightsColor(this.NeonColor);
          newvehicle.SetNeonLightsOn((VehicleNeonLight) 3, true);
        }
        if (this.FrontNeonOn)
        {
          newvehicle.set_NeonLightsColor(this.NeonColor);
          newvehicle.SetNeonLightsOn((VehicleNeonLight) 2, true);
        }
        newvehicle.set_WindowTint(this.TintId);
        newvehicle.set_PrimaryColor(this.PrimaryColor);
        newvehicle.set_SecondaryColor(this.SecondaryColor);
        newvehicle.set_RimColor(this.Wheelcolour);
        newvehicle.set_DashboardColor(this.DashBoardColour);
        newvehicle.set_PearlescentColor(this.PearlCent);
        newvehicle.set_NeonLightsColor(this.NeonColour);
        newvehicle.set_NumberPlate(this.PlanteNo);
        newvehicle.set_IsDriveable(false);
        this.SavedVehicle = newvehicle;
        newvehicle.ToggleMod((VehicleToggleMod) 20, this.TireSmoke);
        newvehicle.set_RimColor(this.Wheelcolour);
        newvehicle.set_DashboardColor(this.DashBoardColour);
        newvehicle.set_TireSmokeColor(this.TireSmokeColor);
        newvehicle.set_TrimColor(this.TrimColor);
        newvehicle.set_CanTiresBurst(this.BulletProofTires);
        for (int index = 0; index < 21; ++index)
        {
          if ((bool) this.Config.GetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) (this.ExtraOn[index] ? 1 : 0)))
            newvehicle.ToggleExtra(index, this.ExtraOn[index]);
        }
        this.VehicleHash = ((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit(newvehicle.get_DisplayName())
        })).ToString();
        this.Config.SetValue<string>("Configurations", "VehicleHash", (M0) this.VehicleHash);
        this.Config.Save();
      }
      else
        UI.Notify("~r~Error~w~: " + (object) this.VehicletoCheck + " is not a Base Game vehicle or has issues with saving, contack HKH191 for more info or help!");
    }

    public Model RequestModel(string Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
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

    public Model CheckCar(string iniName)
    {
      this.LoadIniFile(iniName);
      this.VehicleName = (string) this.Config.GetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
      if (this.VehicleName == "CARBON")
        this.VehicleName = "CARBONRS";
      if (this.VehicleName == "UTILTRUC")
        this.VehicleName = "UTILLITRUCK";
      if (this.VehicleName == "FORK")
        this.VehicleName = "FORKLIFT";
      if (this.VehicleName == "LANDSTAL")
        this.VehicleName = "LANDSTALKER";
      if (this.VehicleName == "CAVCADE")
        this.VehicleName = "CAVALCADE";
      if (this.VehicleName == "SANCHEZ02")
        this.VehicleName = "SANCHEZ2";
      if (this.VehicleName == "SANCHEZ01")
        this.VehicleName = "SANCHEZ";
      if (this.VehicleName == "FAGGION")
        this.VehicleName = "FAGGIO";
      if (this.VehicleName == "STINGERG")
        this.VehicleName = "FELTZER3";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "KHAMEL")
        this.VehicleName = "KHAMELION";
      if (this.VehicleName == "FURORE")
        this.VehicleName = "FUROREGT";
      if (this.VehicleName == "COGCABRI")
        this.VehicleName = "COGCABRIO";
      if (this.VehicleName == "RLOADER")
        this.VehicleName = "RATLOADER";
      if (this.VehicleName == "RLOADER2")
        this.VehicleName = "RATLOADER2";
      if (this.VehicleName == "FELTZER")
        this.VehicleName = "FELTZER2";
      if (this.VehicleName == "WASHINGT")
        this.VehicleName = "WASHINGTON";
      if (this.VehicleName == "BUFFALO02")
        this.VehicleName = "BUFFALO2";
      if (this.VehicleName == "TAILGATE")
        this.VehicleName = "TAILGATER";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "ASTROPE")
        this.VehicleName = "ASTEROPE";
      if (this.VehicleName == "SANDKIN2")
        this.VehicleName = "SANDKING2";
      if (this.VehicleName == "REBEL02")
        this.VehicleName = "REBEL2";
      if (this.VehicleName == "REBEL01")
        this.VehicleName = "REBEL";
      if (this.VehicleName == "RANCHERX")
        this.VehicleName = "RANCHERXL";
      if (this.VehicleName == "BFINJECT")
        this.VehicleName = "BFINJECTION";
      if (this.VehicleName == "DOMINATO2")
        this.VehicleName = "DOMINATOR2";
      if (this.VehicleName == "DILETTAN")
        this.VehicleName = "DILETTANTE";
      if (this.VehicleName == "VOODOO2")
        this.VehicleName = "VOODOO";
      else if (this.VehicleName == "VOODOO")
        this.VehicleName = "VOODOO2";
      if (this.VehicleName == "ABMULAN")
        this.VehicleName = "AMBULANCE";
      if (this.VehicleName == "Ruiner3")
        this.VehicleName = "Ruiner3";
      if (this.VehicleName == "BUCCANEE2")
        this.VehicleName = "BUCCANEER2";
      if (this.VehicleName == "BUCCANEE")
        this.VehicleName = "BUCCANEER";
      if (this.VehicleName == "CARBONIZ")
        this.VehicleName = "CARBONIZZARE";
      if (this.VehicleName == "penetrator")
        this.VehicleName = "PENETRATOR";
      if (this.VehicleName == "TROPHY")
        this.VehicleName = "TROPHYTRUCK";
      if (this.VehicleName == "TROPHY2")
        this.VehicleName = "TROPHYTRUCK2";
      if (this.VehicleName == "ROOSEVELT")
        this.VehicleName = "Btype";
      if (this.VehicleName == "VERLIER")
        this.VehicleName = "VERLIERER2";
      if (this.VehicleName == "BTYPE2")
        this.VehicleName = "Btype2";
      if (this.VehicleName == "ROOSEVELT2")
        this.VehicleName = "Btype3";
      if (this.VehicleName == "DOMINATO")
        this.VehicleName = "DOMINATOR";
      if (this.VehicleName == "NITESHAD")
        this.VehicleName = "NIGHTSHADE";
      Model model;
      ((Model) ref model).\u002Ector(this.VehicleName);
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

    public void SaveWithoutDelete()
    {
      if (!Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
        return;
      this.VehicleName = Game.get_Player().get_Character().get_CurrentVehicle().get_DisplayName();
      this.RoofId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 10);
      this.AerialsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 43);
      this.AirfilterId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 40);
      this.ArchCoverId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 42);
      this.ArmorId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 16);
      this.BackWheelsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 24);
      this.BrakesId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 12);
      this.ColumnShifterLeversId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 34);
      this.DashboardId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 29);
      this.DialDesignId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 30);
      this.DoorSpeekersId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 31);
      this.EngineId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 11);
      this.EngineBlockId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 39);
      this.ExaustId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 4);
      this.FenderId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 8);
      this.FrameId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 5);
      this.FrontBumperId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 1);
      this.FrontWheelsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 23);
      this.GrilleId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 6);
      this.HoodId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 7);
      this.HornsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 14);
      this.HydralicsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 38);
      this.LiveryId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 48);
      this.OrnamentsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 28);
      this.PlaquesId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 35);
      this.Plateholder = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 25);
      this.RearBumperId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 2);
      this.RightFenderId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 9);
      this.SeatsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 32);
      this.SideSkirt = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 3);
      this.speakers = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 36);
      this.SpoilersId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 0);
      this.SteeringWheelId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 33);
      this.StrutId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 41);
      this.SuspensionId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 15);
      this.TankId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 45);
      this.TransmissionId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 13);
      this.TrimId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 44);
      this.TrimDesignId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 27);
      this.TrunkId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 37);
      this.VanityPlatesId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 26);
      this.WindowId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 46);
      this.PrimaryColor = Game.get_Player().get_Character().get_CurrentVehicle().get_PrimaryColor();
      this.SecondaryColor = Game.get_Player().get_Character().get_CurrentVehicle().get_SecondaryColor();
      this.TintId = Game.get_Player().get_Character().get_CurrentVehicle().get_WindowTint();
      this.Wheelcolour = Game.get_Player().get_Character().get_CurrentVehicle().get_RimColor();
      this.DashBoardColour = Game.get_Player().get_Character().get_CurrentVehicle().get_DashboardColor();
      this.PearlCent = Game.get_Player().get_Character().get_CurrentVehicle().get_PearlescentColor();
      this.NeonColour = Game.get_Player().get_Character().get_CurrentVehicle().get_NeonLightsColor();
      this.PlanteNo = Game.get_Player().get_Character().get_CurrentVehicle().get_NumberPlate();
      this.Blades = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 44);
      Vehicle currentVehicle = Game.get_Player().get_Character().get_CurrentVehicle();
      this.HasXenonLights = currentVehicle.IsToggleModOn((VehicleToggleMod) 22);
      this.TurboActive = currentVehicle.IsToggleModOn((VehicleToggleMod) 18);
      this.LightColor = (int) Function.Call<int>((Hash) 4467343895069330651L, new InputArgument[1]
      {
        InputArgument.op_Implicit(currentVehicle)
      });
      this.RightNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 1);
      this.LeftNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 0);
      this.BackNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 3);
      this.FrontNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 2);
      this.NeonColor = currentVehicle.get_NeonLightsColor();
      this.TireSmoke = currentVehicle.IsToggleModOn((VehicleToggleMod) 20);
      this.Wheelcolour = currentVehicle.get_RimColor();
      this.DashBoardColour = currentVehicle.get_DashboardColor();
      this.TireSmokeColor = currentVehicle.get_TireSmokeColor();
      this.VehicleHash = ((object) Game.get_Player().get_Character().get_CurrentVehicle()).GetHashCode().ToString();
      this.BulletProofTires = currentVehicle.get_CanTiresBurst();
      this.TrimColor = currentVehicle.get_TrimColor();
      try
      {
        this.HasClanTag = this.VE.ReturnClanEmblemOn(currentVehicle);
        this.Config.SetValue<bool>("Configurations", "CLanTagOn", (M0) (this.HasClanTag ? 1 : 0));
      }
      catch (Exception ex)
      {
      }
      if (this.VehicleName == "CARBON")
        this.VehicleName = "CARBONRS";
      if (this.VehicleName == "UTILTRUC")
        this.VehicleName = "UTILLITRUCK";
      if (this.VehicleName == "FORK")
        this.VehicleName = "FORKLIFT";
      if (this.VehicleName == "LANDSTAL")
        this.VehicleName = "LANDSTALKER";
      if (this.VehicleName == "CAVCADE")
        this.VehicleName = "CAVALCADE";
      if (this.VehicleName == "SANCHEZ02")
        this.VehicleName = "SANCHEZ2";
      if (this.VehicleName == "SANCHEZ01")
        this.VehicleName = "SANCHEZ";
      if (this.VehicleName == "FAGGION")
        this.VehicleName = "FAGGIO";
      if (this.VehicleName == "STINGERG")
        this.VehicleName = "FELTZER3";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "KHAMEL")
        this.VehicleName = "KHAMELION";
      if (this.VehicleName == "FURORE")
        this.VehicleName = "FUROREGT";
      if (this.VehicleName == "COGCABRI")
        this.VehicleName = "COGCABRIO";
      if (this.VehicleName == "RLOADER")
        this.VehicleName = "RATLOADER";
      if (this.VehicleName == "RLOADER2")
        this.VehicleName = "RATLOADER2";
      if (this.VehicleName == "FELTZER")
        this.VehicleName = "FELTZER2";
      if (this.VehicleName == "WASHINGT")
        this.VehicleName = "WASHINGTON";
      if (this.VehicleName == "BUFFALO02")
        this.VehicleName = "BUFFALO2";
      if (this.VehicleName == "TAILGATE")
        this.VehicleName = "TAILGATER";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "ASTROPE")
        this.VehicleName = "ASTEROPE";
      if (this.VehicleName == "SANDKIN2")
        this.VehicleName = "SANDKING2";
      if (this.VehicleName == "REBEL02")
        this.VehicleName = "REBEL2";
      if (this.VehicleName == "REBEL01")
        this.VehicleName = "REBEL";
      if (this.VehicleName == "RANCHERX")
        this.VehicleName = "RANCHERXL";
      if (this.VehicleName == "BFINJECT")
        this.VehicleName = "BFINJECTION";
      if (this.VehicleName == "DOMINATO2")
        this.VehicleName = "DOMINATOR2";
      if (this.VehicleName == "DILETTAN")
        this.VehicleName = "DILETTANTE";
      if (this.VehicleName == "VOODOO2")
        this.VehicleName = "VOODOO";
      else if (this.VehicleName == "VOODOO")
        this.VehicleName = "VOODOO2";
      if (this.VehicleName == "ABMULAN")
        this.VehicleName = "AMBULANCE";
      if (this.VehicleName == "Ruiner3")
        this.VehicleName = "Ruiner3";
      if (this.VehicleName == "BUCCANEE2")
        this.VehicleName = "BUCCANEER2";
      if (this.VehicleName == "BUCCANEE")
        this.VehicleName = "BUCCANEER";
      if (this.VehicleName == "CARBONIZ")
        this.VehicleName = "CARBONIZZARE";
      if (this.VehicleName == "penetrator")
        this.VehicleName = "PENETRATOR";
      if (this.VehicleName == "TROPHY")
        this.VehicleName = "TROPHYTRUCK";
      if (this.VehicleName == "TROPHY2")
        this.VehicleName = "TROPHYTRUCK2";
      if (this.VehicleName == "ROOSEVELT")
        this.VehicleName = "Btype";
      if (this.VehicleName == "VERLIER")
        this.VehicleName = "VERLIERER2";
      if (this.VehicleName == "BTYPE2")
        this.VehicleName = "Btype2";
      if (this.VehicleName == "ROOSEVELT2")
        this.VehicleName = "Btype3";
      if (this.VehicleName == "DOMINATO")
        this.VehicleName = "DOMINATOR";
      if (this.VehicleName == "NITESHAD")
        this.VehicleName = "NIGHTSHADE";
      this.Config.SetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
      this.Config.SetValue<int>("Configurations", "Roof", (M0) this.RoofId);
      this.Config.SetValue<int>("Configurations", "AerialsId", (M0) this.AerialsId);
      this.Config.SetValue<int>("Configurations", "AirfilterId", (M0) this.AirfilterId);
      this.Config.SetValue<int>("Configurations", "ArchCoverId", (M0) this.ArchCoverId);
      this.Config.SetValue<int>("Configurations", "ArmorId", (M0) this.ArmorId);
      this.Config.SetValue<int>("Configurations", "BackWheelsId", (M0) this.BackWheelsId);
      this.Config.SetValue<int>("Configurations", "BrakesId", (M0) this.BrakesId);
      this.Config.SetValue<int>("Configurations", "ColumnShifterLeversId", (M0) this.ColumnShifterLeversId);
      this.Config.SetValue<int>("Configurations", "DashboardId", (M0) this.DashboardId);
      this.Config.SetValue<int>("Configurations", "DialDesignId", (M0) this.DialDesignId);
      this.Config.SetValue<int>("Configurations", "DoorSpeekersId", (M0) this.DoorSpeekersId);
      this.Config.SetValue<int>("Configurations", "EngineId", (M0) this.EngineId);
      this.Config.SetValue<int>("Configurations", "EngineBlockId", (M0) this.EngineBlockId);
      this.Config.SetValue<int>("Configurations", "ExaustId", (M0) this.ExaustId);
      this.Config.SetValue<int>("Configurations", "FenderId", (M0) this.FenderId);
      this.Config.SetValue<int>("Configurations", "FrameId", (M0) this.FrameId);
      this.Config.SetValue<int>("Configurations", "FrontBumperId", (M0) this.FrontBumperId);
      this.Config.SetValue<int>("Configurations", "FrontWheelsId", (M0) this.FrontWheelsId);
      this.Config.SetValue<int>("Configurations", "GrilleId", (M0) this.GrilleId);
      this.Config.SetValue<int>("Configurations", "HoodId", (M0) this.HoodId);
      this.Config.SetValue<int>("Configurations", "HornsId", (M0) this.HornsId);
      this.Config.SetValue<int>("Configurations", "HydralicsId", (M0) this.HydralicsId);
      this.Config.SetValue<int>("Configurations", "LiveryId", (M0) this.LiveryId);
      this.Config.SetValue<int>("Configurations", "OrnamentsId", (M0) this.OrnamentsId);
      this.Config.SetValue<int>("Configurations", "PlaquesId", (M0) this.PlaquesId);
      this.Config.SetValue<int>("Configurations", "Plateholder", (M0) this.Plateholder);
      this.Config.SetValue<int>("Configurations", "RearBumperId", (M0) this.RearBumperId);
      this.Config.SetValue<int>("Configurations", "RightFenderId", (M0) this.RightFenderId);
      this.Config.SetValue<int>("Configurations", "SeatsId", (M0) this.SeatsId);
      this.Config.SetValue<int>("Configurations", "speakers", (M0) this.speakers);
      this.Config.SetValue<int>("Configurations", "speakers", (M0) this.speakers);
      this.Config.SetValue<int>("Configurations", "SpoilersId", (M0) this.SpoilersId);
      this.Config.SetValue<int>("Configurations", "SteeringWheelId", (M0) this.SteeringWheelId);
      this.Config.SetValue<int>("Configurations", "StrutId", (M0) this.StrutId);
      this.Config.SetValue<int>("Configurations", "RoofId", (M0) this.RoofId);
      this.Config.SetValue<int>("Configurations", "SuspensionId", (M0) this.SuspensionId);
      this.Config.SetValue<int>("Configurations", "TransmissionId", (M0) this.TransmissionId);
      this.Config.SetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.Config.SetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.Config.SetValue<int>("Configurations", "TrunkId", (M0) this.TrunkId);
      this.Config.SetValue<int>("Configurations", "VanityPlatesId", (M0) this.VanityPlatesId);
      this.Config.SetValue<int>("Configurations", "WindowId", (M0) this.WindowId);
      this.Config.SetValue<VehicleWindowTint>("Configurations", "TintId", (M0) this.TintId);
      this.Config.SetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.Config.SetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.Config.SetValue<VehicleColor>("Configurations", "PearlCent", (M0) this.PearlCent);
      this.Config.SetValue<Color>("Configurations", "NeonColour", (M0) this.NeonColour);
      this.Config.SetValue<string>("Configurations", "PlanteNo", (M0) this.PlanteNo);
      this.Config.SetValue<VehicleColor>("Configurations", "PrimaryColor", (M0) this.PrimaryColor);
      this.Config.SetValue<VehicleColor>("Configurations", "SecondaryColor", (M0) this.SecondaryColor);
      this.Config.SetValue<int>("Configurations", "Blades", (M0) this.Blades);
      this.Config.SetValue<bool>("Configurations", "HasXenonLights", (M0) (this.HasXenonLights ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "TurboActive", (M0) (this.TurboActive ? 1 : 0));
      this.Config.SetValue<int>("Configurations", "LightColor", (M0) this.LightColor);
      this.Config.SetValue<string>("Configurations", "VehicleHash", (M0) this.VehicleHash);
      this.Config.SetValue<Color>("Configurations", "NeonColor", (M0) this.NeonColor);
      this.Config.SetValue<bool>("Configurations", "RightNeonOn", (M0) (this.RightNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "LeftNeonOn", (M0) (this.LeftNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "FrontNeonOn", (M0) (this.FrontNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "BackNeonOn", (M0) (this.BackNeonOn ? 1 : 0));
      this.Config.SetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.Config.SetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.Config.SetValue<Color>("Configurations", "TireSmokeColor", (M0) this.TireSmokeColor);
      this.Config.SetValue<bool>("Configurations", "TireSmoke", (M0) (this.TireSmoke ? 1 : 0));
      this.Config.SetValue<VehicleColor>("Configurations", "TrimColor", (M0) this.TrimColor);
      this.Config.SetValue<bool>("Configurations", "BulletProofTires", (M0) (this.BulletProofTires ? 1 : 0));
      if (this.ExtraOn.Count >= 1)
      {
        for (int index = 0; index < this.ExtraOn.Count; ++index)
          this.Config.SetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) (this.ExtraOn[index] ? 1 : 0));
      }
      this.Config.Save();
      if (this.VehicleName == "VOODOO2")
        this.VehicleName = "VOODOO";
      else if (this.VehicleName == "VOODOO")
        this.VehicleName = "VOODOO2";
    }

    public void Save()
    {
      if (!Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
        return;
      this.VehicleName = Game.get_Player().get_Character().get_CurrentVehicle().get_DisplayName();
      this.RoofId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 10);
      this.AerialsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 43);
      this.AirfilterId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 40);
      this.ArchCoverId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 42);
      this.ArmorId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 16);
      this.BackWheelsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 24);
      this.BrakesId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 12);
      this.ColumnShifterLeversId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 34);
      this.DashboardId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 29);
      this.DialDesignId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 30);
      this.DoorSpeekersId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 31);
      this.EngineId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 11);
      this.EngineBlockId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 39);
      this.ExaustId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 4);
      this.FenderId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 8);
      this.FrameId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 5);
      this.FrontBumperId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 1);
      this.FrontWheelsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 23);
      this.GrilleId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 6);
      this.HoodId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 7);
      this.HornsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 14);
      this.HydralicsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 38);
      this.LiveryId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 48);
      this.OrnamentsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 28);
      this.PlaquesId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 35);
      this.Plateholder = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 25);
      this.RearBumperId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 2);
      this.RightFenderId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 9);
      this.SeatsId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 32);
      this.SideSkirt = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 3);
      this.speakers = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 36);
      this.SpoilersId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 0);
      this.SteeringWheelId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 33);
      this.StrutId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 41);
      this.SuspensionId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 15);
      this.TankId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 45);
      this.TransmissionId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 13);
      this.TrimId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 44);
      this.TrimDesignId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 27);
      this.TrunkId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 37);
      this.VanityPlatesId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 26);
      this.WindowId = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 46);
      this.PrimaryColor = Game.get_Player().get_Character().get_CurrentVehicle().get_PrimaryColor();
      this.SecondaryColor = Game.get_Player().get_Character().get_CurrentVehicle().get_SecondaryColor();
      this.Wheelcolour = Game.get_Player().get_Character().get_CurrentVehicle().get_RimColor();
      this.DashBoardColour = Game.get_Player().get_Character().get_CurrentVehicle().get_DashboardColor();
      this.PearlCent = Game.get_Player().get_Character().get_CurrentVehicle().get_PearlescentColor();
      this.NeonColour = Game.get_Player().get_Character().get_CurrentVehicle().get_NeonLightsColor();
      this.TintId = Game.get_Player().get_Character().get_CurrentVehicle().get_WindowTint();
      this.PlanteNo = Game.get_Player().get_Character().get_CurrentVehicle().get_NumberPlate();
      this.Blades = Game.get_Player().get_Character().get_CurrentVehicle().GetMod((VehicleMod) 44);
      Vehicle currentVehicle = Game.get_Player().get_Character().get_CurrentVehicle();
      this.HasXenonLights = currentVehicle.IsToggleModOn((VehicleToggleMod) 22);
      this.TurboActive = currentVehicle.IsToggleModOn((VehicleToggleMod) 18);
      this.LightColor = (int) Function.Call<int>((Hash) 4467343895069330651L, new InputArgument[1]
      {
        InputArgument.op_Implicit(currentVehicle)
      });
      this.VehicleHash = ((object) Game.get_Player().get_Character().get_CurrentVehicle()).GetHashCode().ToString();
      this.RightNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 1);
      this.LeftNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 0);
      this.BackNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 3);
      this.FrontNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 2);
      this.NeonColor = currentVehicle.get_NeonLightsColor();
      this.BulletProofTires = currentVehicle.get_CanTiresBurst();
      this.TrimColor = currentVehicle.get_TrimColor();
      this.TireSmoke = currentVehicle.IsToggleModOn((VehicleToggleMod) 20);
      this.Wheelcolour = currentVehicle.get_RimColor();
      this.DashBoardColour = currentVehicle.get_DashboardColor();
      this.TireSmokeColor = currentVehicle.get_TireSmokeColor();
      try
      {
        this.HasClanTag = this.VE.ReturnClanEmblemOn(currentVehicle);
        this.Config.SetValue<bool>("Configurations", "CLanTagOn", (M0) (this.HasClanTag ? 1 : 0));
      }
      catch (Exception ex)
      {
      }
      if (this.VehicleName == "CARBON")
        this.VehicleName = "CARBONRS";
      if (this.VehicleName == "UTILTRUC")
        this.VehicleName = "UTILLITRUCK";
      if (this.VehicleName == "FORK")
        this.VehicleName = "FORKLIFT";
      if (this.VehicleName == "LANDSTAL")
        this.VehicleName = "LANDSTALKER";
      if (this.VehicleName == "CAVCADE")
        this.VehicleName = "CAVALCADE";
      if (this.VehicleName == "SANCHEZ02")
        this.VehicleName = "SANCHEZ2";
      if (this.VehicleName == "SANCHEZ01")
        this.VehicleName = "SANCHEZ";
      if (this.VehicleName == "FAGGION")
        this.VehicleName = "FAGGIO";
      if (this.VehicleName == "STINGERG")
        this.VehicleName = "FELTZER3";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "KHAMEL")
        this.VehicleName = "KHAMELION";
      if (this.VehicleName == "FURORE")
        this.VehicleName = "FUROREGT";
      if (this.VehicleName == "COGCABRI")
        this.VehicleName = "COGCABRIO";
      if (this.VehicleName == "RLOADER")
        this.VehicleName = "RATLOADER";
      if (this.VehicleName == "RLOADER2")
        this.VehicleName = "RATLOADER2";
      if (this.VehicleName == "FELTZER")
        this.VehicleName = "FELTZER2";
      if (this.VehicleName == "WASHINGT")
        this.VehicleName = "WASHINGTON";
      if (this.VehicleName == "BUFFALO02")
        this.VehicleName = "BUFFALO2";
      if (this.VehicleName == "TAILGATE")
        this.VehicleName = "TAILGATER";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "ASTROPE")
        this.VehicleName = "ASTEROPE";
      if (this.VehicleName == "SANDKIN2")
        this.VehicleName = "SANDKING2";
      if (this.VehicleName == "REBEL02")
        this.VehicleName = "REBEL2";
      if (this.VehicleName == "REBEL01")
        this.VehicleName = "REBEL";
      if (this.VehicleName == "RANCHERX")
        this.VehicleName = "RANCHERXL";
      if (this.VehicleName == "BFINJECT")
        this.VehicleName = "BFINJECTION";
      if (this.VehicleName == "DOMINATO2")
        this.VehicleName = "DOMINATOR2";
      if (this.VehicleName == "DILETTAN")
        this.VehicleName = "DILETTANTE";
      if (this.VehicleName == "VOODOO2")
        this.VehicleName = "VOODOO";
      else if (this.VehicleName == "VOODOO")
        this.VehicleName = "VOODOO2";
      if (this.VehicleName == "ABMULAN")
        this.VehicleName = "AMBULANCE";
      if (this.VehicleName == "Ruiner3")
        this.VehicleName = "Ruiner3";
      if (this.VehicleName == "BUCCANEE2")
        this.VehicleName = "BUCCANEER2";
      if (this.VehicleName == "BUCCANEE")
        this.VehicleName = "BUCCANEER";
      if (this.VehicleName == "CARBONIZ")
        this.VehicleName = "CARBONIZZARE";
      if (this.VehicleName == "penetrator")
        this.VehicleName = "PENETRATOR";
      if (this.VehicleName == "TROPHY")
        this.VehicleName = "TROPHYTRUCK";
      if (this.VehicleName == "TROPHY2")
        this.VehicleName = "TROPHYTRUCK2";
      if (this.VehicleName == "ROOSEVELT")
        this.VehicleName = "Btype";
      if (this.VehicleName == "VERLIER")
        this.VehicleName = "VERLIERER2";
      if (this.VehicleName == "BTYPE2")
        this.VehicleName = "Btype2";
      if (this.VehicleName == "ROOSEVELT2")
        this.VehicleName = "Btype3";
      if (this.VehicleName == "DOMINATO")
        this.VehicleName = "DOMINATOR";
      if (this.VehicleName == "NITESHAD")
        this.VehicleName = "NIGHTSHADE";
      this.Config.SetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
      this.Config.SetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
      this.Config.SetValue<int>("Configurations", "Roof", (M0) this.RoofId);
      this.Config.SetValue<int>("Configurations", "AerialsId", (M0) this.AerialsId);
      this.Config.SetValue<int>("Configurations", "AirfilterId", (M0) this.AirfilterId);
      this.Config.SetValue<int>("Configurations", "ArchCoverId", (M0) this.ArchCoverId);
      this.Config.SetValue<int>("Configurations", "ArmorId", (M0) this.ArmorId);
      this.Config.SetValue<int>("Configurations", "BackWheelsId", (M0) this.BackWheelsId);
      this.Config.SetValue<int>("Configurations", "BrakesId", (M0) this.BrakesId);
      this.Config.SetValue<int>("Configurations", "ColumnShifterLeversId", (M0) this.ColumnShifterLeversId);
      this.Config.SetValue<int>("Configurations", "DashboardId", (M0) this.DashboardId);
      this.Config.SetValue<int>("Configurations", "DialDesignId", (M0) this.DialDesignId);
      this.Config.SetValue<int>("Configurations", "DoorSpeekersId", (M0) this.DoorSpeekersId);
      this.Config.SetValue<int>("Configurations", "EngineId", (M0) this.EngineId);
      this.Config.SetValue<int>("Configurations", "EngineBlockId", (M0) this.EngineBlockId);
      this.Config.SetValue<int>("Configurations", "ExaustId", (M0) this.ExaustId);
      this.Config.SetValue<int>("Configurations", "FenderId", (M0) this.FenderId);
      this.Config.SetValue<int>("Configurations", "FrameId", (M0) this.FrameId);
      this.Config.SetValue<int>("Configurations", "FrontBumperId", (M0) this.FrontBumperId);
      this.Config.SetValue<int>("Configurations", "FrontWheelsId", (M0) this.FrontWheelsId);
      this.Config.SetValue<int>("Configurations", "GrilleId", (M0) this.GrilleId);
      this.Config.SetValue<int>("Configurations", "HoodId", (M0) this.HoodId);
      this.Config.SetValue<int>("Configurations", "HornsId", (M0) this.HornsId);
      this.Config.SetValue<int>("Configurations", "HydralicsId", (M0) this.HydralicsId);
      this.Config.SetValue<int>("Configurations", "LiveryId", (M0) this.LiveryId);
      this.Config.SetValue<int>("Configurations", "OrnamentsId", (M0) this.OrnamentsId);
      this.Config.SetValue<int>("Configurations", "PlaquesId", (M0) this.PlaquesId);
      this.Config.SetValue<int>("Configurations", "Plateholder", (M0) this.Plateholder);
      this.Config.SetValue<int>("Configurations", "RearBumperId", (M0) this.RearBumperId);
      this.Config.SetValue<int>("Configurations", "RightFenderId", (M0) this.RightFenderId);
      this.Config.SetValue<int>("Configurations", "SeatsId", (M0) this.SeatsId);
      this.Config.SetValue<int>("Configurations", "speakers", (M0) this.speakers);
      this.Config.SetValue<int>("Configurations", "speakers", (M0) this.speakers);
      this.Config.SetValue<int>("Configurations", "SpoilersId", (M0) this.SpoilersId);
      this.Config.SetValue<int>("Configurations", "SteeringWheelId", (M0) this.SteeringWheelId);
      this.Config.SetValue<int>("Configurations", "StrutId", (M0) this.StrutId);
      this.Config.SetValue<int>("Configurations", "RoofId", (M0) this.RoofId);
      this.Config.SetValue<int>("Configurations", "SuspensionId", (M0) this.SuspensionId);
      this.Config.SetValue<int>("Configurations", "TransmissionId", (M0) this.TransmissionId);
      this.Config.SetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.Config.SetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.Config.SetValue<int>("Configurations", "TrunkId", (M0) this.TrunkId);
      this.Config.SetValue<int>("Configurations", "VanityPlatesId", (M0) this.VanityPlatesId);
      this.Config.SetValue<int>("Configurations", "WindowId", (M0) this.WindowId);
      this.Config.SetValue<VehicleColor>("Configurations", "PrimaryColor", (M0) this.PrimaryColor);
      this.Config.SetValue<VehicleColor>("Configurations", "SecondaryColor", (M0) this.SecondaryColor);
      this.Config.SetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.Config.SetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.Config.SetValue<VehicleColor>("Configurations", "PearlCent", (M0) this.PearlCent);
      this.Config.SetValue<Color>("Configurations", "NeonColour", (M0) this.NeonColour);
      this.Config.SetValue<VehicleWindowTint>("Configurations", "TintId", (M0) this.TintId);
      this.Config.SetValue<string>("Configurations", "PlanteNo", (M0) this.PlanteNo);
      this.Config.SetValue<int>("Configurations", "Blades", (M0) this.Blades);
      this.Config.SetValue<bool>("Configurations", "HasXenonLights", (M0) (this.HasXenonLights ? 1 : 0));
      this.Config.SetValue<int>("Configurations", "LightColor", (M0) this.LightColor);
      this.Config.SetValue<bool>("Configurations", "TurboActive", (M0) (this.TurboActive ? 1 : 0));
      this.VehicleHash = ((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
      {
        InputArgument.op_Implicit(this.VehicleName)
      })).ToString();
      this.Config.SetValue<Color>("Configurations", "NeonColor", (M0) this.NeonColor);
      this.Config.SetValue<bool>("Configurations", "RightNeonOn", (M0) (this.RightNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "LeftNeonOn", (M0) (this.LeftNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "FrontNeonOn", (M0) (this.FrontNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "BackNeonOn", (M0) (this.BackNeonOn ? 1 : 0));
      this.Config.SetValue<string>("Configurations", "VehicleHash", (M0) this.VehicleHash);
      this.Config.SetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.Config.SetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.Config.SetValue<Color>("Configurations", "TireSmokeColor", (M0) this.TireSmokeColor);
      this.Config.SetValue<bool>("Configurations", "TireSmoke", (M0) (this.TireSmoke ? 1 : 0));
      this.Config.SetValue<VehicleColor>("Configurations", "TrimColor", (M0) this.TrimColor);
      this.Config.SetValue<bool>("Configurations", "BulletProofTires", (M0) (this.BulletProofTires ? 1 : 0));
      if (this.ExtraOn.Count >= 1)
      {
        for (int index = 0; index < this.ExtraOn.Count; ++index)
          this.Config.SetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) (this.ExtraOn[index] ? 1 : 0));
      }
      this.Config.Save();
      if (this.VehicleName == "VOODOO2")
        this.VehicleName = "VOODOO";
      else if (this.VehicleName == "VOODOO")
        this.VehicleName = "VOODOO2";
      if (Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
        ((Entity) Game.get_Player().get_Character().get_CurrentVehicle()).Delete();
    }

    public void SaveCurrentCar(string car, Vehicle V)
    {
      this.VehicleName = car;
      this.RoofId = V.GetMod((VehicleMod) 10);
      this.AerialsId = V.GetMod((VehicleMod) 43);
      this.AirfilterId = V.GetMod((VehicleMod) 40);
      this.ArchCoverId = V.GetMod((VehicleMod) 42);
      this.ArmorId = V.GetMod((VehicleMod) 16);
      this.BackWheelsId = V.GetMod((VehicleMod) 24);
      this.BrakesId = V.GetMod((VehicleMod) 12);
      this.ColumnShifterLeversId = V.GetMod((VehicleMod) 34);
      this.DashboardId = V.GetMod((VehicleMod) 29);
      this.DialDesignId = V.GetMod((VehicleMod) 30);
      this.DoorSpeekersId = V.GetMod((VehicleMod) 31);
      this.EngineId = V.GetMod((VehicleMod) 11);
      this.EngineBlockId = V.GetMod((VehicleMod) 39);
      this.ExaustId = V.GetMod((VehicleMod) 4);
      this.FenderId = V.GetMod((VehicleMod) 8);
      this.FrameId = V.GetMod((VehicleMod) 5);
      this.FrontBumperId = V.GetMod((VehicleMod) 1);
      this.FrontWheelsId = V.GetMod((VehicleMod) 23);
      this.GrilleId = V.GetMod((VehicleMod) 6);
      this.HoodId = V.GetMod((VehicleMod) 7);
      this.HornsId = V.GetMod((VehicleMod) 14);
      this.HydralicsId = V.GetMod((VehicleMod) 38);
      this.LiveryId = V.GetMod((VehicleMod) 48);
      this.OrnamentsId = V.GetMod((VehicleMod) 28);
      this.PlaquesId = V.GetMod((VehicleMod) 35);
      this.Plateholder = V.GetMod((VehicleMod) 25);
      this.RearBumperId = V.GetMod((VehicleMod) 2);
      this.RightFenderId = V.GetMod((VehicleMod) 9);
      this.SeatsId = V.GetMod((VehicleMod) 32);
      this.SideSkirt = V.GetMod((VehicleMod) 3);
      this.speakers = V.GetMod((VehicleMod) 36);
      this.SpoilersId = V.GetMod((VehicleMod) 0);
      this.SteeringWheelId = V.GetMod((VehicleMod) 33);
      this.StrutId = V.GetMod((VehicleMod) 41);
      this.SuspensionId = V.GetMod((VehicleMod) 15);
      this.TankId = V.GetMod((VehicleMod) 45);
      this.TransmissionId = V.GetMod((VehicleMod) 13);
      this.TrimId = V.GetMod((VehicleMod) 44);
      this.TrimDesignId = V.GetMod((VehicleMod) 27);
      this.TrunkId = V.GetMod((VehicleMod) 37);
      this.VanityPlatesId = V.GetMod((VehicleMod) 26);
      this.WindowId = V.GetMod((VehicleMod) 46);
      this.Blades = V.GetMod((VehicleMod) 44);
      this.PrimaryColor = V.get_PrimaryColor();
      this.SecondaryColor = V.get_SecondaryColor();
      this.Wheelcolour = V.get_RimColor();
      this.DashBoardColour = V.get_DashboardColor();
      this.PearlCent = V.get_PearlescentColor();
      this.NeonColour = V.get_NeonLightsColor();
      Vehicle currentVehicle = Game.get_Player().get_Character().get_CurrentVehicle();
      this.HasXenonLights = currentVehicle.IsToggleModOn((VehicleToggleMod) 22);
      this.TurboActive = currentVehicle.IsToggleModOn((VehicleToggleMod) 18);
      this.LightColor = (int) Function.Call<int>((Hash) 4467343895069330651L, new InputArgument[1]
      {
        InputArgument.op_Implicit(currentVehicle)
      });
      this.TintId = V.get_WindowTint();
      this.RightNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 1);
      this.LeftNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 0);
      this.BackNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 3);
      this.FrontNeonOn = currentVehicle.IsNeonLightsOn((VehicleNeonLight) 2);
      this.NeonColor = currentVehicle.get_NeonLightsColor();
      this.TireSmoke = currentVehicle.IsToggleModOn((VehicleToggleMod) 20);
      this.Wheelcolour = currentVehicle.get_RimColor();
      this.DashBoardColour = currentVehicle.get_DashboardColor();
      this.TireSmokeColor = currentVehicle.get_TireSmokeColor();
      this.VehicleHash = ((object) V).GetHashCode().ToString();
      this.PlanteNo = V.get_NumberPlate();
      this.BulletProofTires = V.get_CanTiresBurst();
      this.TrimColor = V.get_TrimColor();
      try
      {
        this.HasClanTag = this.VE.ReturnClanEmblemOn(V);
        this.Config.SetValue<bool>("Configurations", "CLanTagOn", (M0) (this.HasClanTag ? 1 : 0));
      }
      catch (Exception ex)
      {
      }
      if (this.VehicleName == "CARBON")
        this.VehicleName = "CARBONRS";
      if (this.VehicleName == "UTILTRUC")
        this.VehicleName = "UTILLITRUCK";
      if (this.VehicleName == "FORK")
        this.VehicleName = "FORKLIFT";
      if (this.VehicleName == "LANDSTAL")
        this.VehicleName = "LANDSTALKER";
      if (this.VehicleName == "CAVCADE")
        this.VehicleName = "CAVALCADE";
      if (this.VehicleName == "SANCHEZ02")
        this.VehicleName = "SANCHEZ2";
      if (this.VehicleName == "SANCHEZ01")
        this.VehicleName = "SANCHEZ";
      if (this.VehicleName == "FAGGION")
        this.VehicleName = "FAGGIO";
      if (this.VehicleName == "STINGERG")
        this.VehicleName = "FELTZER3";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "KHAMEL")
        this.VehicleName = "KHAMELION";
      if (this.VehicleName == "FURORE")
        this.VehicleName = "FUROREGT";
      if (this.VehicleName == "COGCABRI")
        this.VehicleName = "COGCABRIO";
      if (this.VehicleName == "RLOADER")
        this.VehicleName = "RATLOADER";
      if (this.VehicleName == "RLOADER2")
        this.VehicleName = "RATLOADER2";
      if (this.VehicleName == "FELTZER")
        this.VehicleName = "FELTZER2";
      if (this.VehicleName == "WASHINGT")
        this.VehicleName = "WASHINGTON";
      if (this.VehicleName == "BUFFALO02")
        this.VehicleName = "BUFFALO2";
      if (this.VehicleName == "TAILGATE")
        this.VehicleName = "TAILGATER";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "ASTROPE")
        this.VehicleName = "ASTEROPE";
      if (this.VehicleName == "SANDKIN2")
        this.VehicleName = "SANDKING2";
      if (this.VehicleName == "REBEL02")
        this.VehicleName = "REBEL2";
      if (this.VehicleName == "REBEL01")
        this.VehicleName = "REBEL";
      if (this.VehicleName == "RANCHERX")
        this.VehicleName = "RANCHERXL";
      if (this.VehicleName == "BFINJECT")
        this.VehicleName = "BFINJECTION";
      if (this.VehicleName == "DOMINATO2")
        this.VehicleName = "DOMINATOR2";
      if (this.VehicleName == "DILETTAN")
        this.VehicleName = "DILETTANTE";
      if (this.VehicleName == "VOODOO2")
        this.VehicleName = "VOODOO";
      else if (this.VehicleName == "VOODOO")
        this.VehicleName = "VOODOO2";
      if (this.VehicleName == "ABMULAN")
        this.VehicleName = "AMBULANCE";
      if (this.VehicleName == "Ruiner3")
        this.VehicleName = "Ruiner3";
      if (this.VehicleName == "BUCCANEE2")
        this.VehicleName = "BUCCANEER2";
      if (this.VehicleName == "BUCCANEE")
        this.VehicleName = "BUCCANEER";
      if (this.VehicleName == "CARBONIZ")
        this.VehicleName = "CARBONIZZARE";
      if (this.VehicleName == "penetrator")
        this.VehicleName = "PENETRATOR";
      if (this.VehicleName == "TROPHY")
        this.VehicleName = "TROPHYTRUCK";
      if (this.VehicleName == "TROPHY2")
        this.VehicleName = "TROPHYTRUCK2";
      if (this.VehicleName == "ROOSEVELT")
        this.VehicleName = "Btype";
      if (this.VehicleName == "VERLIER")
        this.VehicleName = "VERLIERER2";
      if (this.VehicleName == "BTYPE2")
        this.VehicleName = "Btype2";
      if (this.VehicleName == "ROOSEVELT2")
        this.VehicleName = "Btype3";
      if (this.VehicleName == "DOMINATO")
        this.VehicleName = "DOMINATOR";
      if (this.VehicleName == "NITESHAD")
        this.VehicleName = "NIGHTSHADE";
      this.Config.SetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
      this.Config.SetValue<int>("Configurations", "Roof", (M0) this.RoofId);
      this.Config.SetValue<int>("Configurations", "AerialsId", (M0) this.AerialsId);
      this.Config.SetValue<int>("Configurations", "AirfilterId", (M0) this.AirfilterId);
      this.Config.SetValue<int>("Configurations", "ArchCoverId", (M0) this.ArchCoverId);
      this.Config.SetValue<int>("Configurations", "ArmorId", (M0) this.ArmorId);
      this.Config.SetValue<int>("Configurations", "BackWheelsId", (M0) this.BackWheelsId);
      this.Config.SetValue<int>("Configurations", "BrakesId", (M0) this.BrakesId);
      this.Config.SetValue<int>("Configurations", "ColumnShifterLeversId", (M0) this.ColumnShifterLeversId);
      this.Config.SetValue<int>("Configurations", "DashboardId", (M0) this.DashboardId);
      this.Config.SetValue<int>("Configurations", "DialDesignId", (M0) this.DialDesignId);
      this.Config.SetValue<int>("Configurations", "DoorSpeekersId", (M0) this.DoorSpeekersId);
      this.Config.SetValue<int>("Configurations", "EngineId", (M0) this.EngineId);
      this.Config.SetValue<int>("Configurations", "EngineBlockId", (M0) this.EngineBlockId);
      this.Config.SetValue<int>("Configurations", "ExaustId", (M0) this.ExaustId);
      this.Config.SetValue<int>("Configurations", "FenderId", (M0) this.FenderId);
      this.Config.SetValue<int>("Configurations", "FrameId", (M0) this.FrameId);
      this.Config.SetValue<int>("Configurations", "FrontBumperId", (M0) this.FrontBumperId);
      this.Config.SetValue<int>("Configurations", "FrontWheelsId", (M0) this.FrontWheelsId);
      this.Config.SetValue<int>("Configurations", "GrilleId", (M0) this.GrilleId);
      this.Config.SetValue<int>("Configurations", "HoodId", (M0) this.HoodId);
      this.Config.SetValue<int>("Configurations", "HornsId", (M0) this.HornsId);
      this.Config.SetValue<int>("Configurations", "HydralicsId", (M0) this.HydralicsId);
      this.Config.SetValue<int>("Configurations", "LiveryId", (M0) this.LiveryId);
      this.Config.SetValue<int>("Configurations", "OrnamentsId", (M0) this.OrnamentsId);
      this.Config.SetValue<int>("Configurations", "PlaquesId", (M0) this.PlaquesId);
      this.Config.SetValue<int>("Configurations", "Plateholder", (M0) this.Plateholder);
      this.Config.SetValue<int>("Configurations", "RearBumperId", (M0) this.RearBumperId);
      this.Config.SetValue<int>("Configurations", "RightFenderId", (M0) this.RightFenderId);
      this.Config.SetValue<int>("Configurations", "SeatsId", (M0) this.SeatsId);
      this.Config.SetValue<int>("Configurations", "speakers", (M0) this.speakers);
      this.Config.SetValue<int>("Configurations", "speakers", (M0) this.speakers);
      this.Config.SetValue<int>("Configurations", "SpoilersId", (M0) this.SpoilersId);
      this.Config.SetValue<int>("Configurations", "SteeringWheelId", (M0) this.SteeringWheelId);
      this.Config.SetValue<int>("Configurations", "StrutId", (M0) this.StrutId);
      this.Config.SetValue<int>("Configurations", "RoofId", (M0) this.RoofId);
      this.Config.SetValue<int>("Configurations", "SuspensionId", (M0) this.SuspensionId);
      this.Config.SetValue<int>("Configurations", "TransmissionId", (M0) this.TransmissionId);
      this.Config.SetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.Config.SetValue<int>("Configurations", "TrimDesignId", (M0) this.TrimDesignId);
      this.Config.SetValue<int>("Configurations", "TrunkId", (M0) this.TrunkId);
      this.Config.SetValue<int>("Configurations", "VanityPlatesId", (M0) this.VanityPlatesId);
      this.Config.SetValue<int>("Configurations", "WindowId", (M0) this.WindowId);
      this.Config.SetValue<VehicleColor>("Configurations", "PrimaryColor", (M0) this.PrimaryColor);
      this.Config.SetValue<VehicleColor>("Configurations", "SecondaryColor", (M0) this.SecondaryColor);
      this.Config.SetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.Config.SetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.Config.SetValue<VehicleColor>("Configurations", "PearlCent", (M0) this.PearlCent);
      this.Config.SetValue<Color>("Configurations", "NeonColour", (M0) this.NeonColour);
      this.Config.SetValue<VehicleWindowTint>("Configurations", "TintId", (M0) this.TintId);
      this.Config.SetValue<string>("Configurations", "PlanteNo", (M0) this.PlanteNo);
      this.Config.SetValue<int>("Configurations", "Blades", (M0) this.Blades);
      this.Config.SetValue<bool>("Configurations", "HasXenonLights", (M0) (this.HasXenonLights ? 1 : 0));
      this.Config.SetValue<int>("Configurations", "LightColor", (M0) this.LightColor);
      this.Config.SetValue<string>("Configurations", "VehicleHash", (M0) this.VehicleHash);
      this.Config.SetValue<bool>("Configurations", "TurboActive", (M0) (this.TurboActive ? 1 : 0));
      this.Config.SetValue<Color>("Configurations", "NeonColor", (M0) this.NeonColor);
      this.Config.SetValue<bool>("Configurations", "RightNeonOn", (M0) (this.RightNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "LeftNeonOn", (M0) (this.LeftNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "FrontNeonOn", (M0) (this.FrontNeonOn ? 1 : 0));
      this.Config.SetValue<bool>("Configurations", "BackNeonOn", (M0) (this.BackNeonOn ? 1 : 0));
      this.Config.SetValue<VehicleColor>("Configurations", "Wheelcolour", (M0) this.Wheelcolour);
      this.Config.SetValue<VehicleColor>("Configurations", "DashBoardColour", (M0) this.DashBoardColour);
      this.Config.SetValue<Color>("Configurations", "TireSmokeColor", (M0) this.TireSmokeColor);
      this.Config.SetValue<bool>("Configurations", "TireSmoke", (M0) (this.TireSmoke ? 1 : 0));
      this.Config.SetValue<VehicleColor>("Configurations", "TrimColor", (M0) this.TrimColor);
      this.Config.SetValue<bool>("Configurations", "BulletProofTires", (M0) (this.BulletProofTires ? 1 : 0));
      if (this.ExtraOn.Count >= 1)
      {
        for (int index = 0; index < this.ExtraOn.Count; ++index)
          this.Config.SetValue<bool>("ToggleableExtras", "Extras" + (object) index, (M0) (this.ExtraOn[index] ? 1 : 0));
      }
      this.Config.Save();
      if (this.VehicleName == "VOODOO2")
      {
        this.VehicleName = "VOODOO";
      }
      else
      {
        if (!(this.VehicleName == "VOODOO"))
          return;
        this.VehicleName = "VOODOO2";
      }
    }

    private void onKeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.E)
        ;
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

    public void SaveName(string Name)
    {
      this.VehicleName = Name;
      this.Config.SetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
      this.Config.Save();
    }

    public void OnTick(object sender, EventArgs e)
    {
    }

    public Model CheckCar2(string iniName)
    {
      this.LoadIniFile(iniName);
      this.VehicleName = (string) this.Config.GetValue<string>("Configurations", "VehicleName", (M0) this.VehicleName);
      if (this.VehicleName == "CARBON")
        this.VehicleName = "CARBONRS";
      if (this.VehicleName == "UTILTRUC")
        this.VehicleName = "UTILLITRUCK";
      if (this.VehicleName == "FORK")
        this.VehicleName = "FORKLIFT";
      if (this.VehicleName == "LANDSTAL")
        this.VehicleName = "LANDSTALKER";
      if (this.VehicleName == "CAVCADE")
        this.VehicleName = "CAVALCADE";
      if (this.VehicleName == "SANCHEZ02")
        this.VehicleName = "SANCHEZ2";
      if (this.VehicleName == "SANCHEZ01")
        this.VehicleName = "SANCHEZ";
      if (this.VehicleName == "FAGGION")
        this.VehicleName = "FAGGIO";
      if (this.VehicleName == "STINGERG")
        this.VehicleName = "FELTZER3";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "SCHWARZE")
        this.VehicleName = "SCHWARZER";
      if (this.VehicleName == "KHAMEL")
        this.VehicleName = "KHAMELION";
      if (this.VehicleName == "FURORE")
        this.VehicleName = "FUROREGT";
      if (this.VehicleName == "COGCABRI")
        this.VehicleName = "COGCABRIO";
      if (this.VehicleName == "RLOADER")
        this.VehicleName = "RATLOADER";
      if (this.VehicleName == "RLOADER2")
        this.VehicleName = "RATLOADER2";
      if (this.VehicleName == "FELTZER")
        this.VehicleName = "FELTZER2";
      if (this.VehicleName == "WASHINGT")
        this.VehicleName = "WASHINGTON";
      if (this.VehicleName == "BUFFALO02")
        this.VehicleName = "BUFFALO2";
      if (this.VehicleName == "TAILGATE")
        this.VehicleName = "TAILGATER";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "SCHAFTER")
        this.VehicleName = "SCHAFTER2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC2")
        this.VehicleName = "COGNOSCENTI2";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "COGNOSC")
        this.VehicleName = "COGNOSCENTI";
      if (this.VehicleName == "ASTROPE")
        this.VehicleName = "ASTEROPE";
      if (this.VehicleName == "SANDKIN2")
        this.VehicleName = "SANDKING2";
      if (this.VehicleName == "REBEL02")
        this.VehicleName = "REBEL2";
      if (this.VehicleName == "REBEL01")
        this.VehicleName = "REBEL";
      if (this.VehicleName == "RANCHERX")
        this.VehicleName = "RANCHERXL";
      if (this.VehicleName == "BFINJECT")
        this.VehicleName = "BFINJECTION";
      if (this.VehicleName == "DOMINATO2")
        this.VehicleName = "DOMINATOR2";
      if (this.VehicleName == "DILETTAN")
        this.VehicleName = "DILETTANTE";
      if (this.VehicleName == "VOODOO2")
        this.VehicleName = "VOODOO";
      else if (this.VehicleName == "VOODOO")
        this.VehicleName = "VOODOO2";
      if (this.VehicleName == "ABMULAN")
        this.VehicleName = "AMBULANCE";
      if (this.VehicleName == "Ruiner3")
        this.VehicleName = "Ruiner3";
      if (this.VehicleName == "BUCCANEE2")
        this.VehicleName = "BUCCANEER2";
      if (this.VehicleName == "BUCCANEE")
        this.VehicleName = "BUCCANEER";
      if (this.VehicleName == "CARBONIZ")
        this.VehicleName = "CARBONIZZARE";
      if (this.VehicleName == "penetrator")
        this.VehicleName = "PENETRATOR";
      if (this.VehicleName == "TROPHY")
        this.VehicleName = "TROPHYTRUCK";
      if (this.VehicleName == "TROPHY2")
        this.VehicleName = "TROPHYTRUCK2";
      if (this.VehicleName == "ROOSEVELT")
        this.VehicleName = "Btype";
      if (this.VehicleName == "VERLIER")
        this.VehicleName = "VERLIERER2";
      if (this.VehicleName == "BTYPE2")
        this.VehicleName = "Btype2";
      if (this.VehicleName == "ROOSEVELT2")
        this.VehicleName = "Btype3";
      if (this.VehicleName == "DOMINATO")
        this.VehicleName = "DOMINATOR";
      if (this.VehicleName == "NITESHAD")
        this.VehicleName = "NIGHTSHADE";
      Model model;
      ((Model) ref model).\u002Ector(this.VehicleName);
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
  }
}
