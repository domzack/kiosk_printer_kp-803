# Kiosk Printer KP-803

Este repositório contém a implementação de uma classe Python para controle de impressoras térmicas compatíveis com ESC/POS, como o modelo KP-803. Ele inclui funcionalidades para impressão de texto, códigos de barras, configuração de papel, e monitoramento de status em tempo real.

## Estrutura do Repositório

### Arquivos principais

- **`printer_class.py`**: 
  Contém a classe `Printer`, que encapsula os comandos ESC/POS para comunicação com impressoras térmicas via porta serial ou IP. Principais funcionalidades:
  - Configuração de papel e caracteres.
  - Impressão de códigos de barras.
  - Monitoramento de status em tempo real.
  - Controle de retração e corte de papel.

- **`.gitignore`**: 
  Arquivo para ignorar arquivos e pastas que não devem ser rastreados pelo Git, como `__pycache__`, ambientes virtuais (`venv/`), e arquivos temporários.

- **`requirements.txt`**:
  Lista as dependências necessárias para o projeto, como `pyserial`.

### Funcionalidades da Classe `Printer`

1. **Conexão com a impressora**:
   - Via porta serial.
   - Via IP usando sockets.

2. **Configuração**:
   - Tamanho do papel.
   - Tamanho e estilo dos caracteres.
   - Direção de impressão.

3. **Impressão**:
   - Texto.
   - Códigos de barras com suporte a diferentes sistemas (EAN13, CODE39, etc.).
   - Cupom com layout customizado.

4. **Monitoramento**:
   - Status em tempo real da impressora (ex.: status do papel, erros).
   - Extração de bits específicos do status, como o **Bit 7**.

5. **Controle**:
   - Retração do papel.
   - Corte do papel.

## Como usar

### Requisitos

- Python 3.x
- Biblioteca `pyserial` para comunicação serial:
  ```bash
  pip install -r requirements.txt
  ```

### Exemplo de uso

```python
from printer_class import Printer

# Conectar à impressora via IP
printer = Printer()
printer.connect_to_ip_printer(ip="192.168.1.100", port=9100)

# Configurar e imprimir um cupom
printer.print_coupon(
    barcode="123456789012",
    line_a="Cabeçalho do Cupom",
    line_b="Texto do Cupom",
    footer="Rodapé do Cupom",
    paper_width=80
)

# Monitorar status do papel e extrair o Bit 7
status = printer.get_real_time_status(1)
bit_7 = (int.from_bytes(status, 'big') >> 7) & 1
print(f"Bit 7 do status do papel: {bit_7}")
```

## Contribuição

Sinta-se à vontade para abrir issues ou enviar pull requests para melhorias ou correções.

## Licença

Este projeto está licenciado sob a [MIT License](https://opensource.org/licenses/MIT).