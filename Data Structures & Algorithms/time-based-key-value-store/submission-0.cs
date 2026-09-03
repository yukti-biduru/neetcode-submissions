public class TimeMap {

        private Dictionary<string, List<Tuple<int, string>>> kvps;
        
        public TimeMap()
        {
            kvps = new Dictionary<string, List<Tuple<int, string>>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if(!kvps.ContainsKey(key))
            {
                kvps[key] = new List<Tuple<int, string>>();
            }
            kvps[key].Add(Tuple.Create(timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if(!kvps.ContainsKey(key))
            {
                return "";
            }
            
            var values = kvps[key];
            int l = 0, r = values.Count - 1;
            string result = "";

            while (l<=r)
            {
                int m = (l + r) / 2;

                if (values[m].Item1 <= timestamp)
                {
                    result = values[m].Item2;
                    l = m + 1;
                }
                else
                    r = m - 1;
            }
            return result;
        }
}
