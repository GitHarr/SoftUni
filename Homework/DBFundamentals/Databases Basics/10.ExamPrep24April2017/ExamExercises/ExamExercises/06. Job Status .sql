SELECT [Status], IssueDate
  FROM Jobs
 WHERE [Status] NOT IN ('Finished')
ORDER BY IssueDate, JobId