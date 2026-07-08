#!/bin/bash
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
CYAN='\033[0;36m'
NC='\033[0m'

echo -e "${CYAN}╔════════════════════════════════════════════════════╗${NC}"
echo -e "${CYAN}║                      BUILD LOCAL                   ║${NC}"
echo -e "${CYAN}╚════════════════════════════════════════════════════╝${NC}"

dotnet clean
dotnet publish ./Bienvenute/Bienvenute.csproj -c Release -r linux-x64 --self-contained true
dotnet publish ./PokerFace/PokerFace.csproj -c Release -r linux-x64 --self-contained true

echo -e "\n${YELLOW}🐳 Construyendo imágenes Docker...${NC}"
docker compose -f docker-compose.yml build
if [ $? -ne 0 ]; then
    echo -e "${RED}❌ Error al construir las imágenes${NC}"
    exit 1
fi

echo -e "\n${YELLOW}🚀 Levantando contenedores...${NC}"
docker compose -f docker-compose.yml up -d --force-recreate
if [ $? -ne 0 ]; then
    echo -e "${RED}❌ Error al levantar los contenedores${NC}"
    exit 1
fi

echo -e "\n${GREEN}✅ ¡Contenedores levantados exitosamente!${NC}"
echo -e "${GREEN}🌐 Bienvenute: http://localhost:5601/swagger${NC}"
echo -e "${GREEN}🌐 Pokerface: http://localhost:5602/swagger${NC}"