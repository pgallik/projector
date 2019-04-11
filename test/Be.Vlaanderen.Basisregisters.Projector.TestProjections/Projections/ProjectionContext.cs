namespace Be.Vlaanderen.Basisregisters.Projector.TestProjections.Projections
{
    using Microsoft.EntityFrameworkCore;
    using ProjectionHandling.Runner;

    public class ProjectionContext : RunnerDbContext<ProjectionContext>
    {
        public override string ProjectionStateSchema => Schemas.Projections;

        public ProjectionContext(DbContextOptions<ProjectionContext> options)
            :base(options)
        { }
    }
}
