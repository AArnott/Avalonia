// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;

namespace Avalonia.Input
{
    /// <summary>
    /// Manages focus for the application.
    /// </summary>
    public interface IFocusManager
    {
        /// <summary>
        /// Gets the currently focused <see cref="IInputElement"/> or null if <see cref="HasEffectiveFocus"/> == false
        /// </summary>
        IInputElement FocusedElement { get; }

        /// <summary>
        /// Focuses a control.
        /// </summary>
        /// <param name="control">The control to focus.</param>
        /// <param name="method">The method by which focus was changed.</param>
        /// <param name="modifiers">Any input modifiers active at the time of focus.</param>
        bool Focus(
            IInputElement control, 
            NavigationMethod method = NavigationMethod.Unspecified,
            InputModifiers modifiers = InputModifiers.None);

        /// <summary>
        /// Gets or sets a value indicating whether this particular focus manager instance
        /// has the effective input focus (i. e. the associated window is currently active)
        /// </summary>
        bool HasEffectiveFocus {get; set; }

        /// <summary>
        /// Fires when FocusedElement is changed
        /// </summary>
        event EventHandler FocusedElementChanged;
    }
}
