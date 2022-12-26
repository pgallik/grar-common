namespace Be.Vlaanderen.Basisregisters.GrAr.Contracts.BuildingRegistry
{
    using System;
    using Common;

    public class BuildingUnitWasRetired : IQueueMessage
    {
        public Guid BuildingId { get; }

        public Guid BuildingUnitId { get; }

        public Provenance Provenance { get; }

        public BuildingUnitWasRetired(Guid buildingId,
            Guid buildingUnitId,
            Provenance provenance)
        {
            BuildingId = buildingId;
            BuildingUnitId = buildingUnitId;
            Provenance = provenance;
        }
    }
}
