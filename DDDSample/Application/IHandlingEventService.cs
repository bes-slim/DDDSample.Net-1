﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DDDSample.Domain.Location;
using DDDSample.Domain.Cargo;
using DDDSample.Domain.Handling;
using DDDSample.Domain.Voyage;

namespace DDDSampleNET.Application
{
   /// <summary>
   /// Handling event service.
   /// </summary>
   public interface HandlingEventService
   {      
      /// <summary>
      /// Registers a handling event in the system, and notifies interested parties that a 
      /// cargo has been handled.
      /// </summary>
      /// <param name="completionTime">Date and time when the event was completed.</param>
      /// <param name="trackingId">Cargo tracking id.</param>
      /// <param name="voyageNumber">Voyage number.</param>
      /// <param name="unLocode">UN locode for the location where the event occurred.</param>
      /// <param name="type">Type of event.</param> 
      /// <exception cref="CannotCreateHandlingEventException">if a handling event that represents 
      /// an actual event that's relevant to a cargo we're tracking can't be created from the 
      /// parameters </exception>
      void RegisterHandlingEvent(DateTime completionTime, TrackingId trackingId, VoyageNumber voyageNumber, UnLocode unLocode, HandlingEventType type);
   }
}