using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkNetCoursePlatform.Persistence.SystemModels
{
    public static class SystemPolicies
    {

        public const string SUPER_ADMIN = nameof(SUPER_ADMIN);

        public const string READ = nameof(READ);
        public const string CREATE = nameof(CREATE);
        public const string UPDATE = nameof(UPDATE);
        public const string DELETE = nameof(DELETE);

        public const string COURSE_READ = nameof(COURSE_READ);
        public const string COURSE_CREATE = nameof(COURSE_CREATE);
        public const string COURSE_DELETE = nameof(COURSE_DELETE);
        public const string COURSE_UPDATE = nameof(COURSE_UPDATE);

        public const string INSTRUCTOR_READ = nameof(INSTRUCTOR_READ);
        public const string INSTRUCTOR_CREATE = nameof(INSTRUCTOR_CREATE);
        public const string INSTRUCTOR_DELETE = nameof(INSTRUCTOR_DELETE);
        public const string INSTRUCTOR_UPDATE = nameof(INSTRUCTOR_UPDATE);

        public const string RATING_READ = nameof(RATING_READ);
        public const string RATING_CREATE = nameof(RATING_CREATE);
        public const string RATING_UPDATE = nameof(RATING_UPDATE);
        public const string RATING_DELETE = nameof(RATING_DELETE);
    }
}