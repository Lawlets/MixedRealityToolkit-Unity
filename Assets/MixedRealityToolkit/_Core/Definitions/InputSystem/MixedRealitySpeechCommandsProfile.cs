﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Internal.Definitions.InputSystem
{
    /// <summary>
    /// Configuration profile settings for setting up and consuming Speech Commands.
    /// </summary>
    [CreateAssetMenu(menuName = "Mixed Reality Toolkit/Mixed Reality Speech Commands Profile", fileName = "MixedRealitySpeechCommandsProfile", order = 2)]
    public class MixedRealitySpeechCommandsProfile : ScriptableObject
    {
        /// <summary>
        /// Array of configured speech commands to be consumed by the SpeechInputSource
        /// </summary>
        [SerializeField]
        [Tooltip("The list of Speech Commands users use in your application.")]
        private SpeechCommands[] speechCommands = new SpeechCommands[0];
        public SpeechCommands[] SpeechCommands => speechCommands;
    }
}