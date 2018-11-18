-- PONER FK 
alter table emp_empresa
add constraint FKdoc
foreign key(tipo_doc)
references emp_documento(id);
--procedimiento INSERT_EMPRESA

CREATE OR REPLACE FUNCTION public.emp_insert
(
  IN  d_ruc                 varchar,
  IN  d_empresa             varchar,
  IN  d_direccion           varchar,
  IN  d_fecha               timestamp without time zone,
  IN  d_nombre_comercial    varchar,
  IN  d_tipo_contribuyente  varchar,
  IN  d_ubigeo              integer,
  IN  d_departamento        varchar,
  IN  d_provincia           varchar,
  IN  d_distrito            varchar,
  IN  d_tipo_documento      integer                    
)
RETURNS varchar AS
$$
DECLARE
EmpresaE VARCHAR;

BEGIN



	   insert into emp_empresa (ruc,empresa,direccion,fecha,nombre_comercial,tipo_contribuyente,ubigeo,departamento,provincia,distrito,tipo_doc) values (d_ruc,d_empresa,d_direccion,d_fecha,d_nombre_comercial,d_tipo_contribuyente,d_ubigeo,d_departamento,d_provincia,d_distrito,d_tipo_documento) RETURNING ruc||'-'||empresa into EmpresaE ;
	 
       return EmpresaE;


END;
$$
LANGUAGE 'plpgsql';

ALTER FUNCTION public.emp_insert(varchar, varchar, varchar, timestamp without time zone, varchar, varchar, integer, varchar, varchar, varchar, integer)
  OWNER TO postgres;