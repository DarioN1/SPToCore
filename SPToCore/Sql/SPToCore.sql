SELECT * 
  FROM INFORMATION_SCHEMA.ROUTINES
 WHERE ROUTINE_TYPE = 'PROCEDURE' 
   AND LEFT(ROUTINE_NAME, 3) NOT IN ('sp_', 'xp_', 'ms_')
ORDER BY ROUTINE_NAME


SELECT  
   'Parameter_name' = name,  
   'Type'   = type_name(user_type_id),  
   'Length'   = max_length,  
   'Prec'   = case when type_name(system_type_id) = 'uniqueidentifier' 
              then precision  
              else OdbcPrec(system_type_id, max_length, precision) end,  
   'Scale'   = OdbcScale(system_type_id, scale),  
   'Param_order'  = parameter_id,  
   'Collation'   = convert(sysname, 
                   case when system_type_id in (35, 99, 167, 175, 231, 239)  
                   then ServerProperty('collation') end)  

  from sys.parameters where object_id = object_id('dbo.Bom_ADD_Material')

exec sp_describe_first_result_set N'dbo.Material_GET'


--Scaffold-DbContext "Data Source=DN1;Initial Catalog=EMGERP;Persist Security Info=True;User ID=EMGERP_User;Password=emgerp;Connection Timeout=360" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Test