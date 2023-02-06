namespace yzaoui_nasa
{
    public class Close_approach_data
    {
        private string close_approach_date;
        private string close_approach_date_full;
        private long epoch_date_close_approach;
        private Relative_velocity relative_Velocity;
        private Miss_distance miss_Distance;
        private string orbiting_body;
        
        public Close_approach_data(string close_approach_date, string close_approach_date_full, long epoch_date_close_approach, Relative_velocity relative_Velocity, Miss_distance miss_Distance, string orbiting_body)
        {
            this.close_approach_date = close_approach_date;
            this.close_approach_date_full = close_approach_date_full;
            this.epoch_date_close_approach = epoch_date_close_approach;
            this.relative_Velocity = relative_Velocity;
            this.miss_Distance = miss_Distance;
            this.orbiting_body = orbiting_body;
        }

        public string GetCloseApproachDate() => this.close_approach_date;
        public string GetCloseApproachDateFull() => this.close_approach_date_full;
        public long GetEpochDateCloseApproach() => this.epoch_date_close_approach;
        public Relative_velocity GetRelativeVelocity() => this.relative_Velocity;
        public Miss_distance GetMissDistance() => this.miss_Distance;
        public string GetOrbitingBody() => this.orbiting_body;
    }
}