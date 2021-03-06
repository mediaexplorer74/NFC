// SampleConfigurations

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using NfcSample;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "NFC Sample";

        List<Scenario> scenarios = new List<Scenario>
        {
            //new Scenario() { Title="HCE Tap+Pay", ClassType=typeof(ManageCardScenario)},
            new Scenario() { Title="Card Reader", ClassType=typeof(CardReader)},
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
