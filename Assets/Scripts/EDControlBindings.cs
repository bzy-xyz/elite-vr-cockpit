﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EVRC
{
    public class EDControlsBindings
    {
        // EDControlAxis and EDControlButton can be regenerated by opening the following repl
        // pasting your Custom.3.0.binds into it and hitting RUN.
        // https://repl.it/@dantman/EliteVRCockpitControls
        public enum EDControlAxis
        {
            YawAxisRaw,
            RollAxisRaw,
            PitchAxisRaw,
            LateralThrustRaw,
            VerticalThrustRaw,
            AheadThrust,
            YawAxisAlternate,
            RollAxisAlternate,
            PitchAxisAlternate,
            LateralThrustAlternate,
            VerticalThrustAlternate,
            ThrottleAxis,
            YawAxis_Landing,
            PitchAxis_Landing,
            RollAxis_Landing,
            LateralThrust_Landing,
            VerticalThrust_Landing,
            AheadThrust_Landing,
            RadarRangeAxis,
            HeadLookPitchAxisRaw,
            HeadLookYawAxis,
            CamPitchAxis,
            CamYawAxis,
            CamTranslateYAxis,
            CamTranslateXAxis,
            CamTranslateZAxis,
            CamZoomAxis,
            SteeringAxis,
            BuggyRollAxisRaw,
            BuggyPitchAxis,
            BuggyTurretYawAxisRaw,
            BuggyTurretPitchAxisRaw,
            DriveSpeedAxis,
            IncreaseSpeedButtonPartial,
            DecreaseSpeedButtonPartial,
            MultiCrewThirdPersonYawAxisRaw,
            MultiCrewThirdPersonPitchAxisRaw,
            MultiCrewThirdPersonFovAxisRaw,
            MoveFreeCamY,
            MoveFreeCamX,
            MoveFreeCamZ,
            MoveFreeCamUpAxis,
            MoveFreeCamDownAxis,
            PitchCamera,
            YawCamera,
            RollCamera,
            CommanderCreator_Rotation,
        }

        public enum EDControlButton
        {
            MouseReset,
            YawLeftButton,
            YawRightButton,
            YawToRollButton,
            RollLeftButton,
            RollRightButton,
            PitchUpButton,
            PitchDownButton,
            LeftThrustButton,
            RightThrustButton,
            UpThrustButton,
            DownThrustButton,
            ForwardThrustButton,
            BackwardThrustButton,
            UseAlternateFlightValuesToggle,
            ToggleReverseThrottleInput,
            ForwardKey,
            BackwardKey,
            SetSpeedMinus100,
            SetSpeedMinus75,
            SetSpeedMinus50,
            SetSpeedMinus25,
            SetSpeedZero,
            SetSpeed25,
            SetSpeed50,
            SetSpeed75,
            SetSpeed100,
            YawLeftButton_Landing,
            YawRightButton_Landing,
            PitchUpButton_Landing,
            PitchDownButton_Landing,
            RollLeftButton_Landing,
            RollRightButton_Landing,
            LeftThrustButton_Landing,
            RightThrustButton_Landing,
            UpThrustButton_Landing,
            DownThrustButton_Landing,
            ForwardThrustButton_Landing,
            BackwardThrustButton_Landing,
            ToggleFlightAssist,
            UseBoostJuice,
            HyperSuperCombination,
            Supercruise,
            Hyperspace,
            DisableRotationCorrectToggle,
            OrbitLinesToggle,
            SelectTarget,
            CycleNextTarget,
            CyclePreviousTarget,
            SelectHighestThreat,
            CycleNextHostileTarget,
            CyclePreviousHostileTarget,
            TargetWingman0,
            TargetWingman1,
            TargetWingman2,
            SelectTargetsTarget,
            WingNavLock,
            CycleNextSubsystem,
            CyclePreviousSubsystem,
            TargetNextRouteSystem,
            PrimaryFire,
            SecondaryFire,
            CycleFireGroupNext,
            CycleFireGroupPrevious,
            DeployHardpointToggle,
            ToggleButtonUpInput,
            DeployHeatSink,
            ShipSpotLightToggle,
            RadarIncreaseRange,
            RadarDecreaseRange,
            IncreaseEnginesPower,
            IncreaseWeaponsPower,
            IncreaseSystemsPower,
            ResetPowerDistribution,
            HMDReset,
            ToggleCargoScoop,
            EjectAllCargo,
            LandingGearToggle,
            MicrophoneMute,
            UseShieldCell,
            FireChaffLauncher,
            ChargeECM,
            WeaponColourToggle,
            EngineColourToggle,
            UIFocus,
            FocusLeftPanel,
            FocusCommsPanel,
            QuickCommsPanel,
            FocusRadarPanel,
            FocusRightPanel,
            GalaxyMapOpen,
            SystemMapOpen,
            ShowPGScoreSummaryInput,
            HeadLookToggle,
            Pause,
            FriendsMenu,
            UI_Up,
            UI_Down,
            UI_Left,
            UI_Right,
            UI_Select,
            UI_Back,
            UI_Toggle,
            CycleNextPanel,
            CyclePreviousPanel,
            HeadLookReset,
            HeadLookPitchUp,
            HeadLookPitchDown,
            HeadLookYawLeft,
            HeadLookYawRight,
            CamPitchUp,
            CamPitchDown,
            CamYawLeft,
            CamYawRight,
            CamTranslateForward,
            CamTranslateBackward,
            CamTranslateLeft,
            CamTranslateRight,
            CamTranslateUp,
            CamTranslateDown,
            CamZoomIn,
            CamZoomOut,
            CamTranslateZHold,
            ToggleDriveAssist,
            SteerLeftButton,
            SteerRightButton,
            BuggyRollLeftButton,
            BuggyRollRightButton,
            BuggyPitchUpButton,
            BuggyPitchDownButton,
            VerticalThrustersButton,
            BuggyPrimaryFireButton,
            BuggySecondaryFireButton,
            AutoBreakBuggyButton,
            HeadlightsBuggyButton,
            ToggleBuggyTurretButton,
            SelectTarget_Buggy,
            BuggyTurretYawLeftButton,
            BuggyTurretYawRightButton,
            BuggyTurretPitchUpButton,
            BuggyTurretPitchDownButton,
            BuggyToggleReverseThrottleInput,
            IncreaseSpeedButtonMax,
            DecreaseSpeedButtonMax,
            IncreaseEnginesPower_Buggy,
            IncreaseWeaponsPower_Buggy,
            IncreaseSystemsPower_Buggy,
            ResetPowerDistribution_Buggy,
            ToggleCargoScoop_Buggy,
            EjectAllCargo_Buggy,
            RecallDismissShip,
            UIFocus_Buggy,
            FocusLeftPanel_Buggy,
            FocusCommsPanel_Buggy,
            QuickCommsPanel_Buggy,
            FocusRadarPanel_Buggy,
            FocusRightPanel_Buggy,
            GalaxyMapOpen_Buggy,
            SystemMapOpen_Buggy,
            HeadLookToggle_Buggy,
            MultiCrewToggleMode,
            MultiCrewPrimaryFire,
            MultiCrewSecondaryFire,
            MultiCrewPrimaryUtilityFire,
            MultiCrewSecondaryUtilityFire,
            MultiCrewThirdPersonYawLeftButton,
            MultiCrewThirdPersonYawRightButton,
            MultiCrewThirdPersonPitchUpButton,
            MultiCrewThirdPersonPitchDownButton,
            MultiCrewThirdPersonFovOutButton,
            MultiCrewThirdPersonFovInButton,
            MultiCrewCockpitUICycleForward,
            MultiCrewCockpitUICycleBackward,
            OrderRequestDock,
            OrderDefensiveBehaviour,
            OrderAggressiveBehaviour,
            OrderFocusTarget,
            OrderHoldFire,
            OrderHoldPosition,
            OrderFollow,
            OpenOrders,
            PhotoCameraToggle,
            PhotoCameraToggle_Buggy,
            VanityCameraScrollLeft,
            VanityCameraScrollRight,
            ToggleFreeCam,
            VanityCameraOne,
            VanityCameraTwo,
            VanityCameraThree,
            VanityCameraFour,
            VanityCameraFive,
            VanityCameraSix,
            VanityCameraSeven,
            VanityCameraEight,
            VanityCameraNine,
            FreeCamToggleHUD,
            FreeCamSpeedInc,
            FreeCamSpeedDec,
            ToggleReverseThrottleInputFreeCam,
            MoveFreeCamForward,
            MoveFreeCamBackwards,
            MoveFreeCamRight,
            MoveFreeCamLeft,
            MoveFreeCamUp,
            MoveFreeCamDown,
            PitchCameraUp,
            PitchCameraDown,
            YawCameraLeft,
            YawCameraRight,
            RollCameraLeft,
            RollCameraRight,
            ToggleRotationLock,
            FixCameraRelativeToggle,
            FixCameraWorldToggle,
            QuitCamera,
            ToggleAdvanceMode,
            FreeCamZoomIn,
            FreeCamZoomOut,
            FStopDec,
            FStopInc,
            CommanderCreator_Undo,
            CommanderCreator_Redo,
            CommanderCreator_Rotation_MouseToggle,
            GalnetAudio_Play_Pause,
            GalnetAudio_SkipForward,
            GalnetAudio_SkipBackward,
            GalnetAudio_ClearQueue,
        }

        public struct ControlButtonBinding
        {
            public struct KeyModifier
            {
                public string Device;
                public string Key;
            }

            public struct KeyBinding
            {
                public string Device;
                public string Key;
                public HashSet<KeyModifier> Modifiers;

                public bool IsValid
                {
                    get { return Device != "{NoDevice}"; }
                }

                // Is this a Keyboard key press we can act on?
                public bool IsValidKeypress
                {
                    get
                    {
                        // Is it on the Keyboard device?
                        if (Device != "Keyboard") return false;

                        foreach (var modifier in Modifiers)
                        {
                            if (modifier.Device != "Keyboard") return false;
                        }

                        return true;
                    }
                }
            }

            public KeyBinding Primary;
            public KeyBinding Secondary;

            public bool HasKeyboardKeybinding
            {
                get
                {
                    return Primary.IsValidKeypress || Secondary.IsValidKeypress;
                }
            }

            public KeyBinding? KeyboardKeybinding
            {
                get
                {
                    if (Primary.IsValidKeypress) return Primary;
                    if (Secondary.IsValidKeypress) return Secondary;
                    return null;
                }
            }
        }

        private Dictionary<EDControlButton, ControlButtonBinding> buttonBindings = new Dictionary<EDControlButton, ControlButtonBinding>();

        private EDControlsBindings() { }

        /**
         * Check to see if a button has a keyboard keybinding we can act on
         */
        public bool HasKeyboardKeybinding(EDControlButton button)
        {
            if (!buttonBindings.ContainsKey(button)) return false;

            var buttonBinding = buttonBindings[button];
            return buttonBinding.HasKeyboardKeybinding;
        }

        /**
         * Get a keyboard keybinding for a button
         */
        public ControlButtonBinding.KeyBinding? GetKeyboardKeybinding(EDControlButton button)
        {
            if (buttonBindings.ContainsKey(button))
            {
                var buttonBinding = buttonBindings[button];
                return buttonBinding.KeyboardKeybinding;
            }

            return null;
        }

        public static EDControlsBindings ParseFile(string customBindingsOptionsPath)
        {
            var bindings = new EDControlsBindings();

            var doc = XDocument.Load(customBindingsOptionsPath);
            foreach (var control in doc.Descendants())
            {
                if (Enum.IsDefined(typeof(EDControlButton), control.Name.LocalName))
                {
                    var controlButton = (EDControlButton)Enum.Parse(typeof(EDControlButton), control.Name.LocalName);

                    var controlBinding = new ControlButtonBinding();
                    controlBinding.Primary = ParseControlBinding(control, "Primary");
                    controlBinding.Secondary = ParseControlBinding(control, "Secondary");

                    bindings.buttonBindings.Add(controlButton, controlBinding);
                }

                // @todo Parse axis and options if we ever have a use for them
            }

            return bindings;
        }

        private static ControlButtonBinding.KeyBinding ParseControlBinding(XElement control, string nodeName)
        {
            var node = (from el in control.Descendants(nodeName) select el).First();
            var keyBinding = new ControlButtonBinding.KeyBinding
            {
                Device = node.Attribute("Device").Value,
                Key = node.Attribute("Key").Value,
                Modifiers = new HashSet<ControlButtonBinding.KeyModifier>(),
            };

            foreach (var modifier in node.Descendants("Modifier"))
            {
                keyBinding.Modifiers.Add(new ControlButtonBinding.KeyModifier
                {
                    Device = modifier.Attribute("Device").Value,
                    Key = modifier.Attribute("Key").Value,
                });
            }

            return keyBinding;
        }
    }
}
