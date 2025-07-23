import serial
import socket
import time

class Printer:
    ESC = 0x1B

    def __init__(self, port=None):
        self.serial = None
        self.socket = None
        if port:
            self.serial = serial.Serial(port, baudrate=9600)

    def connect_to_ip_printer(self, ip, port=9100):
        """
        Conecta a uma impressora via IP usando sockets.
        :param ip: Endereço IP da impressora.
        :param port: Porta da impressora (padrão: 9100).
        """
        self.socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.socket.connect((ip, port))

    def send_data(self, data):
        """
        Envia dados para a impressora conectada.
        :param data: Dados a serem enviados (bytes).
        """
        if self.serial:
            self.serial.write(data)
        elif self.socket:
            if self.socket.fileno() != -1:  # Verifica se o socket está conectado
                self.socket.sendall(data)
            else:
                raise ConnectionError("Socket desconectado.")
        else:
            raise ConnectionError("Nenhuma impressora conectada.")

    def reset_printer(self):
        self.send_data(bytes([self.ESC]))
        self.send_data(b'@')

    def set_paper_size(self, size):
        self.send_data(bytes([0x1D]))
        self.send_data(b'W')
        nl, nh = (0, 2) if size == 80 else (104, 1)
        self.send_data(bytes([nl, nh]))

    def set_character_size(self, size):
        self.send_data(bytes([0x1D]))
        self.send_data(b'!')
        self.send_data(bytes([size]))

    def set_alignment(self, alignment):
        self.send_data(bytes([self.ESC]))
        self.send_data(b'a')
        self.send_data(bytes([alignment]))

    def set_bold(self, bold):
        self.send_data(bytes([self.ESC]))
        self.send_data(b'G')
        self.send_data(bytes([1 if bold else 2]))

    def set_font(self, font):
        self.send_data(bytes([0x1D]))
        self.send_data(b'f')
        self.send_data(bytes([font]))

    def advance_paper(self, lines):
        for _ in range(lines):
            self.send_data(b'\n')

    def set_barcode_position(self, position):
        self.send_data(bytes([0x1D]))
        self.send_data(b'H')
        self.send_data(bytes([position]))

    def set_barcode_width(self, width):
        self.send_data(bytes([0x1D]))
        self.send_data(b'w')
        self.send_data(bytes([width]))

    def set_barcode_height(self, height_percent):
        height = min(255, (255 * height_percent) // 100)
        self.send_data(bytes([0x1D]))
        self.send_data(b'h')
        self.send_data(bytes([height]))

    def prepare_barcode(self, system):
        self.send_data(bytes([0x1D]))
        self.send_data(b'k')
        self.send_data(bytes([system]))

    def print_barcode(self, code):
        while len(code) < 12:
            code = '0' + code
        self.send_data(code.encode())
        self.send_data(bytes([0, 0]))

    def cut_paper(self):
        self.send_data(bytes([0x1D]))
        self.send_data(b'V')
        self.send_data(bytes([0]))

    def set_print_direction(self, direction):
        """
        Configura a direção de impressão no modo de página.
        :param direction: Direção de impressão (0: esquerda para direita, 1: base para topo, 2: direita para esquerda, 3: topo para base).
        """
        self.send_data(bytes([self.ESC]))
        self.send_data(b'T')
        self.send_data(bytes([direction]))

    def print_coupon(self, barcode, line_a, line_b, footer, paper_width=80):
        self.reset_printer()
        self.set_paper_size(paper_width)
        self.set_character_size(0)
        self.set_alignment(1)
        self.set_bold(True)
        self.set_font(1)

        self.send_data(line_b.encode() + b'\n')
        self.send_data(barcode.encode() + b'\n')

        self.reset_printer()
        self.set_character_size(0)
        self.set_alignment(0)
        self.set_bold(False)
        self.set_font(1)
        self.advance_paper(5)

        # Rotacionar o código de barras em 90 graus
        self.set_print_direction(1)  # Base para topo
        self.set_barcode_position(0)
        self.set_barcode_width(3)
        self.set_barcode_height(100)
        self.prepare_barcode(2)
        self.print_barcode(barcode)

        self.send_data(bytes([0x0C]))  # Commit
        self.reset_printer()
        self.set_paper_size(paper_width)
        self.advance_paper(1)
        self.send_data(footer.encode())
        self.advance_paper(2)

        self.reset_printer()
        self.set_character_size(17)
        self.set_alignment(1)
        self.set_bold(True)
        self.set_font(1)
        self.advance_paper(2)
        self.send_data(line_a.encode() + b'\n')

        self.cut_paper()
        self.reset_printer()

    def print_barcode_coupon(self, barcode, line_a, line_b, footer, paper_width=80, body=""):
        """
        Imprime um cupom com código de barras, replicando o comportamento da função Arduino.
        :param barcode: Código de barras a ser impresso.
        :param line_a: Texto do cabeçalho.
        :param line_b: Texto do corpo do cupom.
        :param footer: Texto do rodapé.
        :param paper_width: Largura do papel (padrão: 80mm).
        """
        # Resetar e configurar impressora
        self.reset_printer()
        self.set_paper_size(paper_width)
        self.set_character_size(0)
        self.set_alignment(1)
        self.set_bold(True)
        self.set_font(1)

        # Imprimir linha B e código de barras
        self.send_data(line_b.encode() + b'\n')
        self.send_data(barcode.encode() + b'\n')

        # Resetar e configurar modo de impressão
        self.reset_printer()
        self.set_character_size(0)
        self.set_alignment(0)
        self.set_bold(False)
        self.set_font(1)
        self.advance_paper(1)

        # Configurar modo de página e sentido de impressão
        self.reset_printer()
        self.send_data(bytes([self.ESC]))
        self.send_data(b'L')  # Modo de página
        self.send_data(bytes([self.ESC]))
        self.send_data(b'W')  # Área de impressão
        # self.send_data(bytes([0, 0, 0, 0, 0, 2, 126, 1]))  # Configuração da área
        self.send_data(bytes([0, 0, 0, 0, 0, 100, 50, 1]))  # Configuração da área

        self.send_data(bytes([self.ESC]))
        self.send_data(b'T')  # Sentido de impressão
        self.send_data(bytes([1]))  # Base para topo

        # Configurar e imprimir código de barras
        # self.set_character_size(0)
        # self.set_alignment(0)
        self.advance_paper(7)
        self.set_bold(False)
        self.set_font(1)
        self.set_barcode_position(0)
        self.set_barcode_width(3)
        self.set_barcode_height(100)
        self.prepare_barcode(2)
        self.print_barcode(barcode)

        self.advance_paper(2)
        self.send_data(barcode.encode())
        self.advance_paper(1)
        self.send_data(body.encode())

        # Commit e resetar
        self.send_data(bytes([0x0C]))  # Commit

        self.send_data(bytes([0x0C]))  # Commit

        self.reset_printer()
        self.set_paper_size(paper_width)
        self.advance_paper(1)
        self.send_data(footer.encode())
        self.advance_paper(2)

        # Imprimir cabeçalho
        self.reset_printer()
        self.set_character_size(17)
        self.set_alignment(1)
        self.set_bold(True)
        self.set_font(1)
        self.advance_paper(2)
        self.send_data(line_a.encode() + b'\n')

        # Cortar papel e resetar
        self.cut_paper()
        # self.reset_printer()

        while True:
            status_paper = self.get_real_time_status(1)
            bit_7 = (int.from_bytes(status_paper, 'big') >> 7) & 1  # Extrai o Bit 7
            print(f"Bit 7 do status do papel: {bit_7}")
            time.sleep(1)

    def set_retraction_time(self, time_ms):
        """
        Configura o tempo de retração do papel antes do corte.
        :param time_ms: Tempo de retração em milissegundos.
        """
        time_units = min(255, time_ms // 100)  # Converte para unidades de 100 ms, máximo 255
        self.send_data(bytes([0x1D]))  # GS
        self.send_data(b'V')          # V
        self.send_data(bytes([66]))   # Modo de retração (66 para configurar tempo)
        self.send_data(bytes([time_units]))

    def get_real_time_status(self, status_type):
        """
        Transmite o status em tempo real da impressora.
        :param status_type: Tipo de status a ser transmitido (1: status da impressora, 2: status off-line, 3: status de erro, 4: status do sensor de papel).
        :return: Resposta da impressora.
        """
        if status_type not in [1, 2, 3, 4]:
            raise ValueError("status_type deve ser 1, 2, 3 ou 4.")
        
        self.send_data(bytes([0x10]))  # DLE
        self.send_data(bytes([0x04]))  # EOT
        self.send_data(bytes([status_type]))  # Tipo de status
        
        # Ler resposta da impressora
        if self.serial:
            return self.serial.read(1)  # Lê 1 byte de resposta
        elif self.socket:
            return self.socket.recv(1)  # Lê 1 byte de resposta
        else:
            raise ConnectionError("Nenhuma impressora conectada.")
