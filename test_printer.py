from printer_class import Printer

def main():
    # Teste com conexão IP
    try:
        print("Testando impressão de cupom com código de barras rotacionado...")
        printer_ip = Printer()
        printer_ip.connect_to_ip_printer(ip="192.168.1.87", port=9100)  # Substitua pelo IP correto
        print("Conexão IP estabelecida.")
        
        # Teste de impressão
        # printer_ip.print_coupon(
        #     barcode="123456789012",
        #     line_a="Cabeçalho do Cupom",
        #     line_b="Texto do Cupom",
        #     footer="Rodapé do Cupom",
        #     paper_width=80
        # )

        printer_ip.print_barcode_coupon(
            barcode="123456789012",
            line_a="Cabeçalho do Cupom",
            line_b="Texto do Cupom",
            footer="Rodapé do Cupom",
            body="Text Text Text Text Text Text Text \nText Text Text Text Text Text Text \nText Text Text Text Text Text Text \nText Text Text Text Text Text Text \n",
        )
        print("Cupom impresso com sucesso.")
    except Exception as e:
        print(f"Erro ao testar impressão de cupom: {e}")

if __name__ == "__main__":
    main()
