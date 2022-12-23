namespace Be.Vlaanderen.Basisregisters.GrAr.Contracts.BuildingRegistry
{
    using System;
    using Contracts;
    using Common;

    public class BuildingBecameUnderConstruction : IQueueMessage
    {
        public Guid BuildingId { get; }
        public Provenance Provenance { get; }

        public BuildingBecameUnderConstruction(
            Guid buildingId,
            Provenance provenance)
        {
            BuildingId = buildingId;
            Provenance = provenance;
        }
    }
}
