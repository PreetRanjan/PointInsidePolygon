# Point Inside Polygon
This API can check if a point lies inside a polygon or not.
This is a very small useful feature if you are doing geospatial analysis with points and polygon data.

Request Body Example:
-
inputPoint:
The point/co-ordinate you want to check if it lies inside the polygon or isochrone or not.

polygon:
The series of points which makes a valid polygon. It should have 3 or more vertices. Make sure the polygon is closed i.e. First and last point is same.
~~~
{
    "inputPoint": {
        "x": 5,
        "y": 8
    },
    "polygon": [
        {
            "x": 0,
            "y": 0
        },
        {
            "x": 20,
            "y": 0
        },
        {
            "x": 20,
            "y": 20
        },
        {
            "x": 0,
            "y": 20
        }
    ]
}
~~~

Put the above JSON in the HTTP request body.
Make a call to /api/PointInsidePolygon

Response:
-
~~~
{
  "isInside": true,
  "message": "Point is inside the given polygon"
}
~~~

This is based on the algorithm described in:
[https://www.dcs.gla.ac.uk/~pat/52233/slides/Geometry1x1.pdf](https://www.dcs.gla.ac.uk/~pat/52233/slides/Geometry1x1.pdf)

Code reference:
[https://www.geeksforgeeks.org/how-to-check-if-a-given-point-lies-inside-a-polygon/](https://www.geeksforgeeks.org/how-to-check-if-a-given-point-lies-inside-a-polygon/)
