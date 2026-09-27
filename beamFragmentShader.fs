#version 330 core
out vec4 FragColor;

uniform vec4 beamColor;

void main()
{
    FragColor = beamColor;
}
