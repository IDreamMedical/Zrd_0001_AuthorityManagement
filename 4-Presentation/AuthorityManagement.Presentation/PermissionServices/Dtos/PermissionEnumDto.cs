namespace AuthorityManagement.Presentations.PermissionServices.Dtos
{
    using System;

    using AuthorityManagement.Presentation.Dtos;

    /// <summary>
    /// Ȩ��ö�ٵ�DTO.
    /// </summary>
    public class PermissionEnumDto : IOutputDto
    {
        /// <summary>
        /// Ȩ��ֵ.
        /// </summary>
        public Enum PermissionValue { get; set; }

        /// <summary>
        /// ��ɫ�Ƿ�ӵ��Ȩ��.
        /// </summary>
        public bool RoleHas { get; set; }

        /// <summary>
        /// ģ���Ƿ�ӵ��Ȩ��.
        /// </summary>
        public bool FunctionHas { get; set; }
    }
}