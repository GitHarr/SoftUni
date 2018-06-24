  SELECT MC.CountryCode, M.MountainRange, P.PeakName, P.Elevation
    FROM Peaks AS P
    JOIN MountainsCountries AS MC
      ON P.MountainId = MC.MountainId
     AND MC.CountryCode = 'BG'
    JOIN Mountains AS M
      ON P.MountainId = M.Id
   WHERE P.Elevation > 2835
ORDER BY P.Elevation DESC  

	