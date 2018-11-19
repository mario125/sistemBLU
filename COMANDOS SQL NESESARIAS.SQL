--CONSULTA DATOS SUNAT C#--------------------------------------------------------------------------------------
public IDictionary<string, string> getRUC(CPE da, string RUTA, string NOMBRE)
        {
            var countQuery = new Dictionary<string, string>();
            string json = @"{'token': '0b186c2a-3c65-4406-a6c3-791193a8c680-9ae7deb8-38e8-4446-901b-d738b7333afd','ruc':'";json=json+ 10477931500+ "'}";
            
            try
            {            
                Task<string> callTask23 = Task.Run(() => GET_RUC_SUNAT(json,  "https://ruc.com.pe/api/v1/ruc"));
                //// Espere a que termine
                callTask23.Wait();
                //// Obtener el resultado
                TIKET = callTask23.Result;
            }
            catch (Exception ex)  //Exceptions here or in the function will be caught here
            {
                countQuery.Add("TIKET", "ERROR DE CONEXION");               
            }
            return countQuery;
        }
        static public async Task<string> GET_RUC_SUNAT(string JSON,string URL)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    JObject rss = JObject.Parse(JSON);
                    var content = new StringContent(rss.ToString(), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(URL, content);
                    string DATA = await response.Content.ReadAsStringAsync();
                    return DATA.ToString();
                }
                catch (Exception E)
                {
                    return E.Message;
                }
                    
            }
        }

--RUC SUNAT PHP------------------------------------------------------------------
<?php

$ruta = "https://ruc.com.pe/api/v1/ruc";
$token = "0b186c2a-3c65-4406-a6c3-791193a8c680-9ae7deb8-38e8-4446-901b-d738b7333afd";

$rucaconsultar = '20505161051';

$data = array(
    "token"	=> $token,
    "ruc"   => $rucaconsultar
);
	
$data_json = json_encode($data);

// Invocamos el servicio a ruc.com.pe
// Ejemplo para JSON
$ch = curl_init();
curl_setopt($ch, CURLOPT_URL, $ruta);
curl_setopt(
	$ch, CURLOPT_HTTPHEADER, array(
	'Content-Type: application/json',
	)
);
curl_setopt($ch, CURLOPT_POST, 1);
curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);
curl_setopt($ch, CURLOPT_POSTFIELDS,$data_json);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
$respuesta  = curl_exec($ch);
curl_close($ch);

$leer_respuesta = json_decode($respuesta, true);
if (isset($leer_respuesta['errors'])) {
	//Mostramos los errores si los hay
    echo $leer_respuesta['errors'];
} else {
	//Mostramos la respuesta
	echo "Respuesta de la API:<br>";
	print_r($leer_respuesta);
}
--RUC SUNAR VISUAL BASIC-------------------------------------------------------------------------------------

            strSOAP = "{'token': '0b186c2a-3c65-4406-a6c3-791193a8c680-9ae7deb8-38e8-4446-901b-d738b7333afd',
                         'ruc':'" & 10477931508 & "'
                         }"
            Dim parse = js.Parse(strSOAP)
            Dim serial As New seri.JavaScriptSerializer()
            Dim outputJSON As String = serial.Serialize(parse.ToString)
            Dim json1 As String = serial.Serialize(outputJSON)
            File.WriteAllText("D:/MARIO125.json", parse.ToString)

            Dim returned_value As String
            Dim strPostData As String
            Dim objRequest As Object

            strPostData = strSOAP
            --objRequest = CreateObject("MSXML2.XMLHTTP.3.0")
            objRequest = CreateObject("MSXML2.ServerXMLHTTP")
            With objRequest
                .Open("POST", url, False)
                .setRequestHeader("Content-Type", "application/json")
                .setRequestHeader("Accept", "application/json")
                .send(parse.ToString)
                returned_value = .responseText
            End With
            Dim parse2 = js.Parse(returned_value)








-- PONER FK --------------------------------------------------------
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