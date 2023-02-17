using InsidePolygon.Models;

namespace Knowwhere.Services
{
    public class IsoService
    {

        static int INF_MAX = 10000;


        static bool onSegment(Point p, Point q, Point r)
        {
            if (q.X <= Math.Max(p.X, r.X) &&
                q.X >= Math.Min(p.X, r.X) &&
                q.Y <= Math.Max(p.Y, r.Y) &&
                q.Y >= Math.Min(p.Y, r.Y))
            {
                return true;
            }
            return false;
        }


        static int orientation(Point p, Point q, Point r)
        {
            var val = ((q.Y - p.Y) * (r.X - q.X) -
                    (q.X - p.X) * (r.Y - q.Y));

            if (val == 0)
            {
                return 0;
            }
            return (val > 0) ? 1 : 2;
        }

        static bool doIntersect(Point p1, Point q1,
                                Point p2, Point q2)
        {

            int o1 = orientation(p1, q1, p2);
            int o2 = orientation(p1, q1, q2);
            int o3 = orientation(p2, q2, p1);
            int o4 = orientation(p2, q2, q1);


            if (o1 != o2 && o3 != o4)
            {
                return true;
            }


            if (o1 == 0 && onSegment(p1, p2, q1))
            {
                return true;
            }


            if (o2 == 0 && onSegment(p1, q2, q1))
            {
                return true;
            }


            if (o3 == 0 && onSegment(p2, p1, q2))
            {
                return true;
            }


            if (o4 == 0 && onSegment(p2, q1, q2))
            {
                return true;
            }


            return false;
        }


        public static bool isInside(Point[] polygon, int n, Point p)
        {

            if (n < 3)
            {
                return false;
            }


            Point extreme = new Point(INF_MAX, p.Y);


            int count = 0, i = 0;
            do
            {
                int next = (i + 1) % n;

                if (doIntersect(polygon[i],
                                polygon[next], p, extreme))
                {
                    if (orientation(polygon[i], p, polygon[next]) == 0)
                    {
                        return onSegment(polygon[i], p,
                                        polygon[next]);
                    }
                    count++;
                }
                i = next;
            } while (i != 0);

            return (count % 2 == 1);
        }
    }
}
