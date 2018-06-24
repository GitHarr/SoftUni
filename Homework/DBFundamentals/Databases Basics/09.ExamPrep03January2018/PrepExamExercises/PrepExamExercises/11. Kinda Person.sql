SELECT Manufacturer, Model, SUM(CountOfOrdersId) AS TimesOrdered
FROM(
SELECT m.Manufacturer, m.Model, v.Id,
       COUNT(v.Id) AS CountOfOrdersId
  FROM Orders AS o
  LEFT JOIN Vehicles AS v ON v.Id = o.VehicleId
  RIGHT JOIN Models AS m ON m.Id = v.ModelId
GROUP BY m.Manufacturer, m.Model, v.Id) 
AS H1
GROUP BY Manufacturer, Model
ORDER BY TimesOrdered DESC, Manufacturer DESC, Model
