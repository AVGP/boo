uniform sampler2D map;
varying vec2 vUv;

void main() {
    vec3 rgb = texture2D(map, vUv).rgb;
    gl_FragColor = vec4(1.0 - rgb.r, 1.0 - rgb.g, 1.0 - rgb.b, 1.0);
}
