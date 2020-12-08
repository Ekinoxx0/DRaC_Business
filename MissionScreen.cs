// Decompiled with JetBrains decompiler
// Type: DRaC_Business.MissionScreen
// Assembly: DRaC_Business, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 46ED2638-FF60-4062-85B3-F169AC3C0185
// Assembly location: C:\Users\Ekinoxx\Desktop\DRaC_Business.dll

using GTA;
using NativeUI;
using System;
using System.Drawing;

namespace DRaC_Business
{
  public class MissionScreen : Script
  {
    public bool Fail;
    public bool Pass;
    public string m;
    public int p;
    public string r;
    public int Timer;

    public void MissionPassed(string MissionName, int Payout)
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 450), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("mission passed", new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 230), 0.5f, Color.White, (Font) 4, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Payout : $" + Payout.ToString("N"), new Point(int32, 300), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void MissionFailed(string Reason, string MissionName)
    {
      this.Pass = false;
      this.Fail = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 30), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 450), 0.0f, Color.FromArgb(230, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("mission failed", new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 148, 27, 46), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 230), 0.5f, Color.White, (Font) 4, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Reason : " + Reason, new Point(int32, 280), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void SetFail(string MissionName, int Payout, string Reason)
    {
      Audio.SetAudioFlag("LoadMPData", true);
      Audio.PlaySoundFrontend("Bed", "WastedSounds");
      Audio.SetAudioFlag("LoadMPData", false);
      this.Timer = 300;
      this.m = MissionName;
      this.p = Payout;
      this.r = Reason;
      this.Fail = true;
      for (int index = 0; index < 100; ++index)
      {
        if (this.Fail)
          this.MissionFailed(this.r, this.m);
        if (this.Pass)
          this.MissionPassed(this.m, this.p);
        Script.Wait(1);
      }
    }

    public void SetPass(string MissionName, int Payout, string Reason)
    {
      Audio.SetAudioFlag("LoadMPData", true);
      Audio.PlaySoundFrontend("Mission_Pass_Notify", "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS");
      Audio.SetAudioFlag("LoadMPData", false);
      this.Timer = 300;
      this.m = MissionName;
      this.p = Payout;
      this.r = Reason;
      this.Pass = true;
      for (int index = 0; index < 100; ++index)
      {
        if (this.Fail)
          this.MissionFailed(this.r, this.m);
        if (this.Pass)
          this.MissionPassed(this.m, this.p);
        Script.Wait(1);
      }
    }

    public MissionScreen()
    {
      base.\u002Ector();
      this.add_Tick(new EventHandler(this.OnTick));
    }

    public void OnTick(object sender, EventArgs e)
    {
      if (this.Timer < 0)
        return;
      --this.Timer;
    }
  }
}
