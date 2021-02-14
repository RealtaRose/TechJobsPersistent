--Part 1
SELECT *
FROM jobs

--Part 2
SELECT *
FROM jobs
WHERE employer.location = "Saint Louis"

--Part 3

SELECT *
FROM skills
LEFT JOIN jobskills ON skills.Id = jobskills.SkillId
WHERE jobskills.JobId IS NOT NULL
ORDER BY name ASC;