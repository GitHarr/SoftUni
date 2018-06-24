  SELECT MC.CountryCode, COUNT(MC.CountryCode) AS MountainRanges
    FROM Mountains AS M
    JOIN MountainsCountries AS MC
      ON M.Id = MC.MountainId
     AND MC.CountryCode IN ('US','BG','RU')
GROUP BY MC.CountryCode
