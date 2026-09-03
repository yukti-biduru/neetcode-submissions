public class TimeMap {

        Dictionary<string, List<Tuple<string, int>>> kvps;
        public TimeMap()
        {
            kvps = new Dictionary <string, List<Tuple<string, int>>>();

        }

        public void Set(string key, string value, int timestamp)
        {
            if(!kvps.ContainsKey(key))
            {
                kvps[key] = new List<Tuple<string, int>>();
            }
            kvps[key].Add(Tuple.Create(value, timestamp));
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
                if (values[m].Item2 <= timestamp)
                {
                    result = values[m].Item1;
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return result;
        }
}
