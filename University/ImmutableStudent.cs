namespace University;

using static StudentStatus;
public record ImmutableStudent
    (int Id,
    string GivenName,
    string Surname,
    StudentStatus Status,
    DateTime StartDate,
    DateTime EndDate,
    DateTime GraduationDate);