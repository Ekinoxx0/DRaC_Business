// Decompiled with JetBrains decompiler
// Type: DRaC_Business.AllStocks
// Assembly: DRaC_Business, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 46ED2638-FF60-4062-85B3-F169AC3C0185
// Assembly location: C:\Users\Ekinoxx\Desktop\DRaC_Business.dll

using GTA;
using GTA.Native;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DRaC_Business
{
  public class AllStocks : Script
  {
    private ScriptSettings Config2;
    private ScriptSettings Config;
    public int waittime;
    public int stockstimer;
    public int purchaselvl;
    public int maxstocks;
    public float stocksvalue;
    public float profitMargin;
    public int stockscount;
    public bool ShowStockIncrease;
    public string HostName;
    public BlipColor Blip_Colour;
    public string Uicolour;
    public Color MarkerColor;
    public string MarkerColorString;
    public int Casino_level;
    public DateTime CurrentDate;
    public DateTime NextDate;
    public int DaysWait;
    public int NextDay;
    public int NextMonth;
    public int NextYear;
    public bool BYPASS_NOSAVE_OR_CRASH;
    public int DAYSTORESET_UPDATETIME;
    public int Now;

    public AllStocks()
    {
      base.\u002Ector();
      this.add_Tick(new EventHandler(this.OnTick));
      this.add_KeyDown(new KeyEventHandler(this.OnKeyDown));
      this.set_Interval(1);
      this.LoadIniFile2("scripts//DC&R//Main.ini");
      this.LoadIniFile("scripts//DC&R//Casino.ini");
      this.Now = this.GetDay();
    }

    public string GetHostName() => "~" + this.Uicolour + "~ " + this.HostName + "~w~ ";

    public void UpdateValues() => this.LoadIniFile("scripts//DC&R//Casino.ini");

    public void IncreaseGain(string iniName)
    {
      this.LoadIniFile(iniName);
      this.stocksvalue += (float) (125000 * this.purchaselvl) / 0.75f;
      this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
      this.Config.Save();
    }

    public void DecreaseGain(string iniName)
    {
      this.LoadIniFile(iniName);
      this.stocksvalue -= (float) (125000 * this.purchaselvl) / 1.45f;
      this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
      this.Config.Save();
    }

    public void SetDate()
    {
      this.LoadIniFile("scripts//ExecutiveBusiness//Main.ini");
      if (this.GetDay() + this.DaysWait <= 30)
      {
        this.NextDay = this.GetDay() + this.DaysWait;
        this.NextMonth = this.GetMonth();
      }
      if (this.GetDay() + this.DaysWait > 30)
      {
        this.NextDay = -(30 - (this.GetDay() + this.DaysWait));
        if (this.GetMonth() + 1 <= 12)
          this.NextMonth = this.GetDay() + 1;
        if (this.GetMonth() + 1 > 12)
          this.NextMonth = 1;
      }
      this.NextYear = this.GetYear();
      this.Config.SetValue<int>("Setup", "NextYear", (M0) this.NextYear);
      this.Config.SetValue<int>("Setup", "NextDay", (M0) this.NextDay);
      this.Config.SetValue<int>("Setup", "NextMonth", (M0) this.NextMonth);
      this.Config.Save();
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

    public void GetDateRelative()
    {
      if (!this.BYPASS_NOSAVE_OR_CRASH || this.Now == this.GetDay())
        return;
      this.Now = this.GetDay();
      int num1 = this.GetDay() + this.DAYSTORESET_UPDATETIME;
      int num2 = this.GetMonth();
      int year = this.GetYear();
      if (num1 < 0)
      {
        num1 = -num1;
        if (this.GetMonth() + 1 <= 12)
          num2 = this.GetMonth() + 1;
        if (this.GetMonth() + 1 > 12)
          num2 = 1;
      }
      if (num1 > 30)
        num1 = 30;
      if (this.GetMonth() + 1 > 12)
        num2 = 1;
      if (num1 <= this.NextDay && num2 <= this.NextMonth || (num2 < this.NextMonth || num2 > this.NextMonth) || year != this.NextYear)
      {
        this.NextMonth = this.GetMonth();
        this.NextDay = this.GetDay() + this.DaysWait;
        this.NextYear = this.GetYear();
        this.Config.SetValue<int>("Setup", "NextYear", (M0) this.NextYear);
        this.Config.SetValue<int>("Setup", "NextDay", (M0) this.NextDay);
        this.Config.SetValue<int>("Setup", "NextMonth", (M0) this.NextMonth);
        this.Config.Save();
      }
    }

    public int GetHour() => (int) Function.Call<int>((Hash) 2675767815307398015L, new InputArgument[0]);

    public int GetMinutes() => (int) Function.Call<int>((Hash) 1428407088615670002L, new InputArgument[0]);

    public int GetDay() => (int) Function.Call<int>((Hash) 4400224173958044981L, new InputArgument[0]);

    public int GetMonth() => (int) Function.Call<int>((Hash) -4915917506096244831L, new InputArgument[0]);

    public int GetYear() => (int) Function.Call<int>((Hash) -7631499212557191401L, new InputArgument[0]);

    private void OnTick(object sender, EventArgs e)
    {
      this.GetDateRelative();
      if (this.GetDay() == this.NextDay && this.GetMonth() == this.NextMonth)
      {
        this.SetDate();
        this.LoadIniFile("scripts//DC&R//Casino.ini");
        if (this.Config.GetValue<int>("Setup", "BuisnessLevel", (M0) this.purchaselvl) >= 1 && this.Config.GetValue<int>("Setup", "Casinoi_Upgrade_Level", (M0) this.Casino_level) >= 2)
        {
          int num = new Random().Next(1, 1000);
          if (num < 350)
          {
            this.DecreaseGain("scripts//DC&R//Casino.ini");
            this.LoadIniFile2("scripts//DC&R//Main.ini");
            if (this.ShowStockIncrease)
            {
              this.LoadIniFile("scripts//DC&R//Casino.ini");
              UI.Notify(this.GetHostName() + " : Stocks for the Diamond Casino & Resort just Decreased!");
            }
          }
          else if (num >= 350)
          {
            this.IncreaseGain("scripts//DC&R//Casino.ini");
            this.LoadIniFile2("scripts//DC&R//Main.ini");
            if (this.ShowStockIncrease)
            {
              this.LoadIniFile("scripts//DC&R//Casino.ini");
              UI.Notify(this.GetHostName() + "  Stocks for Diamond Casino & Resort Business just increased!");
            }
          }
        }
        this.Config.Save();
        this.stockstimer = 0;
      }
      else
        ++this.stockstimer;
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
    }

    private void LoadIniFile2(string iniName)
    {
      try
      {
        this.Config2 = ScriptSettings.Load(iniName);
        this.ShowStockIncrease = (bool) this.Config2.GetValue<bool>("Setup", "ShowStockIncrease", (M0) (this.ShowStockIncrease ? 1 : 0));
        try
        {
          this.NextDay = (int) this.Config2.GetValue<int>("Setup", "NextDay", (M0) this.NextDay);
          this.NextMonth = (int) this.Config2.GetValue<int>("Setup", "NextMonth", (M0) this.NextMonth);
          this.NextYear = (int) this.Config2.GetValue<int>("Setup", "NextYear", (M0) this.NextYear);
          this.DaysWait = (int) this.Config2.GetValue<int>("Setup", "DaysWait", (M0) this.DaysWait);
          this.BYPASS_NOSAVE_OR_CRASH = (bool) this.Config2.GetValue<bool>("Setup", "BYPASS_NOSAVE_OR_CRASH", (M0) (this.BYPASS_NOSAVE_OR_CRASH ? 1 : 0));
          this.DAYSTORESET_UPDATETIME = (int) this.Config2.GetValue<int>("Setup", "DAYSTORESET_UPDATETIME", (M0) this.DAYSTORESET_UPDATETIME);
        }
        catch (Exception ex)
        {
          this.NextDay = 10;
          this.Config2.SetValue<int>("Setup", "NextDay", (M0) this.NextDay);
          this.NextMonth = 10;
          this.Config2.SetValue<int>("Setup", "NextMonth", (M0) this.NextMonth);
          this.NextYear = 2010;
          this.Config2.SetValue<int>("Setup", "NextYear", (M0) this.NextYear);
          this.DaysWait = 3;
          this.Config2.SetValue<int>("Setup", "DaysWait", (M0) this.DaysWait);
          this.BYPASS_NOSAVE_OR_CRASH = true;
          this.Config2.SetValue<bool>("Setup", "BYPASS_NOSAVE_OR_CRASH", (M0) (this.BYPASS_NOSAVE_OR_CRASH ? 1 : 0));
          this.DAYSTORESET_UPDATETIME = 12;
          this.Config2.SetValue<int>("Setup", "DAYSTORESET_UPDATETIME", (M0) this.DAYSTORESET_UPDATETIME);
          this.Config2.Save();
        }
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: Config.ini Failed To Load.");
      }
    }

    private void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.ShowStockIncrease = (bool) this.Config.GetValue<bool>("Setup", "ShowStockIncrease", (M0) (this.ShowStockIncrease ? 1 : 0));
        this.waittime = (int) this.Config.GetValue<int>("Setup", "WaitTime", (M0) this.waittime);
        this.HostName = (string) this.Config.GetValue<string>("Misc", "HostName", (M0) this.HostName);
        this.Blip_Colour = (BlipColor) this.Config.GetValue<BlipColor>("Misc", "Blip_Colour", (M0) this.Blip_Colour);
        this.Uicolour = (string) this.Config.GetValue<string>("Misc", "Uicolour", (M0) this.Uicolour);
        this.MarkerColorString = (string) this.Config.GetValue<string>("Misc", "MarkerColor", (M0) this.MarkerColorString);
        this.MarkerColor = Color.FromName(this.MarkerColorString);
        this.Casino_level = (int) this.Config.GetValue<int>("Setup", "Casinoi_Upgrade_Level", (M0) this.Casino_level);
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: Config.ini Failed To Load.");
      }
    }
  }
}
